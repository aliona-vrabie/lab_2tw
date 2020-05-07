using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using eUseControl.BusinnessLogic;
using eUseControl.BusinnessLogic.Interfaces;
using eUseControl.Domain.Entities.User;
using eUseControl.Models;

namespace eUseControl.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegister _register;
        public RegisterController()
        {
            BussinesLogic bl = new BussinesLogic();
            _register = bl.GetRegisterBL();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserRegisterData userModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserRegisterData, UsersDbTable>());
            var mapper = new Mapper(config);
            var user = mapper.Map<UsersDbTable>(userModel);

            user.LastLogin = DateTime.Now;
            user.LastIp = Request.UserHostAddress;

            URegisterResp userStatus = _register.UserRegisterAction(user);

            if (userStatus.Status)
            {
                ModelState.AddModelError("", userStatus.StatusMsg);
                return RedirectToAction("Index", "Login");
            }

            ModelState.AddModelError("", userStatus.StatusMsg);
            return View("Index");
        }
    }
}