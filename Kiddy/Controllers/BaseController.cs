using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kiddy.Models;
using Kiddy.Models.Entity;
using Kiddy.Common;
using System.Web.Http;
using Kiddy.Common.Security;
using System.Web.Mvc;
using Kiddy.Models;
using Kiddy.Models.Entity;

namespace Kiddy.Controllers
{
    public class BaseController : ApiController
    {
        KiddyEntities db = new KiddyEntities();
        public bool validateToken(string token, string userID)
        {
            int ID = db.Users.Where(x => x.UserID == userID).FirstOrDefault().ID;
            string encryptedDBToken = Encryptor.Decrypt(db.Tokens.Where(x => x.UsersID == ID && x.RowStatus != true).OrderByDescending(x => x.CreatedOn).FirstOrDefault().AccessToken);
            if (encryptedDBToken == null)
            {
                return false;
            }
            string tokenFromClient = Encryptor.Decrypt(token);
            if (encryptedDBToken == tokenFromClient)
            {
                byte[] data = Convert.FromBase64String(encryptedDBToken);
                DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
                if (when < DateTime.UtcNow.AddHours(-1))
                {
                    return false;
                }
                return true;
            }

            return false;
        }

    }
}