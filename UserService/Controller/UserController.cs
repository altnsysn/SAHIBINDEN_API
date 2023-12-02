﻿using Microsoft.AspNetCore.Mvc;
using UserService.Dto;
using UserService.Service.Interface;

namespace UserService.Controller
{
    [ApiController]
    [Route("user/")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("")]
        public string Get() {
            return _userService.Test();
        }

        [HttpGet("getalluser/")]
        public IActionResult GetAllUser()
        {
            return Ok(_userService.GetUsers());
        }


        [HttpPost("singup")]
        public IActionResult SingUpUser([FromBody] UserSingUpDTO singUpDTO)
        {
            return Ok(_userService.SingUp(singUpDTO));
        }

    }
}
