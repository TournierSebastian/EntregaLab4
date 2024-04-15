using Lab4Entrega.Data;
using Lab4Entrega.Data.Entities;
using Lab4Entrega.Servicie.Interfaces;

namespace Lab4Entrega.Servicie.Implement
{
    public class TodoItemService : ITodoItemService
    {
        private readonly Context _context;

        public TodoItemService(Context context)
        {
            _context = context;
        }

        public TodoItem CreateTodoItem(DtoTodoItem todoItem)
        {

            TodoItem newTodoitem = new TodoItem()
            {

                Tittle = todoItem.Tittle,
                Description = todoItem.Description,
                UserId = todoItem.UserId,
            };
            _context.TodoItems.Add(newTodoitem);
            _context.SaveChanges();
            return newTodoitem;
        }
    }
}
