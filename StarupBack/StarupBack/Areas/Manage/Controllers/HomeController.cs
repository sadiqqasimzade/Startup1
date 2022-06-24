using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarupBack.Areas.Manage.Controllers
{
    public class HomeController : Controller
    {
        [Area("Manage")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
