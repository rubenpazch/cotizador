using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waHaylliCore.EntityModel;
using waHaylliCore.EntityModel.Rates.ViewModels;
using System.Data.Entity;
using waHaylliCore.EntityModel.Repository;

namespace waHaylliCore.DataModel.Rates
{
    public class RateRepository : IRateRepository
    {
        public List<RateDisplayViewModel> GetRates()
        {
            using (var context = new ApplicationDbContext())
            {
                List<Rate> rates = new List<Rate>();
                rates = context.rates.AsNoTracking().ToList();
                if (rates != null)
                {
                    List<RateDisplayViewModel> ratesDisplay = new List<RateDisplayViewModel>();
                    foreach (var x in rates)
                    {
                        var rateDisplay = new RateDisplayViewModel()
                        {
                            rateId = x.rateId,
                            nameRate = x.nameRate
                        };
                        ratesDisplay.Add(rateDisplay);
                    }
                    return ratesDisplay;
                }
                return null;
            }
        }
        public RateEditViewModel CreateRate()
        {
            RateEditViewModel rateEditModel = new RateEditViewModel();
            return rateEditModel;
        }

        public bool SaveRate(RateEditViewModel rateCreate)
        {
            if (rateCreate != null)
            {
                using (var context = new ApplicationDbContext())
                {
                        var rate = new Rate()
                        {
                            rateId = rateCreate.rateId,
                            nameRate = rateCreate.nameRate
                        };
                        context.rates.Add(rate);
                        context.SaveChanges();
                        return true;
                }
            }
            // Return false if customeredit == null or CustomerID is not a guid
            return false;
        }

        public RateEditViewModel EditRate(int id)
        {
            RateEditViewModel rateEditModel = new RateEditViewModel();
            using (var context = new ApplicationDbContext())
            {
                List<Rate> rates = new List<Rate>();
                rates = context.rates.AsNoTracking().ToList();
                foreach (var item in rates)
                {
                    if (item.rateId == id) {
                        rateEditModel.rateId = item.rateId;
                        rateEditModel.nameRate = item.nameRate;
                    }
                }
            }
            return rateEditModel;
        }


        public bool UpdateRate(RateEditViewModel rateUpdate)
        {
            if (rateUpdate != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    var result = context.rates.SingleOrDefault(b => b.rateId == rateUpdate.rateId);

                    if (result != null)
                    {
                        result.nameRate = rateUpdate.nameRate;
                        context.SaveChanges();
                    }
                    return true;
                }
            }
            // Return false if customeredit == null or CustomerID is not a guid
            return false;
        }
        public void DeleteRate(RateEditViewModel rateDelete) {
            if (rateDelete!=null)
            {
                using (var context = new ApplicationDbContext())
                {
                    var itemToRemove = context.rates.SingleOrDefault(x => x.rateId == rateDelete.rateId); //returns a single item.

                    if (itemToRemove != null)
                    {
                        context.rates.Remove(itemToRemove);
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
