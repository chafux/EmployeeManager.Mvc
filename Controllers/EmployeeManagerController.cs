using EmployeeManager.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Mvc.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private AppDbContext db = null;

        public EmployeeManagerController(AppDbContext db) 
        {
            this.db = db;
        }

        // private helper methode that supplies a list of countries 
        private void FillCountries() 
        {
            List<SelectListItem> countries = (from c in db.Countries
                                              orderby c.Name ascending
                                              select new SelectListItem() { Text = c.Name, Value = c.Name }).ToList();
            ViewBag.Countries = countries;
        }




    }
}
