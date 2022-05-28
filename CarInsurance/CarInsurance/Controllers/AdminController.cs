using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin View
        public ActionResult Index()
        {
            using(InsuranceEntities db = new InsuranceEntities())
            {
                return View(db.Insurees.ToList());
            }
        }
    }
}