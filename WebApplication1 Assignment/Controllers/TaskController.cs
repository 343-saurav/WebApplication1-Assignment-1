using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1_Assignment.IRepo;
using WebApplication1_Assignment.Model;

namespace WebApplication1_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        ITaskListRepo _repo;
        public TaskController (ITaskListRepo repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data=_repo.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Add(TaskList tl)
        {
            _repo.Add(tl);
            return Ok("Added ");
        }
        [HttpPut]
        [Route("update/{id}")]
        public IActionResult update(TaskList tl,int id)
        {
            _repo.Update(tl,id);
            return Ok("Updated ");
        }
        [HttpDelete]
        public IActionResult delete(int id)
        {
            _repo.Delete(id);
            return Ok("Deleted");
        }
    }
}
