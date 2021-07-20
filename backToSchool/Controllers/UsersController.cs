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
       
        //-----------------------------------------------------------------
        //                     ACTIVE USER VALIDATION
        //-----------------------------------------------------------------
        [HttpPost, Route("validate")]
        public JsonResult Validate(string id, string password)
        {
            using (DBschool db = new DBschool())
            {
                var user = db.Users.FirstOrDefault(x => x.User_Id == id && x.User_Password == password);
                //var user2 = db.Users.Where(x => x.User_Id == id);
                
                Response.StatusCode = 400;
                return (user != null ? Json("1") : Json("0"));
            }
        }

        //-----------------------------------------------------------------
        //                             SAVE USER
        //-----------------------------------------------------------------
        [HttpPost, Route("save")]
        public ActionResult Save(User user)
        {
            using (DBschool db = new DBschool())
            {
                /* Valores de la tabla user se pueden eliminar despues de validar que funciona correctamente
            public string User_Id { get; set; }
            public string User_Password { get; set; }
            public System.DateTime User_Last_Login { get; set; }
            public System.DateTime User_Created { get; set; }
            public int Role_Id { get; set; }
            public virtual Role Role { get; set; }
                 */
                user.User_Last_Login = DateTime.Now;
                user.User_Created = DateTime.Now;
                User save = db.Users.Add(user);
                db.SaveChanges();
                return Json(save, JsonRequestBehavior.AllowGet);
            }
        }

        //-----------------------------------------------------------------
        //                         DELETE USER
        //-----------------------------------------------------------------
        [HttpPost]
        [Route("delete")]
        public ActionResult Delete()
        {
            return View();
        }

        //-----------------------------------------------------------------
        //                         UPDATE USER
        //-----------------------------------------------------------------
        [HttpPost]
        [Route("update")]
        public ActionResult Update(User user)
        {
            using (DBschool db = new DBschool())
            {
                var oUser = db.Users.FirstOrDefault(x => x.User_Id == user.User_Id);
                if (oUser != null)
                {
                    oUser.Role_Id = user.Role_Id;
                    oUser.User_Password = user.User_Password;
                    db.SaveChanges();
                    return Json("1");
                }
                else
                    return Json("0");
            }
        }
    }
}