using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarupBack.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarupBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reviews.ToListAsync());
        }
    }
}
