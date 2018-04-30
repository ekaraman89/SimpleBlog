using SimpleBlog.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("Users")]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return View();
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