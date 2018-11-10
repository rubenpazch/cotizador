using System;
using System.Web.Mvc;
using waHaylliCore.DataModel.Rates;
using waHaylliCore.EntityModel.Rates.ViewModels;
using waHaylliCore.EntityModel.Repository;

namespace waHaylliCore.Mvc.Controllers
{
    public class RateController : Controller
    {
        readonly IRateRepository repo;

        public RateController(IRateRepository repo)
        {
            this.repo = repo;
        }

        // GET: Rate
        public ActionResult Index()
        {
            //var repo = new RateRepository();
            var rateList = repo.GetRates();
            return View(rateList);
        }

        // GET: Rate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rate/Create
        public ActionResult Create()
        {
            //var repo = new RateRepository();
            var rate = repo.CreateRate();
            return View(rate);
        }

        // POST: Rate/Create
        [HttpPost]
        public ActionResult Create([Bind(Include ="rateId,nameRate")] RateEditViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid) {
                    //var repo = new RateRepository();
                    bool saved = repo.SaveRate(model);
                    if (saved) {
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Rate/Edit/5
        public ActionResult Edit(int id)
        {
            //var repo = new RateRepository();
            var rate = repo.EditRate(id);
            return View(rate);
        }

        // POST: Rate/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "rateId,nameRate")] RateEditViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    //var repo = new RateRepository();
                    bool saved = repo.UpdateRate(model);
                    if (saved)
                    {
                        return RedirectToAction("Index");
                    }
                }
                return View();
                
            }
            catch(Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: Rate/Delete/5
        public ActionResult Delete(int id)
        {
            //var repo = new RateRepository();
            // var rate = repo.EditRate(id);
            var rate = repo.GetRates().Find(m=> m.id);
            return View(rate);
        }
        
        // POST: Rate/Delete/5
        [HttpPost]
        public ActionResult confirm(int id, [Bind(Include = "rateId,nameRate")] RateEditViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                //var repo = new RateRepository();
                repo.DeleteRate(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
