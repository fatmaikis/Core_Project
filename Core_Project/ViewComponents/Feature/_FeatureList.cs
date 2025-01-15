using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Feature
{
    public class _FeatureList: ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal((new Context())));



        public IViewComponentResult Invoke()
        {
            var value = featureManager.TGetList();
            return View(value);
        }
    }
}
