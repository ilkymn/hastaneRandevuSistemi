using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Controllers
{
    public class signUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(signUpController pat)
        {
            return View(pat);
        }
    }
}
