﻿using SimpleBlog.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.Areas.Admin.ViewModels
{
    public class UsersIndex
    {
        public IEnumerable<User> Users { get; set; }
    }

    public class UsersNew
    {
        [Required, MaxLength(128)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.EmailAddress), MaxLength(255)]
        public string Email { get; set; }
    }
}