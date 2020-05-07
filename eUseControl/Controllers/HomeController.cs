using System.Web.Mvc;
using eUseControl.Web.Extension;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class HomeController : BaseController
    {
        [HandleError]
        public ActionResult Index()
        {
            SessionStatus();
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            if (user == null)
            {
                return View();
            }

            UserData u = new UserData
            {
                Username = user.Username
            };
            return View(u);
        }

        public ActionResult TermsConditions()
        {
            SessionStatus();
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            if (user == null)
            {
                return View();
            }

            UserData u = new UserData
            {
                Username = user.Username
            };
            return View(u);
        }

        public ActionResult Booking()
        {
            SessionStatus();
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            if (user == null)
            {
                return View();
            }

            UserData u = new UserData
            {
                Username = user.Username
            };
            return View(u);
        }

    }
}