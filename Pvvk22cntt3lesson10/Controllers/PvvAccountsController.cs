using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pvvk22cntt3lesson10.Models;

namespace Pvvk22cntt3lesson10.Controllers
{
    public class PvvAccountsController : Controller
    {
        private PvvK22cntt3lesson10Entities db = new PvvK22cntt3lesson10Entities();

        // GET: PvvAccounts
        public ActionResult Index()
        {
            return View(db.PvvAccount.ToList());
        }

        // GET: PvvAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvAccount pvvAccount = db.PvvAccount.Find(id);
            if (pvvAccount == null)
            {
                return HttpNotFound();
            }
            return View(pvvAccount);
        }

        // GET: PvvAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PvvAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PvvID,PvvUsersName,PvvPassword,PvvFullName,PvvEmail,PvvPhone,PvvActive")] PvvAccount pvvAccount)
        {
            if (ModelState.IsValid)
            {
                db.PvvAccount.Add(pvvAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pvvAccount);
        }

        // GET: PvvAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvAccount pvvAccount = db.PvvAccount.Find(id);
            if (pvvAccount == null)
            {
                return HttpNotFound();
            }
            return View(pvvAccount);
        }

        // POST: PvvAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PvvID,PvvUsersName,PvvPassword,PvvFullName,PvvEmail,PvvPhone,PvvActive")] PvvAccount pvvAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pvvAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pvvAccount);
        }

        // GET: PvvAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PvvAccount pvvAccount = db.PvvAccount.Find(id);
            if (pvvAccount == null)
            {
                return HttpNotFound();
            }
            return View(pvvAccount);
        }

        // POST: PvvAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PvvAccount pvvAccount = db.PvvAccount.Find(id);
            db.PvvAccount.Remove(pvvAccount);
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
        //login 
        public ActionResult PvvLogin()
        {
            var pvvModer = new PvvAccount();
            return View();
        }
        [HttpPost]
        public ActionResult PvvLogin(PvvAccount pvvAccount )
        {
            var pvvcheck = db.PvvAccount.Where(x => x.PvvUsersName.Equals(pvvAccount.PvvUsersName) && x.PvvPassword.Equals(pvvAccount.PvvPassword)).FirstOrDefault();
            if (pvvcheck != null)
            {
                Session["PvvAccount"]= pvvcheck;
                return Redirect("/");
            }
            return View(pvvAccount);
        }
    }
}
