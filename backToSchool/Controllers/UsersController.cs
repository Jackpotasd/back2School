using backToSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace backToSchool.Controllers
{
    [RouteArea("api")]
    [RoutePrefix("user")]
    public class UsersController : Controller
    {
        // GET: Users
        [HttpGet]
        [Route("view")]
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
        public ActionResult Save(User user)
        {
            using (DBschool db = new DBschool()) {
                /* Valores de la tabla user se pueden eliminar despues de validar que funciona correctamente
        public string User_Id { get; set; }
        public string User_Password { get; set; }
        public System.DateTime User_Last_Login { get; set; }
        public System.DateTime User_Created { get; set; }
        public int Role_Id { get; set; }
        public virtual Role Role { get; set; }
                 */

                User save =db.Users.Add(user);
                db.SaveChanges();
                return Json(save,JsonRequestBehavior.AllowGet);
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