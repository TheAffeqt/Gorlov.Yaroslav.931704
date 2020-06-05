using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FourthLab.Models;

namespace FourthLab.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetModel model, string action)
        {
            if (model.Code == null)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (action == "Send")
                {
                    model.Message = "We have sent you a code!";
                    return View("ResetContinue", model);
                }
                else
                {
                    model.Message = "";
                    return View("ResetContinue", model);
                }
            }
            else { return View("ResetEnd"); }
        }

        [HttpGet]
        public IActionResult SignUpFirst()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpFirst(SignUpModel model)
        {
            if (model.Email == null)
            {
                return View("SignUpSecond");
            }

            else
            {
                if (!ModelState.IsValid)
                {
                    return View("SignUpSecond");
                }
                else { return View("SignUpResult", model); }
            }
        }

    }
}