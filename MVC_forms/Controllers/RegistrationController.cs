using MVC_forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_forms.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register()
        {
            Registration reg = new Registration();
            reg.selectedListItems = new List<SelectListItem>();
            reg.selectedListItems.Add(new SelectListItem { Text = "vadodara", Value = "0" });
            reg.selectedListItems.Add(new SelectListItem { Text = "ahmedabad", Value = "1" });
            reg.selectedListItems.Add(new SelectListItem { Text = "pune", Value = "2" });
            return View(reg);
        }

        [HttpPost]
        public ActionResult Register(Registration reg)
        {
            return View();
        }
    }
}