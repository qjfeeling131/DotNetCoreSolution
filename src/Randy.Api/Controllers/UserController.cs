﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Randy.DomainCore;
using Randy.DomainCore.DTO;
using Randy.Infrastructure;
using Randy.Api.Models;

namespace Randy.Api.Controllers
{
    /// <summary>
    /// User application service
    /// </summary>
    //[Route("api/[controller]/[action]")]
    public class UserController : ApiBaseController
    {

        public IUserService UserService { get; set; }

        public UserController(IUserService userService)
        {
            UserService = userService;
        }

        /// <summary>
        /// Login for user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ReturnModel<User> Login([FromBody]LoginRequest request)
        {
            return UserService.Login(request.UserName, request.Password,HttpContext.Connection.RemoteIpAddress.ToString());
   
        }


        /// <summary>
        /// SignUp User
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public ReturnModel SignUp([FromBody]SignUpInput request)
        {
            return UserService.SignUp(request);
        }

        /// <summary>
        /// get GetTwoParam
        /// </summary>
        /// <returns>empty</returns>
        //[HttpGet("{id}/{code}")]
        //public string GetTwoParam(int id, int code)
        //{
        //    return id + "one" + code;
        //}

        /// <summary>
        /// del user
        /// </summary>
        /// <param name="user">delete the user</param>
        /// <returns></returns>
        //[HttpPost]
        //public bool Delete([FromBody]User user)
        //{
        //    return true;
        //}

    }

   
}
