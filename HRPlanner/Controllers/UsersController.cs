using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPlanner.Business;
using Microsoft.AspNetCore.Mvc;

namespace HRPlanner.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGetUsers getUsers;
        public UsersController(IGetUsers getUsers)
        {
            this.getUsers = getUsers;
        }
        public IActionResult Index()
        {
            var users = getUsers.Get();
            return View(users);
        }

    }
}
