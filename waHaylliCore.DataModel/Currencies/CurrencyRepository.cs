using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waHaylliCore.EntityModel.Currencies.ViewModels;
using waHaylliCore.EntityModel;

namespace waHaylliCore.DataModel
{
    public class CurrencyRepository
    {
        public List<CurrencyDisplayViewModel> GetCurrency()
        {
            using (var context = new ApplicationDbContext())
            {
                List<Currency> currencies = new List<Currency>();
                currencies = context.currencies.AsNoTracking().ToList();
                if (currencies != null)
                {
                    List<CurrencyDisplayViewModel> listcurrenciesDisplay = new List<CurrencyDisplayViewModel>();
                    foreach (var x in currencies)
                    {
                        var currencyDisplay = new CurrencyDisplayViewModel()
                        {
                            currencyId = x.currencyId,
                            shortName = x.shortName,
                            largeName= x.largeName,
                            country = x.country
                        };
                        listcurrenciesDisplay.Add(currencyDisplay);
                    }
                    return listcurrenciesDisplay;
                }
                return null;
            }
        }
        public CurrencyEditViewModel CreateCurrency()
        {
            CurrencyEditViewModel CurrencyEditModel = new CurrencyEditViewModel();
            return CurrencyEditModel;
        }
        public bool SaveCurrency(CurrencyEditViewModel currencyCreate)
        {
            if (currencyCreate != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    var currency = new Currency()
                    {
                        currencyId = currencyCreate.currencyId,
                        shortName = currencyCreate.shortName,
                        largeName =currencyCreate.largeName,
                        country=currencyCreate.country
                    };
                    context.currencies.Add(currency);
                    context.SaveChanges();
                    return true;
                }
            }
            // Return false if customeredit == null or CustomerID is not a guid
            return false;
        }
        public CurrencyEditViewModel EditCurrency(int id)
        {
            CurrencyEditViewModel currencyEditModel = new CurrencyEditViewModel();
            using (var context = new ApplicationDbContext())
            {
                List<Currency> currencies = new List<Currency>();
                currencies = context.currencies.AsNoTracking().ToList();
                foreach (var item in currencies)
                {
                    if (item.currencyId == id)
                    {
                        currencyEditModel.currencyId = item.currencyId;
                        currencyEditModel.shortName = item.shortName;
                        currencyEditModel.largeName = item.largeName;
                        currencyEditModel.country = item.country;
                    }
                }
            }
            return currencyEditModel;
        }
        public bool UpdateCurrency(CurrencyEditViewModel currencyUpdate)
        {
            if (currencyUpdate != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    var result = context.currencies.SingleOrDefault(b => b.currencyId == currencyUpdate.currencyId);

                    if (result != null)
                    {
                        result.shortName = currencyUpdate.shortName;
                        result.largeName = currencyUpdate.largeName;
                        result.country = currencyUpdate.country;

                        context.SaveChanges();
                    }
                    return true;
                }
            }
            // Return false if customeredit == null or CustomerID is not a guid
            return false;
        }
        public void DeleteCurrency(CurrencyEditViewModel currencyDelete)
        {
            if (currencyDelete != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    var itemToRemove = context.currencies.SingleOrDefault(x => x.currencyId == currencyDelete.currencyId); //returns a single item.

                    if (itemToRemove != null)
                    {
                        context.currencies.Remove(itemToRemove);
                        context.SaveChanges();
                    }
                }
            }
        }

    }
}
