using System.Web.Mvc;
using waHaylliCore.DataModel;
using waHaylliCore.EntityModel.Currencies.ViewModels;

namespace waHaylliCore.Mvc.Controllers
{
    public class CurrencyController : Controller
    {
        // GET: Currency
        public ActionResult Index()
        {
            var repo = new CurrencyRepository();
            var currencyList = repo.GetCurrency();
            return View(currencyList);
        }

        // GET: Currency/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Currency/Create
        public ActionResult Create()
        {
            var repo = new CurrencyRepository();
            var currency = repo.CreateCurrency();
            return View(currency);
        }

        // POST: Currency/Create
        [HttpPost]
        public ActionResult Create([Bind(Include="currencyId,shortName,largeName,country")] CurrencyEditViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var repo = new CurrencyRepository();
                    bool saved = repo.SaveCurrency(model);

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

        // GET: Currency/Edit/5
        public ActionResult Edit(int id)
        {
            var repo = new CurrencyRepository();
            var currency = repo.EditCurrency(id);
            return View(currency);
        }

        // POST: Currency/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "currencyId,shortName,largeName,country")] CurrencyEditViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid) {
                    var repo = new CurrencyRepository();
                    bool saved = repo.UpdateCurrency(model);
                    if (saved)
                    {
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

        // GET: Currency/Delete/5
        public ActionResult Delete(int id)
        {
            var repo = new CurrencyRepository();
            var currency = repo.EditCurrency(id);

            return View(currency);
        }

        // POST: Currency/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,[Bind(Include = "currencyId,shortName,largeName,country")] CurrencyEditViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                var repo = new CurrencyRepository();
                repo.DeleteCurrency(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
