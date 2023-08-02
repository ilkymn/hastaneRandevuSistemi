using hastaneRandevuSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Controllers
{
    public class signUpController : Controller
    {
        //signUpController s = new signUpController();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(signUpController patient)
        {
            return View(patient);
        }
       /* [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
