using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MIssion6DevonWolsleger.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MIssion6DevonWolsleger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieInfoContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext x)
        {
            _logger = logger;
            blahContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillOutForum()
        {
            return View("MovieForum");
        }

        [HttpPost]
        public IActionResult FillOutForum(ApplicationResponse ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();

            return View("Confirmation");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
