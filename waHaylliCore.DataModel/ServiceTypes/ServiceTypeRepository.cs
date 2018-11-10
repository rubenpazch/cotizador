using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waHaylliCore.EntityModel;
using waHaylliCore.EntityModel.ServiceTypes.ViewModels;

namespace waHaylliCore.DataModel
{
    public class ServiceTypeRepository
    {

        public List<ServiceTypeDisplayViewModel> GetServiceType()
        {
            using (var context = new ApplicationDbContext())
            {
                List<ServiceType> serviceTypes = new List<ServiceType>();
                serviceTypes = context.serviceTypes.AsNoTracking().ToList();
                if (serviceTypes != null)
                {
                    List<ServiceTypeDisplayViewModel> listServiceTypesDisplay = new List<ServiceTypeDisplayViewModel>();
                    foreach (var x in serviceTypes)
                    {
                        var serviceTypeDisplay = new ServiceTypeDisplayViewModel()
                        {
                            serviceTypeId= x.serviceTypeId,
                            titleServiceType = x.titleServiceType,
                            descriptionServiceType = x.descriptionServiceType,
                        };
                        listServiceTypesDisplay.Add(serviceTypeDisplay);
                    }
                    return listServiceTypesDisplay;
                }
                return null;
            }
        }
        public ServiceTypeEditViewModel CreateServiceType()
        {
            ServiceTypeEditViewModel serviceTypeEditViewModel = new ServiceTypeEditViewModel();
            return serviceTypeEditViewModel;
        }
        public bool SaveServiceType(ServiceTypeEditViewModel serviceCreate)
        {
            if (serviceCreate != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    var serviceType = new ServiceType()
                    {
                        serviceTypeId = serviceCreate.serviceTypeId,
                        titleServiceType = serviceCreate.titleServiceType,
                        descriptionServiceType = serviceCreate.descriptionServiceType
                    };
                    context.serviceTypes.Add(serviceType);
                    context.SaveChanges();
                    return true;
                }
            }
            // Return false if customeredit == null or CustomerID is not a guid
            return false;
        }
        public ServiceTypeEditViewModel EditServiceType(int id)
        {
            ServiceTypeEditViewModel serviceTypeEditViewModel  = new ServiceTypeEditViewModel();
            using (var context = new ApplicationDbContext())
            {
                List<ServiceType> serviceTypes = new List<ServiceType>();
                serviceTypes = context.serviceTypes.AsNoTracking().ToList();
                foreach (var item in serviceTypes)
                {
                    if (item.serviceTypeId== id)
                    {
                        serviceTypeEditViewModel.serviceTypeId = item.serviceTypeId;
                        serviceTypeEditViewModel.titleServiceType = item.titleServiceType;
                        serviceTypeEditViewModel.descriptionServiceType = item.descriptionServiceType;
                       
                    }
                }
            }
            return serviceTypeEditViewModel;
        }
        public bool UpdateRate(ServiceTypeEditViewModel serviceTypeUpdate)
        {
            if (serviceTypeUpdate != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    var result = context.serviceTypes.SingleOrDefault(b => b.serviceTypeId== serviceTypeUpdate.serviceTypeId);

                    if (result != null)
                    {
                        result.serviceTypeId = serviceTypeUpdate.serviceTypeId;
                        result.titleServiceType = serviceTypeUpdate.titleServiceType;
                        result.descriptionServiceType = serviceTypeUpdate.descriptionServiceType;

                        context.SaveChanges();
                    }
                    return true;
                }
            }
            // Return false if customeredit == null or CustomerID is not a guid
            return false;
        }
        public void DeleteRate(ServiceTypeEditViewModel serviceTypeDelete)
        {
            if (serviceTypeDelete != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    var itemToRemove = context.serviceTypes.SingleOrDefault(x => x.serviceTypeId == serviceTypeDelete.serviceTypeId); //returns a single item.

                    if (itemToRemove != null)
                    {
                        context.serviceTypes.Remove(itemToRemove);
                        context.SaveChanges();
                    }
                }
            }
        }

    }
}
