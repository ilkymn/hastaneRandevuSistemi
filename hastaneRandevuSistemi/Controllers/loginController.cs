using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index()
        {

            
            return View();
        }

        public IActionResult Create(loginController patient)

        {
            return View(patient);
        }
    }
}
