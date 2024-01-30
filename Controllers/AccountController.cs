using CoreForms_And_Validation_DotNetWebFormsMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreForms_And_Validation_DotNetWebFormsMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }  
        [HttpPost]
        public IActionResult LoginPost(string username,string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }
        public IActionResult StronglyTypedLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            if(login.Username!= null && login.Password!=null)
            {
                if(login.Username.Equals("admin") && login.Password.Equals("admin"))
                {
                    ViewBag.Message = "You are successfully logged in";
                    return View();
                }
            }
            ViewBag.Message = "Invalid Credentials";
            return View();
        }
        public IActionResult UserDetail()
        {
            var user = new LoginViewModel() { Username = "SRRifat", Password = "123456" };
            return View(user);
        }
        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel() { Username = "SRRifat",Password = "123456" },
                new LoginViewModel() { Username = "Sakib",Password = "123456" },
                new LoginViewModel() { Username = "Masrafi",Password = "123456" }
        };
            return View(users);
        }

        public IActionResult GetAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostAccount(Account account)
        {
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            return RedirectToAction("GetAccount");
        }


    }
}
