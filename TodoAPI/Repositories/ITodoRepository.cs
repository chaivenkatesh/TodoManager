using TodoAPI.Models;


namespace TodoAPI.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAll();
        TodoItem Add(TodoItem item);
        void Delete(int id);
    }
}
