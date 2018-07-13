using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GetExercises.Web.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string sortBy { get; set; }
        public string Active
        {
            get
            {
                return IsActive ? "Yes" : "No";
            }
        }

        public static List<SelectListItem> sort { get; } = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "Active", Value = "active"},
            new SelectListItem() {Text = "Email", Value = "email"},
            new SelectListItem() {Text = "Name", Value = "last_name"},
        };
    }
}