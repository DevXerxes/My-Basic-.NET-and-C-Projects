using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree one
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        //GET: Insuree/Calculate/5
        [HttpPost]
        public ActionResult Car_Info(string firstName, string lastName, string emailAddress, DateTime dateofbirth, int caryear, string carmake, string carmodel, int speedingtickets, string dui, string coverage, int? total)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carmake) || string.IsNullOrEmpty(carmodel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var signup = new Insuree();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    signup.DateOfBirth = dateofbirth;
                    signup.CarYear = caryear;
                    signup.SpeedingTickets = speedingtickets;
                    signup.Dui = dui;
                    signup.Coverage = coverage;
                    signup.Total = total;

                    //making total base num 50
                    total = 50;
                    //If the user is 18 and under, add $100 to the monthly total.
                    var today = DateTime.Today;
                    var age = today.Year - dateofbirth.Year;
                    //If the user is between 19 and 25, add $50 to the monthly total
                    if (dateofbirth > today.AddYears(-25) && dateofbirth > today.AddYears(+19))
                    {
                        total = total + 50;
                    }
                    else if (dateofbirth > today.AddYears(-18))
                    {
                        total = total + 100;
                    }
                    //If the user is over 25, add $25 to the monthly total.
                    else if (dateofbirth > today.AddYears(-100))
                    {
                        total = total + 25;
                    }

                    //If the car's year is before 2000, add $25 to the monthly total.
                    if (caryear < 2000)
                    {
                        total = total + 25;
                    }
                    //If the car's year is after 2015, add $25 to the monthly total.
                    else if (caryear > 2015)
                    {
                        total = total + 25;
                    }

                    //If the car's Make is a Porsche, add $25 to the price.
                    if (carmake == "Porsche" && carmodel == "911 Carrera")
                    {
                        total = total + 25;
                    }
                    //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                    else if (carmake == "Porsche" && carmodel == "911 Carrera")
                    {
                        total = total + 25;
                    }

                    //Add $10 to the monthly total for every speeding ticket the user has
                    if (speedingtickets > 0)
                    {
                        total = total + (speedingtickets * 10);
                    }
                    else
                    {
                        total = total + 0;
                    }

                    //If the user has ever had a DUI, add 25% to the total.
                    if (dui == "Yes" || dui == "yes" || dui == "yeah")
                    {
                        total = total + (total * 25 / 100);
                    }
                    else
                    {
                        total = total + 0;
                    }

                    //If it's full coverage, add 50% to the total.
                    if (coverage == "Full" || coverage == "full coverage" || coverage == "yes")
                    {
                        total = total + (total * 50 / 100);
                    }
                    else
                    {
                        total = total = 0;
                    }

                    signup.Total = total;

                    db.Insurees.Add(signup);
                    db.SaveChanges();

                    @ViewBag.Total = total;

                    return View("Total");
                }
            }
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}


        