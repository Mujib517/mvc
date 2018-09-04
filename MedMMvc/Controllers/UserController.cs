using MedMvc.Core.Entities;
using MedMvc.Core.Exceptions;
using MedMvc.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedMMvc.Controllers
{
    public class UserController : Controller
    {
        private UserService _userSvc = null;
        public UserController()
        {
            userSvc = new UserService();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            try
            {
                _userSvc.ValidateUser(user);
                return RedirectToAction("index", "home");
            }
            catch (AccountLockedException ex)
            {
                return RedirectToAction("Login");

            }
            catch (AccountInActiveException ex)
            {
                return RedirectToAction("Login");

            }
            catch (InvalidCredentialsException ex)
            {
                return RedirectToAction("Login");

            }
            catch (Exception ex)
            {
                return RedirectToAction("Login");

            }
        }
    }
}