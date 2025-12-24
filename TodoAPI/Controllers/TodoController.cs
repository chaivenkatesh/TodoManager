using Microsoft.AspNetCore.Mvc;
using TodoAPI.Models;
using TodoAPI.Repositories;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _repo;
        public TodoController(ITodoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok(_repo.GetAll());
        }

        [HttpPost]
        public IActionResult AddTodo([FromBody] TodoItem item)
        {
            return Ok(_repo.Add(item));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTodo(int id)
        {
            _repo.Delete(id);
            return NoContent();
        }
    }
}
