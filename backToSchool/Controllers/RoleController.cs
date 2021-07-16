using backToSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace backToSchool.Controllers
{
    [RouteArea("api")]
    [RoutePrefix("role")]
    public class RoleController : Controller
    {
        // GET: Users
        [HttpGet]
        [Route("view")]
        public ActionResult Role()
        {
            return View();
        }

        [HttpGet]
        [Route("getById")]
        public ActionResult GetById()
        {
            return View();
        }

        [HttpGet]
        [Route("getAll")]
        public ActionResult GetAll()
        {
            return View();
        }


        [HttpPost]
        [Route("save")]
        public ActionResult Save(Role role)
        {
            using (DBschool db = new DBschool())
            {
                /* Valores de la tabla Role se pueden eliminar despues de validar que funciona correctamente
       
                 */

                Role save = db.Roles.Add(role);
                db.SaveChanges();
                return Json(save, JsonRequestBehavior.AllowGet);
            }
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