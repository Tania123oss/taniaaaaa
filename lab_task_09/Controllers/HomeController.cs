using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_task_09.Models;

namespace lab_task_09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Register rgt)
        {
            if (!ModelState.IsValid)
            {
                return View(rgt);
            }
            return Content("success");
        }
    }

    
}