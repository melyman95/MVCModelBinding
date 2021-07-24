using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCModelBinding.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(IFormCollection form)
        {
            Movie m = new Movie();
            m.Title = form["title"];
            m.ReleaseYear = form["release-year"];
            m.Genre = form["genre"];
            m.Rating = form["rating"];
            m.Length = form["length"];

            ViewData["Added"] = m.Title + " was added with an ID of 1";
            
            return View();
        }
    }
}
