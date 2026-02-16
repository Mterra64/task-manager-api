using Microsoft.AspNetCore.Mvc;

namespace TaskManagerApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private static readonly List<string> Tasks = new();

    [HttpGet]
    public IActionResult GetTasks()
    {
        return Ok(Tasks);
    }

    [HttpPost]
    public IActionResult AddTask([FromBody] string task)
    {
        if (string.IsNullOrWhiteSpace(task))
            return BadRequest("Task cannot be empty.");

        Tasks.Add(task);
        return Ok(Tasks);
    }
}
