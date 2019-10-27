using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Kiddy.Models
{
    public class BaseResponse
    {
        public string Message { get; set; }
        public int aknowledge { get; set; }

        public HttpStatusCode statusCode { get; set; }

    }
}