using Core_Project.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegisterView)
        {
            if (ModelState.IsValid)
            {
                WriterUser w = new WriterUser
                {
                    Name = userRegisterView.Name,
                    Surname = userRegisterView.Surname,
                    Email = userRegisterView.Mail,
                    UserName = userRegisterView.UserName,
                    ImageUrl = userRegisterView.ImageUrl

                };
                var result = await _userManager.CreateAsync(w,userRegisterView.Password);

                if (result.Succeeded && userRegisterView.ConfirmPassword==userRegisterView.Password )
                {
                    return RedirectToAction("Index","Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
               
            }
            
            return View();
        }
    }
}

//123456aA* ŞİFRE
