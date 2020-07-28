using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        public bool Active { get; set; }
        public bool Admin { get; set; }
        public int Holidays { get; set; }
        public string Password { get; set; }
    }
}
