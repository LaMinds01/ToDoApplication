using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToDoApplication.Data.IServices;

namespace ToDoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        IToDoRepository _toDoRespository;
        public ToDoController(IToDoRepository toDoRepository)
        {
            _toDoRespository = toDoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _toDoRespository.GetToDoList());
        }
    }
}
