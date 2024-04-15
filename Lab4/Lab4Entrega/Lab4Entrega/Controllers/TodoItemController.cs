using Lab4Entrega.Data.Entities;
using Lab4Entrega.Servicie.Implement;
using Lab4Entrega.Servicie.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Entrega.Controllers
{
    public class TodoItemController: ControllerBase
    {

        private readonly ITodoItemService _todoItemService;


        public TodoItemController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;

        }


        [HttpPost("CreateTodoitem")]

        public ActionResult<TodoItem> CreateTodoItem(DtoTodoItem todoItem)
        {
            var response = _todoItemService.CreateTodoItem(todoItem);

            if (response == null)
            {
                return BadRequest("Incomplete Data ");
            }


            return Ok("Added todoItem");

        }



    }
}
