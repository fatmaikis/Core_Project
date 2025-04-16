using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Portfolio
{
    public class SlideList:ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public SlideList(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _portfolioService.TGetList();
            return View(value);
        }
    }
}
