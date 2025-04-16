using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        private readonly IToDoListService _toDoListService;

        public ToDoListManager(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        public void TAdd(ToDoList t)
        {
            _toDoListService.TAdd(t);
        }

        public void TDelete(ToDoList t)
        {
            _toDoListService.TDelete(t);
        }

        public ToDoList TGetByID(int id)
        {
            return _toDoListService.TGetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListService.TGetList();
        }

        public void TUpdate(ToDoList t)
        {
            _toDoListService.TUpdate(t);    
        }
    }
}
