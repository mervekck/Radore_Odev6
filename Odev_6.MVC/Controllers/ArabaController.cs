using Microsoft.AspNetCore.Mvc;
using Odev_6.Models;
using Odev_6.MVC.Models;

namespace Odev_6.MVC.Controllers
{
    public class ArabaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Araba araba)
        {
            if (ModelState.IsValid)
            {
                TempData["Success"] = "Araba başarıyla kaydedildi!";
                return RedirectToAction("Success");
            }
            return View(araba);
        }
    }
}
