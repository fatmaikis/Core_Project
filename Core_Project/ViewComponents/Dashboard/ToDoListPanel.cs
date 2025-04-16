using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class ToDoListPanel:ViewComponent
    {
        private readonly IToDoListService _toDoListService;

        public ToDoListPanel(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _toDoListService.TGetList();
            return View(value);
        }

    }
}
