using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Sayfası";
            var values = _aboutService.TGetByID(3);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
