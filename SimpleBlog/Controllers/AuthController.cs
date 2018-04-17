using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin() { Test = "DENEME" + DateTime.Now.ToString() });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string ReturnUrl)
        {
            FormsAuthentication.SetAuthCookie(form.Username, true);
            if (!string.IsNullOrWhiteSpace(ReturnUrl))
                return Redirect(ReturnUrl);
            return RedirectToRoute("Home");
        }

        public ActionResult List()
        {
            return Content("List");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Home");
        }
    }
}