using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESHOPMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string name, string pass)
        {
            bool checkAcc = (name != null && pass != null && name.Equals("admin") && pass.Equals("123"));
            if (checkAcc)
                return View("~/Areas/admin/Views/DashBoard/Index.cshtml");
            else
                return View("Index");
        }
    }
}