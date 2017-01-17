﻿using OnlineTraining.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineTrainingWebUI.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Customers customerToLogin)
        {

            if (Request.IsAjaxRequest())
            {
                return PartialView("_SuccessLogin");
            }

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Register(Customers customerToRegister)
        {

            if (Request.IsAjaxRequest())
            {
                return PartialView("_SuccessRegister");
            }

            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        
    }  
}