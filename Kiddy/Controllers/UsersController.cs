using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Kiddy.Models.Entity;
using Kiddy.Models;
using Kiddy.Common.Security;
using Kiddy.Common;

namespace Kiddy.Controllers
{
    public class UsersController : BaseController
    {
        KiddyEntities db = new KiddyEntities();
        BaseController bC = new BaseController();
        // GET: api/Users
        public List<UserResponse> Get([FromBody]UserToken userToken)
        {
            List<UserResponse> users = new List<UserResponse>();
            if (bC.validateToken(userToken.AccessToken, userToken.UserID))
            {
                users = db.Users.Select<User, UserResponse>(x => new UserResponse
                {
                    ID = x.ID,
                    UserID = x.UserID,
                    password = "",
                    Email = x.Email,
                    CreatedBy = x.CreatedBy,
                    CreatedOn = x.CreatedOn,
                    RowStatus = x.RowStatus
                }).ToList();
            }

            return users;
        }

        // GET: api/Users/5
        public UserResponse Get([FromBody]UsersID user)
        {
            User resultUser = new User();
            resultUser = db.Users.Where(x => x.ID == user.ID).FirstOrDefault();
            if (!bC.validateToken(user.userToken, user.UserLogin))
            {
                return new UserResponse() { Message = "Validate Token Error", statusCode = HttpStatusCode.Unauthorized };
            }

            UserResponse userResponse = new UserResponse();
            userResponse.ID = resultUser.ID;
            userResponse.UserID = resultUser.UserID;
            userResponse.Email = resultUser.Email;
            userResponse.CreatedBy = resultUser.CreatedBy;
            userResponse.CreatedOn = resultUser.CreatedOn;
            userResponse.RowStatus = resultUser.RowStatus;
            return userResponse;
        }

        // POST: api/Users
        public BaseResponse Post([FromBody]UsersRegister userRegister)
        {
            BaseResponse baseResponse = new BaseResponse();
            List<User> checkUser = db.Users.Where(x => x.UserID == userRegister.UserID && x.RowStatus != true).ToList();
            if (checkUser.Count() > 0)
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        baseResponse.Message = "Model Not Valid";
                        baseResponse.statusCode = HttpStatusCode.BadRequest;
                        baseResponse.aknowledge = 0;
                        return baseResponse;
                    }

                    User user = new User();
                    user.password = Encryptor.Encrypt(userRegister.password);
                    user.UserID = userRegister.UserID;
                    user.Email = userRegister.Email;
                    user.CreatedBy = "System";
                    user.CreatedOn = DateTime.Now;
                    user.ModifiedBy = "";
                    user.ModifiedOn = new DateTime(1900, 1, 1);

                    var add = db.Users.Add(user);

                    
                    db.SaveChanges();

                    UsersInRole uir = new UsersInRole();
                    uir.UsersID = db.Users.Where(x => x.UserID == userRegister.UserID).FirstOrDefault().ID;
                    if (userRegister.isAdmin == 1)
                    {
                        uir.RoleID = db.Roles.Where(x => x.Role1 == "Admin").FirstOrDefault().ID;
                    }
                    else
                    {
                        uir.RoleID = db.Roles.Where(x => x.Role1 == "User").FirstOrDefault().ID;
                    }
                    uir.CreatedBy = "System";
                    uir.CreatedOn = DateTime.Now;
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    baseResponse.Message = "ERROR when trying to save changes, Error : " + ex;
                    baseResponse.statusCode = HttpStatusCode.BadRequest;
                    baseResponse.aknowledge = 0;
                    return baseResponse;
                }

                baseResponse.Message = "Success";
                baseResponse.statusCode = HttpStatusCode.OK;
                baseResponse.aknowledge = 1;
                return baseResponse;
            }
            baseResponse.Message = "User Exist";
            baseResponse.statusCode = HttpStatusCode.BadRequest;
            baseResponse.aknowledge = 0;
            return baseResponse;
        }

        // PUT: api/Users/5
        public BaseResponse Put([FromBody]UserUpdate usersUpdate)
        {
            BaseResponse baseResponse = new BaseResponse();
            List<User> checkUser = db.Users.Where(x => x.UserID == usersUpdate.UserID && x.RowStatus != true).ToList();
            if (checkUser.Count() > 0)
            {
                if (!bC.validateToken(usersUpdate.userToken, usersUpdate.UserLogin))
                {
                    baseResponse.Message = "ERROR";
                    baseResponse.statusCode = HttpStatusCode.Unauthorized;
                    baseResponse.aknowledge = 0;
                    return baseResponse;
                }

                var updateUser = db.Users.Where(x => x.ID == usersUpdate.ID).FirstOrDefault();
                if (updateUser != null)
                {
                    updateUser.UserID = usersUpdate.UserID;
                    updateUser.password = usersUpdate.password;
                    updateUser.Email = usersUpdate.Email;
                    updateUser.ModifiedBy = usersUpdate.UserLogin;
                    updateUser.ModifiedOn = DateTime.Now;
                    updateUser.RowStatus = usersUpdate.RowStatus;
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        baseResponse.Message = "ERROR when trying to save changes, Error : " + ex;
                        baseResponse.statusCode = HttpStatusCode.BadRequest;
                        baseResponse.aknowledge = 0;
                        return baseResponse;
                    }
                }
                else
                {
                    baseResponse.Message = "ERROR";
                    baseResponse.statusCode = HttpStatusCode.BadRequest;
                    baseResponse.aknowledge = 0;
                    return baseResponse;
                }

                baseResponse.Message = "Success";
                baseResponse.statusCode = HttpStatusCode.OK;
                baseResponse.aknowledge = 1;
                return baseResponse;
            }
            baseResponse.Message = "User Exist";
            baseResponse.statusCode = HttpStatusCode.BadRequest;
            baseResponse.aknowledge = 0;
            return baseResponse;
        }

        // DELETE: api/Users/5
        public BaseResponse Delete([FromBody]UsersID usersID)
        {
            BaseResponse baseResponse = new BaseResponse();

            if (!bC.validateToken(usersID.userToken, usersID.UserLogin))
            {
                baseResponse.Message = "ERROR";
                baseResponse.statusCode = HttpStatusCode.Unauthorized;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            var updateUsers = db.Users.Where(x => x.ID == usersID.ID && x.RowStatus != true).FirstOrDefault();
            if (updateUsers != null)
            {
                updateUsers.RowStatus = true;
                if (updateUsers.isMaster == true)
                {
                    baseResponse.Message = "ERROR, Cant delete master Admin";
                    baseResponse.statusCode = HttpStatusCode.BadRequest;
                    baseResponse.aknowledge = 0;
                    return baseResponse;
                }

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    baseResponse.Message = "ERROR when trying to save changes, Error : " + ex;
                    baseResponse.statusCode = HttpStatusCode.BadRequest;
                    baseResponse.aknowledge = 0;
                    return baseResponse;
                }
            }
            else
            {
                baseResponse.Message = "ERROR";
                baseResponse.statusCode = HttpStatusCode.BadRequest;
                baseResponse.aknowledge = 0;
                return baseResponse;
            }

            baseResponse.Message = "Success";
            baseResponse.statusCode = HttpStatusCode.OK;
            baseResponse.aknowledge = 1;
            return baseResponse;

        }
    }
}
