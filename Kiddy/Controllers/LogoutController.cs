using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Kiddy.Models.Entity;
using Kiddy.Common.Security;
using Kiddy.Common;
using Kiddy.Models;

namespace Kiddy.Controllers
{
    public class LogoutController : ApiController
    {
        private KiddyEntities db = new KiddyEntities();
        // POST: api/Logout
        public BaseResponse Post([FromBody]UserToken userToken)
        {
            var userLogin = db.Users.Where(x => x.UserID == userToken.UserID).FirstOrDefault();
            var Token = db.Tokens.Where(x => x.UsersID == userLogin.ID && x.RowStatus != true).FirstOrDefault();

            #region make Token Invalid
            Token.RowStatus = true;
            #endregion

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return new BaseResponse() { Message = ex.Message, statusCode = HttpStatusCode.BadRequest, aknowledge = 0 };
                
            }

            return new BaseResponse() { Message = "Succes Logout", aknowledge = 1, statusCode = HttpStatusCode.OK };
        }

    }
}
