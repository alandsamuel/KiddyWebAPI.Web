using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiddy.Models
{
    public class LoginResponse : BaseResponse
    {
        public string AccessToken { get; set; }
        public int UserIDID { get; set; }
        public string UserID { get; set; }
        public int isAdmin { get; set; }
    }
}