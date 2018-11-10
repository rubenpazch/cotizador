using System.Collections.Generic;
using waHaylliCore.EntityModel.Rates.ViewModels;

namespace waHaylliCore.EntityModel.Repository
{
    public interface IRateRepository
    {
        RateEditViewModel CreateRate();
        void DeleteRate(RateEditViewModel rateDelete);
        RateEditViewModel EditRate(int id);
        List<RateDisplayViewModel> GetRates();
        bool SaveRate(RateEditViewModel rateCreate);
        bool UpdateRate(RateEditViewModel rateUpdate);
    }
}