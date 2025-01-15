using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult Index()
        {
            var value = _portfolioService.TGetList();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            _portfolioService.TAdd(portfolio);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value =_portfolioService.TGetByID(id);
            _portfolioService.TDelete(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = _portfolioService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _portfolioService.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
    }
}
