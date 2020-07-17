using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRPlanner.Data.Entities
{
    public class Users
    {
        [Key, Column("User_PK")]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public bool Active { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public int Holidays { get; set; }
    }
}
