using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebABC.Web.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
