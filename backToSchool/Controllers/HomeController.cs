using System.Web.Mvc;

namespace backToSchool.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult UserLogin()
        {
            return View();
        }


        public ActionResult UserRegisterForm()
        {
            return View();
        }


        public ActionResult UserGetData()
        {
            return View();
        }


        public ActionResult RoleRegisterForm()
        {
            return View();
        }


        public ActionResult RoleGetData()
        {
            return View();
        }

        public ActionResult StudentRegisterForm()
        {
            return View();
        }


        public ActionResult StudentGetData()
        {
            return View();
        }

        public ActionResult RelativeRegisterForm()
        {
            return View();
        }


        public ActionResult RelativeGetData()
        {
            return View();
        }
    }
}