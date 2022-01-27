﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movie.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDataContext _blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieDataContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult Podcast()
        {
            return View();
        }
        
        [HttpGet]

        public IActionResult EnterMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovies(ApplicationResponse ar)
        {
            _blahContext.Add(ar);
            _blahContext.SaveChanges();

            return View("EnterMovies", ar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
