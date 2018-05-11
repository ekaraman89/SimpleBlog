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
            return View(new UserIndex
            {
                Users = Database.Session.Query<User>().ToList()
            });
        }

        public ActionResult New()
        {
            return Content("Users Controller New Action");
        }

        public ActionResult Update()
        {
            return Content("Users Controller Update Action");
        }

        public ActionResult Delete()
        {
            return Content("Users Controller Delete Action");
        }
    }
}