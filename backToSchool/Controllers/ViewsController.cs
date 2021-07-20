using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace backToSchool.Controllers
{
    [RoutePrefix("views")]
    public class ViewsController : Controller
    {
        // GET: Views
        [HttpGet, Route("{module}")]
        public ActionResult Index(string module)
        {
           return View( Routing(module));
        }

        private string Routing(string module) {
            switch (module)
            {
                case "Index":

                    return "~/Views/Home/Index.cshtml";
                case "Login":
                    return "~/Views/Users/Login.cshtml";
                default:
                    return "~/Views/Users/Login.cshtml";
            }

        }
    }
}