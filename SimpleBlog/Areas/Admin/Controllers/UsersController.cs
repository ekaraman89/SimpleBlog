using System.Web.Mvc;
using SimpleBlog.Areas.Admin.ViewModels;
using SimpleBlog.Infrastructure;
using SimpleBlog.Models;
using System.Linq;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("Users")]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return View(new UsersIndex
            {
                Users = Database.Session.Query<User>().ToList()
            });
        }

        public ActionResult New()
        {
            return View(new UsersNew());
        }

        [HttpPost]
        public ActionResult New(UsersNew form)
        {
            if (Database.Session.Query<User>().Any(u => u.Username.Equals(form.Username)))
                ModelState.AddModelError("username", "Username must be unique");
            if (!ModelState.IsValid)
                return View(form);

            var user = new User
            {
                Mail = form.Email,
                Username = form.Username
            };
            user.SetPassword(form.Password);

            Database.Session.Save(user);
            return RedirectToAction("index");
        }
       
    }
}