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
                var signups = db.Insurees.Where(x => x.id == null).ToList();

                var signupVms = new List<Insuree>();
                foreach (var signup in signups)
                {
                    var signupVm = new Insuree();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVm.Total = Convert.ToInt32(signup.Total);

                    signupVms.Add(signupVm);
                }
            }
            return View();
        }
    }
}