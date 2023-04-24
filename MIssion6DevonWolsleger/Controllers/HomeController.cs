using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Final.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {

        private EntertainmentInfoContext maContext { get; set; }

        public HomeController(EntertainmentInfoContext x)
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
            return View("MovieForum");
        }

        [HttpPost]
        public IActionResult FillOutForum(Entertainers ar)
        {
            if (ModelState.IsValid)
            {
                maContext.Add(ar);
                maContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                return View("MovieForum");
            }
        }


        [HttpGet]
        public IActionResult WaitList()
        {
            var movieList = maContext.Entertainers.ToList();

            return View(movieList);
        }
        [HttpGet]
        public IActionResult Edit (int entertainerid)
        {
            var forum = maContext.Entertainers.Single(x => x.EntertainerID == entertainerid);

            return View("MovieForum", forum);
        }

        [HttpPost]
        public IActionResult Edit (Entertainers blah)
        {
            maContext.Update(blah);
            maContext.SaveChanges();

            return RedirectToAction("Waitlist");
        }

        [HttpGet]
        public IActionResult Delete(int entertainerid)
        {
            var forum = maContext.Entertainers.Single(x => x.EntertainerID == entertainerid);
            return View(forum);
        }

        [HttpPost]
        public IActionResult Delete (Entertainers ar)
        {
            maContext.Entertainers.Remove(ar);
            maContext.SaveChanges();

            return RedirectToAction("Waitlist");
        }
    }
}
