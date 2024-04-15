using Lab4Entrega.Data.Dto;
using Lab4Entrega.Data.Entities;
using Lab4Entrega.Servicie.Implement;
using Lab4Entrega.Servicie.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab4Entrega.Controllers
{
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
  

        public UserController(IUserService userService)
        {
            _userService = userService;

        }


        [HttpPost("CreateUser")]

        public ActionResult<User> CreateUser(DtoUser user)
        {
            var response = _userService.CreateUser(user);

            if (response == null)
            {
                return BadRequest("Incomplete Data or existing user ");
            }
  

            return Ok("Added Todoitem");

        }



    }
}