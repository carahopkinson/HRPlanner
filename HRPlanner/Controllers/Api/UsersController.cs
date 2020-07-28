using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPlanner.Business;
using HRPlanner.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRPlanner.Controllers.Api
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService) 
        {
            this.userService = userService;
        }

        [HttpPost, Route("setactivestatus")]
        public bool SetActiveStatus([FromBody] EditUserViewModel model)
        {
            userService.SetActiveStatus(model.UserId, model.Active);
            return true;
        }
    }
}
