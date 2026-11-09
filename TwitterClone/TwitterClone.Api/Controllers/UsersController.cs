using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UsersController : ControllerBase
    {


        private readonly IUserService _userService;


        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser([FromBody] CreateUserDto createUserDto)
        {
            var createdUser = _userService.CreateUser(createUserDto);

            if(createdUser == null)
            {
                return BadRequest("Invalid user data or user with the same email already exists.");
            }   

            return Ok(createdUser);
        }



        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute]Guid id)
        {

            var user = _userService.GetUserById(id);

            if(user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }

            return Ok(user);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute]Guid id, [FromBody] UpdateUserDto updateUserDto)
        {
            var user = _userService.UpdateUser(id, updateUserDto);

            if (user == null)
            {
                return NotFound();
            }



            return Ok(user);
        }


        [HttpPatch("{id}/phoneNumber")]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok("hello");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            var isDeleted = _userService.DeleteUser(id);

            if (isDeleted == false)
            {
                return NotFound();
            }

            return Ok(isDeleted);
        }

    }
}
