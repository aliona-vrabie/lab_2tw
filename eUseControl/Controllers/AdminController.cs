using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Controllers.Attributes;
using eUseControl.Web.Controllers;
using eUseControl.Web.Extension;
using eUseControl.Web.Models;

namespace eUseControl.Controllers
{
    public class AdminController : BaseController
    {
        [AdminMod]
        public ActionResult Index()
        {
            SessionStatus();

            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] == "login")
            {
                var user = System.Web.HttpContext.Current.GetMySessionObject();
                UserData u = new UserData
                {
                    Username = user.Username,
                    Level = user.Level
                };

                return View(u);
            }
            return View();
        }

    }
}