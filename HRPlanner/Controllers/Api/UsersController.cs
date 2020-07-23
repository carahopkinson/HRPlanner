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

        [HttpPost, Route("setactivestatus")]
        public bool SetActiveStatus([FromBody]int userId, bool active)
        {
            userService.SetActiveStatus(userId, active);
            return true;
        }
    }
}
