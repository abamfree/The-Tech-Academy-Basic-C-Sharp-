using System;

using System.Collections.Generic;

using System.Data;

using System.Data.Entity;

using System.Linq;

using System.Net;

using System.Web;

using System.Web.Mvc;

using CarInsuranceMVC2.Models;

//using InsuranceEntities;



namespace CarInsuranceMVC2.Controllers

{

    public class InsureeController : Controller

    {

        private InsuranceEntities db = new InsuranceEntities();



        // GET: Insuree

        public ActionResult Index()

        {

            return View(db.Insurees.ToList());

        }



        public ActionResult Success()

        {

            return View(db.Insurees.OrderByDescending(x => x.Quote).Take(1).ToList());

        }



        public ActionResult Admin()

        {

            return View(db.Insurees.ToList());

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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree) //removed quote

        {

            insuree.Quote = 50;

            if ((DateTime.Now.Year - insuree.DateOfBirth.Year) < 18)

            {

                insuree.Quote += 100;

            }

            else if ((DateTime.Now.Year - insuree.DateOfBirth.Year) < 25)

            {

                insuree.Quote += 25;

            }

            else if ((DateTime.Now.Year - insuree.DateOfBirth.Year) > 100)

            {

                insuree.Quote += 25;

            }



            if (insuree.CarYear < 2000)

            {

                insuree.Quote += 25;

            }

            else if (insuree.CarYear > 2015)

            {

                insuree.Quote += 25;

            }



            if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche" && insuree.CarModel == "911 Carrera" || insuree.CarModel == "911 carrera")

            {

                insuree.Quote += 50;

            }

            else if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche")

            {

                insuree.Quote += 25;

            }



            if (insuree.SpeedingTickets > 0)

            {

                insuree.Quote += (insuree.SpeedingTickets * 10);

            }



            if (insuree.DUI == true)

            {

                insuree.Quote *= 1.25m;

            }



            if (insuree.CoverageType == true)

            {

                insuree.Quote *= 1.50m;

            }



            if (ModelState.IsValid)

            {

                db.Insurees.Add(insuree);

                db.SaveChanges();

            }

            return View("Success", db.Insurees.OrderByDescending(x => x.Quote).Take(1).ToList());

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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

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