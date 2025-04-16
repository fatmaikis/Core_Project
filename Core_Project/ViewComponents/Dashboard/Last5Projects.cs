using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public Last5Projects(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _portfolioService.TGetList().Take(5);
            return View(value);
        }
    }
}
