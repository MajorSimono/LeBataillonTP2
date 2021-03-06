﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LeBataillon.Web.Models;
using LeBataillon.Database.Context;
namespace LeBataillon.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LeBataillonDbContext _dbcontext;

        public HomeController(ILogger<HomeController> logger, LeBataillon.Database.Context.LeBataillonDbContext dbContext)
        {
            _logger = logger;
            _dbcontext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbcontext.Players.OrderByDescending(p => p.Level).Take(3));

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
