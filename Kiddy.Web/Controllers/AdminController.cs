using System;
using System.Collections.Generic;
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
using Kiddy.Models.Base;
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
    public partial class AdminController : Controller
    {
        // GET: Admin
        public virtual ActionResult Index()
        {
            var session = HttpContext.Session.GetString("SessionTicket");
            ViewBag.data = session;
            string[] decryptSession = (Encryptor.Decrypt(session)).Split('|');

            string userToken = decryptSession[0];
            string userLogin = decryptSession[1];
            ViewBag.UserToken = userToken;
            ViewBag.UserLogin = userLogin;
            if (ViewBag.data == null)
            {
                return View(MVC.Home.Logout());
            }

            ShapesForDisplay saveShape = new ShapesForDisplay();

            BaseRequest Request = new BaseRequest();
            Request.UserLogin = userLogin;
            Request.userToken = userToken;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/Shapes");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var content = JsonConvert.SerializeObject(Request);

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
                saveShape = (ShapesForDisplay)js.Deserialize<ShapesForDisplay>(result);
            }
            ViewBag.StatusCode = saveShape.statusCode.ToString();
            ViewBag.Message = saveShape.Message;

            return View(saveShape);
            //list all shapes
        }

        // GET: Admin/Details/5
        public virtual ActionResult Details(int id)
        {
            var session = HttpContext.Session.GetString("SessionTicket");
            ViewBag.data = session;
            string[] decryptSession = (Encryptor.Decrypt(session)).Split('|');

            string userTokenSession = decryptSession[0];
            string userLoginSession = decryptSession[1];
            ViewBag.UserToken = userTokenSession;
            ViewBag.UserLogin = userLoginSession;
            if (ViewBag.data == null)
            {
                return View(MVC.Home.Logout());
            }

            ShapesForDisplay saveShape = new ShapesForDisplay();

            BaseRequest Request = new BaseRequest();
            Request.UserLogin = userTokenSession;
            Request.userToken = userLoginSession;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/Shapes/" + id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                saveShape = (ShapesForDisplay)js.Deserialize<ShapesForDisplay>(result);
            }
            ViewBag.StatusCode = saveShape.statusCode.ToString();
            ViewBag.Message = saveShape.Message;

            return View(saveShape);
        }

        public virtual ActionResult DeleteAdmin(int id)
        {
            var session = HttpContext.Session.GetString("SessionTicket");
            ViewBag.data = session;
            string[] decryptSession = (Encryptor.Decrypt(session)).Split('|');

            string userTokenSession = decryptSession[0];
            string userLoginSession = decryptSession[1];
            ViewBag.UserToken = userTokenSession;
            ViewBag.UserLogin = userLoginSession;
            if (ViewBag.data == null)
            {
                return View(MVC.Home.Logout());
            }

            BaseResponse response = new BaseResponse();

            BaseRequest Request = new BaseRequest();
            Request.UserLogin = userTokenSession;
            Request.userToken = userLoginSession;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/Users/" + id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";


            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                response = (BaseResponse)js.Deserialize<BaseResponse>(result);
            }
            ViewBag.StatusCode = response.statusCode.ToString();
            ViewBag.Message = response.Message;

            return RedirectToAction(MVC.Admin.Details().ToString(), response);
        }

        // GET: Admin/Create
        public virtual ActionResult CreateAdmin()
        {
            var session = HttpContext.Session.GetString("SessionTicket");
            ViewBag.data = session;
            string[] decryptSession = (Encryptor.Decrypt(session)).Split('|');

            string userTokenSession = decryptSession[0];
            string userLoginSession = decryptSession[1];
            ViewBag.UserToken = userTokenSession;
            ViewBag.UserLogin = userLoginSession;
            if (ViewBag.data == null)
            {
                return View(MVC.Home.Logout());
            }

            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult CreateAdmin(UsersRegister usersLogin)
        {
            
            try
            {
                var session = HttpContext.Session.GetString("SessionTicket");
                ViewBag.data = session;
                string[] decryptSession = (Encryptor.Decrypt(session)).Split('|');

                string userTokenSession = decryptSession[0];
                string userLoginSession = decryptSession[1];
                ViewBag.UserToken = userTokenSession;
                ViewBag.UserLogin = userLoginSession;
                if (ViewBag.data == null)
                {
                    return View(MVC.Home.Logout());
                }

                BaseResponse userToken = new BaseResponse();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/Users");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                usersLogin.isAdmin = 1;

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
            catch
            {
                return View();
            }
        }

    }
}