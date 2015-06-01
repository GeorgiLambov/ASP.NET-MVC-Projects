using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwitterSystem.Web.Controllers
{
    using Data.Contracts;

    public class TweetsController : BaseController
    {

        public TweetsController(ITweeterData data)
            : base(data)
        {
        }

        // GET: Tweets
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tweets/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tweets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tweets/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tweets/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tweets/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tweets/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tweets/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
