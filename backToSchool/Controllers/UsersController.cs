using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace backToSchool.Controllers
{
    [RoutePrefix("api/v1/")]
    public class UsersController : Controller
    {
        // GET: Users
        [HttpGet]
        [Route("view/login/user")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("validate")]
        public ActionResult login()
        {
            return View();
        }


        [HttpPost]
        [Route("save")]
        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        [Route("delete")]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [Route("update")]
        public ActionResult Update()
        {
            return View();
        }
    }
}