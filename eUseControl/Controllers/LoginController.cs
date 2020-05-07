using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinnessLogic;
using eUseControl.Domain.Entities.User;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;
        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLoginData login)
        {
            if (ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<UserLoginData, ULoginData>());
                var mapper = new Mapper(config);
                var data = mapper.Map<ULoginData>(login);

                data.LoginDateTime = DateTime.Now;
                data.LoginIp = Request.UserHostAddress;

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", userLogin.StatusMsg);
                return View();
            }
            return View(login);
        }

        public ActionResult Logout()
        {
            System.Web.HttpContext.Current.Session.Abandon();
            if (ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("X-KEY"))
            {
                var cookie = ControllerContext.HttpContext.Request.Cookies["X-KEY"];
                if (cookie != null)
                {
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}

