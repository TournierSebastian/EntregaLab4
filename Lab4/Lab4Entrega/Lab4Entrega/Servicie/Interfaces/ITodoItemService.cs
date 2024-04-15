using Lab4Entrega.Data.Entities;

namespace Lab4Entrega.Servicie.Interfaces
{
    public interface ITodoItemService
    {
        TodoItem CreateTodoItem(DtoTodoItem todoItem);
    }


}
