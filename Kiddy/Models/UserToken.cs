using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiddy.Models
{
    public class UserToken
    {
        public string AccessToken { get; set; }
        public int ID { get; set; }
        public string UserID { get; set; }
    }
}