using CroperJsExampleGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CroperJsExampleGood.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ChangeImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangeImage(UserChangeImageViewModel model)
        {
            var image = model.Image;
            return View();
        }
    }
}