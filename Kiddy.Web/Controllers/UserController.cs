using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kiddy.Web.Controllers
{
    public partial class UserController : Controller
    {
        // GET: User
        public virtual ActionResult Index()
        {
            ViewBag.data = HttpContext.Session.GetString("SessionTicket");
            return View();
        }

        // GET: User/Details/5
        public virtual ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public virtual ActionResult submitShapes()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult submitShapes(IFormCollection collection)
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

        // GET: User/Edit/5
        public virtual ActionResult shapeSavedList(int id)
        {
            return View();
        }


    }
}