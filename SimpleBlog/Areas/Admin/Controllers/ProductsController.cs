using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Admin/Products
        public ActionResult Index()
        {
            return Content("Products Controller Index Action");
        }

        public ActionResult Edit(int id = 0)
        {
            return Content("Products Controller Edit Action with parameter : " + id.ToString());
        }
    }
}