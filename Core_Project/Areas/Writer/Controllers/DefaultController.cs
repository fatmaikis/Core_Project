using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{

    [Area("Writer")]
    //[Authorize]
    public class DefaultController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public DefaultController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var value =_announcementService.TGetList();
            return View(value);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var values = _announcementService.TGetByID(id);
            return View(values);
        }
    }
}
