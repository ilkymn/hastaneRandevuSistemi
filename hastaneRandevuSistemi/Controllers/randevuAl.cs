using hastaneRandevuSistemi.Migrations.city;
using hastaneRandevuSistemi.Models;
using hastaneRandevuSistemi.Models.doctors;
using hastaneRandevuSistemi.Models.hospital;
using hastaneRandevuSistemi.Models.policlinic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Controllers
{
    public class randevuAl : Controller
    {
        // clinicChangeController c = new clinicChangeController();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(randevuAl randevuAl)

        {
            return View(randevuAl);
        }
        public IActionResult Create(city city)

        {
            return View(city);

        }

        public IActionResult Create(Doctors doctors)

        {
            return View(doctors);
        }

        public IActionResult Create (Hospital hospital)
        {
            return View(hospital);  
        }
        public IActionResult Create(policlinic policlinic)
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
