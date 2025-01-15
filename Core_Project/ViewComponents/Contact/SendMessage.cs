using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        private readonly IMessageService _messageService;

        public SendMessage(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            
            return View();  
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    _messageService.TAdd(p);
        //    return View();  
        //}
    }
}
