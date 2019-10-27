using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Kiddy.Models.Entity;
using Kiddy.Common.Security;
using Kiddy.Common;
using Kiddy.Models;

namespace Kiddy.Controllers
{
    public class LoginController : BaseController
    {
        private KiddyEntities db = new KiddyEntities();

        // POST: api/Login
        
        public LoginResponse Post([FromBody]UsersLogin userLogin)
        {
            User user = db.Users.Where<User>(x => x.UserID == userLogin.UserID).FirstOrDefault();
            LoginResponse loginResponse = new LoginResponse();

            if (user != null)
            {
                string decryptPassword = Encryptor.Encrypt(userLogin.password);

                #region authentication

                if (decryptPassword == user.password.Trim())
                {
                    Token lastToken = db.Tokens.Where(x => x.UsersID == user.ID && x.RowStatus != true).OrderByDescending(x => x.CreatedOn).FirstOrDefault();
                    if (lastToken != null)
                    {
                        lastToken.RowStatus = true;

                        try
                        {
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            loginResponse.aknowledge = 0;
                            loginResponse.Message = "Failed Update Last Token";
                            loginResponse.statusCode = HttpStatusCode.BadRequest;

                            return loginResponse;
                        }
                    }
                    #region generateToken
                    byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                    byte[] key = Guid.NewGuid().ToByteArray();
                    string accessToken = Encryptor.Encrypt(Convert.ToBase64String(time.Concat(key).ToArray()));
                    #endregion

                    #region builder
                    Token tokenData = new Token();
                    tokenData.AccessToken = accessToken;
                    tokenData.UsersID = user.ID;
                    tokenData.CreatedBy = user.UserID;
                    tokenData.CreatedOn = DateTime.Now;
                    loginResponse.AccessToken = accessToken;
                    loginResponse.UserID = user.UserID;
                    loginResponse.UserIDID = user.ID;
                    #endregion

                    db.Tokens.Add(tokenData);

                    db.SaveChanges();
                    loginResponse.aknowledge = 1;
                    loginResponse.Message = "Login succefull";
                    loginResponse.statusCode = HttpStatusCode.OK;
                }

                db.SaveChanges();
                loginResponse.aknowledge = 1;
                loginResponse.Message = "Login succefull";
                loginResponse.statusCode = HttpStatusCode.OK;
                #endregion
            }
            else
            {
                loginResponse.aknowledge = 0;
                loginResponse.Message = "Failed";
                loginResponse.statusCode = HttpStatusCode.NotAcceptable;
            }


            return loginResponse;
        }


    }
}
