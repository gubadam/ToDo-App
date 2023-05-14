using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo_App.Models;

namespace Todo_App.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase {
        private readonly MainDbContext _mainDbContext;

        public TaskController(MainDbContext mainDbContext) {
            _mainDbContext = mainDbContext;
        }

        [HttpGet]
        [Route("GetTasks")]
        public IActionResult GetTasks() {
            List<Todo_App.Models.Task> tasks = _mainDbContext.Tasks.ToList();
            return StatusCode(StatusCodes.Status200OK, tasks);
        }
    }
}
