using Application.Interfaces;
using Application.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll() 
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetById(int id) 
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPost("[action]")]
        public IActionResult Add([FromBody] UserCreateRequest request)
        {
            _userService.Add(request);
            return Ok();
        }

        [HttpPut("[action]/{id}")]
        public IActionResult Update(int id, [FromBody] UserUpdateRequest request) 
        {
            _userService.Update(id, request);
            return Ok();
        }

        [HttpDelete("[action]")]
        public IActionResult Delete(int id) 
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}
