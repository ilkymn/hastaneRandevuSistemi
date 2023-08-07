using hastaneRandevuSistemi.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private LanguageService _localization;
        public HomeController(ILogger<HomeController> logger, LanguageService localization)
        {
            _logger = logger;
            _localization = localization;
        }

        public HomeController()
        {
        }


        public IActionResult Index()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;

            return View();
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions()
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1)
                });
            return Redirect(Request.Headers["Referer"].ToString());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
