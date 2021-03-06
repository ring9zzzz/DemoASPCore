﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BestApplication.Common.Const;
using System.Security.Claims;

namespace BestApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {          
            return View();
        }
        [Route("lien-he")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";    
            ViewData["Role"] = GetUserRole(this.User);
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            ViewData["Role"] = GetUserRole(this.User);
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


        #region helper
        public static string GetUserRole(ClaimsPrincipal User)
        {        
            return User.IsInRole(UserRoleCst.Admin) == true ? UserRoleCst.AdminName :
                 User.IsInRole(UserRoleCst.PreUser) == true ? UserRoleCst.PreUserName :
                 UserRoleCst.FreeUserName;
        }
        #endregion
    }
}
