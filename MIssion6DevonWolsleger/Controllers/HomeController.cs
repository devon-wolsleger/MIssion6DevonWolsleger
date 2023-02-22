using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private MovieInfoContext maContext { get; set; }

        public HomeController(MovieInfoContext x)
        {

            maContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillOutForum()
        {
            ViewBag.Catagories = maContext.Catagories.ToList();

            return View("MovieForum");
        }

        [HttpPost]
        public IActionResult FillOutForum(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                maContext.Add(ar);
                maContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Catagories = maContext.Catagories.ToList();

                return View("MovieForum");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult WaitList()
        {
            var movieList = maContext.Responses
                .Include(x => x.Catagory)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movieList);
        }
        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Catagories = maContext.Catagories.ToList();

            var forum = maContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View("MovieForum", forum);
        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse blah)
        {
            maContext.Update(blah);
            maContext.SaveChanges();

            return RedirectToAction("Waitlist");
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var forum = maContext.Responses.Single(x => x.ApplicationId == applicationid);
            return View(forum);
        }

        [HttpPost]
        public IActionResult Delete (ApplicationResponse ar)
        {
            maContext.Responses.Remove(ar);
            maContext.SaveChanges();

            return RedirectToAction("Waitlist");
        }
    }
}
