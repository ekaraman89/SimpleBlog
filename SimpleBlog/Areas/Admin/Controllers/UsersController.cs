using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return Content("Users Controller Index Action");
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