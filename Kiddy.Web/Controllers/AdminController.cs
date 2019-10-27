using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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