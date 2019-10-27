using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kiddy.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Kiddy.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using Nancy.Json;
using Nancy.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using R4Mvc;
using Kiddy.Common;

namespace Kiddy.Web.Controllers
{
    public partial class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IConfiguration configuration;
        static HttpClient client = new HttpClient();

        public HomeController(ILogger<HomeController> logger, IConfiguration iConfig)
        {
            _logger = logger;
            configuration = iConfig;
        }

        public virtual IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Index(UsersLogin usersLogin)
        {
            UserToken userToken = new UserToken();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/Login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            var content = JsonConvert.SerializeObject(usersLogin);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(content);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                userToken = (UserToken)js.Deserialize<UserToken>(result);
            }

            if (userToken.AccessToken != null)
            {
                var sessionTicket = Encryptor.Encrypt(userToken.AccessToken + "|" + userToken.UserID);
                HttpContext.Session.SetString("SessionTicket", sessionTicket);
            }
            return View();
        }

        public virtual IActionResult Logout()
        {
            HttpContext.Session.Clear();

            if (ViewBag.data == null)
            {
                return View(MVC.Home.Index());
            }
            return View();
        }

        public virtual IActionResult SignUp()
        {
            //var session = HttpContext.Session.GetString("SessionTicket");
            //ViewBag.data = session;
            //string[] decryptSession = (Encryptor.Decrypt(session)).Split('|');

            //ViewBag.UserToken = decryptSession[0];
            //ViewBag.UserToken = decryptSession[0];
            //if (ViewBag.data == null)
            //{
            //    return View(MVC.Home.Error());
            //}
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public virtual IActionResult SignUp(UsersRegister usersLogin)
        {
            BaseResponse userToken = new BaseResponse();

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/Users");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            var content = JsonConvert.SerializeObject(usersLogin);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(content);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                userToken = (BaseResponse)js.Deserialize<BaseResponse>(result);
            }
            ViewBag.StatusCode = userToken.statusCode.ToString();
            ViewBag.Message = userToken.Message;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public virtual IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
