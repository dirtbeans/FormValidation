using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Web.Models;

namespace Validation.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: User

        // Add the following Controller Actions

        // GET: User/Register
        // Return the empty registration view
        public ActionResult NewUser()
        {
            return View("NewUser");
        }
        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails) 
        [HttpPost]
        public ActionResult RegistrationConfirmation(RegistrationViewModel newUser)
        {
            // Let's validate the model before proceeding
            if (!ModelState.IsValid)
            {
                return View("NewUser", newUser);
            }

            return RedirectToAction("RegistrationConfirmation");
        }
        public ActionResult RegistrationConfirmation()
        {
            return View();
        }
        
        // GET: User/Login
        // Return the empty login view
        public ActionResult Index()
        {
            return View("Index");
        }
        // POST: User/Login  
        // Validate the model and redirect to confirmation (if successful) or return the 
        // login view (if validation fails)
        [HttpPost]
        public ActionResult LoginConfirmation(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            return RedirectToAction("LoginConfirmation");
        }

        public ActionResult LoginConfirmation()
        {
            return View();
        }
        //// GET: User/Confirmation
        //// Return the confirmation view
        
    }
}