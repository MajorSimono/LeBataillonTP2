using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LeBataillon.Web.Models;
using LeBataillon.Database.Context;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace LeBataillon.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LeBataillonDbContext _dbcontext;

        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ILogger<HomeController> logger, LeBataillon.Database.Context.LeBataillonDbContext dbContext, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _dbcontext = dbContext;
            _localizer = localizer;
        }
        public IActionResult Index()
        {

            ViewData["Title"] = this._localizer["HomeIndexTitle"];
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




        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            var cookie = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture));
            var name = CookieRequestCultureProvider.DefaultCookieName;
            Response.Cookies.Append(name,cookie, new CookieOptions {
                                                                    Path = "/",
                                                                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                                                                    } );
            return LocalRedirect(returnUrl);
        }
    }
}
