using Microsoft.AspNetCore.Mvc;

namespace hastaneRandevuSistemi.Controllers
{
    public class randevuAl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
