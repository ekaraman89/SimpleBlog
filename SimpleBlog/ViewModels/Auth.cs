using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        public string Test { get; set; }
        public string Username { get; set; }
        [DataType("Password")]
        public string Password { get; set; }
    }

    public class AuthListUser
    {
        public List<AuthLogin> Users { get; set; }
    }
}