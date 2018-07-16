﻿using System;
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
        public ActionResult RegistrationConfirmation()
        {
            
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

        }
        // GET: User/Confirmation
        // Return the confirmation view
        public RegistrationViewModel NewUser()
        {

        }
    }
}