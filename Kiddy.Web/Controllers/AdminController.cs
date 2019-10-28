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
            

            //list all shapes
            return View();
        }

        // GET: Admin/Details/5
        public virtual ActionResult Details(int id)
        {
            //shapes detail (edit?)
            return View();
        }

        // GET: Admin/Create
        public virtual ActionResult CreateAdmin()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult CreateAdmin(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}