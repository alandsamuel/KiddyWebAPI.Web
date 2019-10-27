using System;
using System.Collections.Generic;
using System.Text;
using Kiddy.Common;
using Kiddy.Common.Security;


namespace Kiddy.Common
{
    class Validator
    {

        private bool validateToken(string token, int userID)
        {
            //string encryptedDBToken = Encryptor.Decrypt(db.Tokens.Where(x => x.UsersID == userID).OrderByDescending(x => x.CreatedOn).FirstOrDefault().AccessToken);
            //string tokenFromClient = Encryptor.Decrypt(token);
            //if (encryptedDBToken == tokenFromClient)
            //{
            //    byte[] data = Convert.FromBase64String(encryptedDBToken);
            //    DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            //    if (when < DateTime.UtcNow.AddHours(-24))
            //    {
            //        return false;
            //    }
            //    return true;
            //}

            return false;
        }
    }
}
