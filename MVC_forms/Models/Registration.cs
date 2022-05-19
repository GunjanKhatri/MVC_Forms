using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_forms.Models
{
    public class Registration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public bool IsActive { get; set; }

        public List<SelectListItem> selectedListItems { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

    }
}