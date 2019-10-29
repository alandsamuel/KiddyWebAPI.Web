using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kiddy.Common;
using Kiddy.Models;
using Kiddy.Models.Base;
using Nancy.Json;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Kiddy.Web.Controllers
{
    public partial class UserController : Controller
    {
        
        // GET: User
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

            List<ShapesForDisplay> saveShape = new List<ShapesForDisplay>();

            BaseRequest Request = new BaseRequest();
            Request.UserLogin = userLogin;
            Request.userToken = userToken;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/GetShapes?AccessToken=" + userToken + "&UserID=" + userLogin);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            var content = JsonConvert.SerializeObject(Request);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                var result = streamReader.ReadToEnd();
                saveShape = (List<ShapesForDisplay>)js.Deserialize<List<ShapesForDisplay>>(result);
            }
            //ViewBag.StatusCode = saveShape.statusCode.ToString();
            //ViewBag.Message = saveShape.Message;

            return View(saveShape);
        }

        // GET: User/Create
        public virtual ActionResult submitShapes()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult submitShapes(shapeSubmitResponse collection)
        {
            try
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

                shapesSubmitRequest submitRequest = new shapesSubmitRequest();
                submitRequest.UserInput = collection.userInput;
                submitRequest.UserLogin = userLogin;
                submitRequest.userToken = userToken;

                shapeSubmitResponse shapeSubmit = new shapeSubmitResponse();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/ShapeSubmit");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                var content = JsonConvert.SerializeObject(decryptSession);

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
                    shapeSubmit = (shapeSubmitResponse)js.Deserialize<shapeSubmitResponse>(result);
                }
                ViewBag.StatusCode = shapeSubmit.statusCode.ToString();
                ViewBag.Message = shapeSubmit.Message;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      

                return View(shapeSubmit);
            }
            catch (Exception ex)
            {
                return View(new shapeSubmitResponse (){Message = "error processing requesterror processing request, error : " +ex});
                }
        }

        
        public virtual ActionResult shapeSavedList()
        {

            try
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

                BaseRequest Request = new BaseRequest();
                Request.UserLogin = userLogin;
                Request.userToken = userToken;

                shapeSubmitResponse shapeSubmit = new shapeSubmitResponse();

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51150/api/ShapeSubmit");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var content = JsonConvert.SerializeObject(decryptSession);

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
                    shapeSubmit = (shapeSubmitResponse)js.Deserialize<shapeSubmitResponse>(result);
                }
                ViewBag.StatusCode = shapeSubmit.statusCode.ToString();
                ViewBag.Message = shapeSubmit.Message;

                return View(shapeSubmit);
            }
            catch (Exception ex)
            {
                return View(new shapeSubmitResponse() { Message = "error processing request, error : " +ex});
            }
        }


    }
}