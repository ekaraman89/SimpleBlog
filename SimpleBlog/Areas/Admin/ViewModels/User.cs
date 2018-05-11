using SimpleBlog.Models;
using System.Collections.Generic;

namespace SimpleBlog.Areas.Admin.ViewModels
{
    public class UserIndex
    {
        public IEnumerable<User> Users { get; set; }
    }
}