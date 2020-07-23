using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRPlanner.Business;
using HRPlanner.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HRPlanner.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            var users = userService.Get();
            return View(users);
        }

        public IActionResult Edit(int id)
        {
            var user = userService.GetById(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(UserViewModel model)
        {
            userService.Edit(model);
            return View(model);
        }

        public IActionResult Remove(int id)
        {
            var user = userService.GetById(id);
            return View(user);
        }

       
    }
}
