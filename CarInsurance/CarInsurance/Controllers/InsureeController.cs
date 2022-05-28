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
        public decimal Car_Info(string firstName, string lastName, string emailAddress, DateTime dateofbirth, int? caryear, string carmake, string carmodel, int? speedingtickets, bool dui, bool coverage)
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
                    signup.DUI = dui;
                    signup.CoverageType = coverage;

                    //making total base num 50
                    decimal total = 50;
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
                        total += Convert.ToDecimal(speedingtickets * 10);
                    }
                    else
                    {
                        total = total + 0;
                    }

                    //If the user has ever had a DUI, add 25% to the total.
                    if (dui == true)
                    {
                        total = total + (total * 25 / 100);
                    }
                    else
                    {
                        total = total + 0;
                    }

                    //If it's full coverage, add 50% to the total.
                    if (coverage == true)
                    {
                        total = total + (total * 50 / 100);
                    }
                    else
                    {
                        total = total = 0;
                    }

                return total;
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
                insuree.Quote = Car_Info(insuree.FirstName, insuree.LastName, insuree.EmailAddress, insuree.DateOfBirth, insuree.CarYear, insuree.CarMake, insuree.CarModel, insuree.SpeedingTickets, insuree.DUI, insuree.CoverageType);
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


        