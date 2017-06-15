using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCAssignment7_1.Models;

namespace MVCAssignment7_1.Controllers
{
    public class Donation : Controller
    {
        private Community_AssistEntities db = new Community_AssistEntities();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DonationAmount,PersonKey,DonationDate")] MVCAssignment7_1.Models.Donation donation)
        {
            if (ModelState.IsValid)
            {        
                db.Donations.Add(donation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }      
    }
}