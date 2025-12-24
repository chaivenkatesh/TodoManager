using TodoAPI.Models;

namespace TodoAPI.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private static readonly List<TodoItem> _todos = new();
        private static int _id = 1;

        public IEnumerable<TodoItem> GetAll() => _todos;

        public TodoItem Add(TodoItem item)
        {
            item.Id = _id++;
            _todos.Add(item);
            return item;
        }

        public void Delete(int id)
        {
            var todo = _todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
                _todos.Remove(todo);
        }
    }
}
