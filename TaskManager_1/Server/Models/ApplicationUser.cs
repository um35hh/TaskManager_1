using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager_1.Server.Models
{
    public class ApplicationUser : IdentityUser
    {

        //public string FirstNmae { get; set; }

        public string FirstName { get; set; }

        public string LastName  { get; set; }

    }
}
