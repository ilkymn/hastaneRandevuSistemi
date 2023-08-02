using hastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Controllers
{
    public class clinicChangeController : Controller
    {
       // clinicChangeController c = new clinicChangeController();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(clinicChangeController policlinic)

        {
            return View(policlinic);
        }

        /* [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
         public IActionResult Error()
         {
             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         }*/
    }
}
