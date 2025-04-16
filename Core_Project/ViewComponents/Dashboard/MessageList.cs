using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        //private readonly IMessageService _messageService;
        private readonly IUserMessageService _userMessageService;

        public MessageList(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;
        }

        //public MessageList(IMessageService messageService)
        //{
        //    _messageService = messageService;
        //}

        public IViewComponentResult Invoke()
        {
            var value = _userMessageService.GetUserMessageWithUserService();
            return View(value);
        }
    }
}
