﻿using Microsoft.AspNetCore.Mvc;

namespace Randy.Api.Controllers
{
    /// <summary>
    /// Menu Controller
    /// </summary>
    public class MenuController : ApiController
    {
        /// <summary>
        /// get one Menu
        /// </summary>
        /// <returns>empty</returns>
        [HttpGet]
        public string GetOne()
        {
            return "Menu";
        }

    }


}