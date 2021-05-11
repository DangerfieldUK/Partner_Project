using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartnerProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartnerProject.Controllers
{
    public class UserHomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View("UserHome");
        }
    }
}
