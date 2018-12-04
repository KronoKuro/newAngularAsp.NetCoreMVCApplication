using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieReviewSpa.Data
{
    public class User : IdentityUser
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string FitstName { get; set; }

        public string LastName { get; set; }

        public string RoleId { get; set; }

        public virtual Role Role { get; set; }
    }
}
