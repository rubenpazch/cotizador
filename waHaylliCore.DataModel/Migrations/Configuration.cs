namespace waHaylliCore.DataModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using waHaylliCore.EntityModel;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<waHaylliCore.DataModel.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(waHaylliCore.DataModel.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            

            Currency currency1 = new Currency { currencyId = 1, shortName = "PEN", largeName = "NUevo Sol", country = "Peru" };
            Currency currency2 = new Currency { currencyId = 2, shortName = "USA", largeName = "American Dollar", country = "United States" };
            Currency currency3 = new Currency { currencyId = 3, shortName = "EUR", largeName = "Euro", country = "Europa" };
            Currency currency4 = new Currency { currencyId = 4, shortName = "CNY", largeName = "Yuanes", country = "China" };
            Currency currency5 = new Currency { currencyId = 5, shortName = "CAD", largeName = "Canadian Dollar", country = "Canada" };

            var currencies = new List<Currency>();
            currencies.Add(currency1);
            currencies.Add(currency2);
            currencies.Add(currency3);
            currencies.Add(currency4);
            currencies.Add(currency5);

            currencies.ForEach(s => context.currencies.AddOrUpdate(p => p.currencyId, s));

            City city1 = new City { cityId = 1, name = "Cusco" };
            City city2 = new City { cityId = 2, name = "Urubamba" };
            City city3 = new City { cityId = 3, name = "Lima" };

            var cities = new List<City>();
            cities.Add(city1);
            cities.Add(city2);
            cities.Add(city3);

            cities.ForEach(s => context.cities.AddOrUpdate(p => p.cityId, s));

            Rate rate1 = new Rate { rateId = 1, nameRate = "Regular day" };
            Rate rate2 = new Rate { rateId = 2, nameRate = "Holidays" };

            var rates = new List<Rate>();
            rates.Add(rate1);
            rates.Add(rate2);

            rates.ForEach(s => context.rates.AddOrUpdate(p => p.rateId, s));

            ServiceType serviceType1 = new ServiceType { serviceTypeId = 1, titleServiceType = "Tour Guide", descriptionServiceType="Tour Guide English - Spanish"};
            ServiceType serviceType2 = new ServiceType { serviceTypeId = 2, titleServiceType = "Restaurant", descriptionServiceType="Assintant Guide Trainee"};
            ServiceType serviceType3 = new ServiceType { serviceTypeId = 3, titleServiceType = "Land Transport", descriptionServiceType = "Land Transport" };
            
            var serviceTypes = new List<ServiceType>();
            serviceTypes.Add(serviceType1);
            serviceTypes.Add(serviceType2);
            serviceTypes.Add(serviceType3);

            serviceTypes.ForEach(s => context.serviceTypes.AddOrUpdate(p => p.serviceTypeId, s));

            Service service1 = new Service { serviceId = 1, titleService = "Guia Bilingue", descriptionService = "Guia bilingue", serviceType = serviceType1, city = city1 };
            Service service2 = new Service { serviceId = 2, titleService = "Assintant Guia", descriptionService = "Assintant Guia", serviceType = serviceType1, city = city1 };
            Service service3 = new Service { serviceId = 3, titleService = "Transporte Compartido", descriptionService = "Transporte Compartido", serviceType = serviceType3, city = city1 };

            var services = new List<Service>();
            services.Add(service1);
            services.Add(service2);
            services.Add(service3);

            services.ForEach(s => context.services.AddOrUpdate(p => p.serviceId, s));

            Price price1 = new Price { priceId = 1, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 1, service = service3 };
            Price price2 = new Price { priceId = 2, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 4, service = service3 };
            Price price3 = new Price { priceId = 3, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 8, service = service3 };
            Price price4 = new Price { priceId = 4, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 14, service = service3 };
            Price price5 = new Price { priceId = 5, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 32, service = service3 };

            Price price6 = new Price { priceId = 6, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 1, service = service1 };
            Price price7 = new Price { priceId = 7, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 4, service = service1 };
            Price price8 = new Price { priceId = 8, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 8, service = service1 };
            Price price9 = new Price { priceId = 9, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 14, service = service1 };
            Price price10 = new Price { priceId = 10, registration = Convert.ToDateTime("9/2/2018"), expiration = Convert.ToDateTime("9/2/2019"), totalPax = 32, service = service1 };

            var prices = new List<Price>();
            prices.Add(price1);
            prices.Add(price2);
            prices.Add(price3);
            prices.Add(price4);
            prices.Add(price5);
            prices.Add(price6);
            prices.Add(price7);
            prices.Add(price8);
            prices.Add(price9);
            prices.Add(price10);

            prices.ForEach(s => context.prices.AddOrUpdate(p => p.priceId, s));

            PriceRate priceRate1 = new PriceRate { priceRateId = 1, rate = rate1, price = price1, value = Convert.ToDecimal(0.00), currency = currency2 };
            PriceRate priceRate2 = new PriceRate { priceRateId = 2, rate = rate1, price = price1, value = Convert.ToDecimal(0.00), currency = currency1 };
            PriceRate priceRate3 = new PriceRate { priceRateId = 3, rate = rate1, price = price2, value = Convert.ToDecimal(39.00), currency = currency2 };
            PriceRate priceRate4 = new PriceRate { priceRateId = 4, rate = rate1, price = price2, value = Convert.ToDecimal(129.09), currency = currency1 };
            PriceRate priceRate5 = new PriceRate { priceRateId = 5, rate = rate1, price = price3, value = Convert.ToDecimal(43.00), currency = currency2 };
            PriceRate priceRate6 = new PriceRate { priceRateId = 6, rate = rate1, price = price3, value = Convert.ToDecimal(142.33), currency = currency1 };
            PriceRate priceRate7 = new PriceRate { priceRateId = 7, rate = rate1, price = price4, value = Convert.ToDecimal(52.00), currency = currency2 };
            PriceRate priceRate8 = new PriceRate { priceRateId = 8, rate = rate1, price = price4, value = Convert.ToDecimal(172.12), currency = currency1 };
            PriceRate priceRate9 = new PriceRate { priceRateId = 9,   rate = rate1, price = price5, value = Convert.ToDecimal(90.00), currency = currency2 };
            PriceRate priceRate10 = new PriceRate { priceRateId = 10, rate = rate1, price = price5, value = Convert.ToDecimal(297.90), currency = currency1 };

            PriceRate priceRate11 = new PriceRate { priceRateId = 11, rate = rate1, price = price6, value = Convert.ToDecimal(0.00), currency = currency2 };
            PriceRate priceRate12 = new PriceRate { priceRateId = 12, rate = rate1, price = price6, value = Convert.ToDecimal(0.00), currency = currency1 };
            PriceRate priceRate13 = new PriceRate { priceRateId = 13, rate = rate1, price = price7, value = Convert.ToDecimal(40.00), currency = currency2 };
            PriceRate priceRate14 = new PriceRate { priceRateId = 14, rate = rate1, price = price7, value = Convert.ToDecimal(132.40), currency = currency1 };
            PriceRate priceRate15 = new PriceRate { priceRateId = 15, rate = rate1, price = price8, value = Convert.ToDecimal(40.00), currency = currency2 };
            PriceRate priceRate16 = new PriceRate { priceRateId = 16, rate = rate1, price = price8, value = Convert.ToDecimal(132.40), currency = currency1 };
            PriceRate priceRate17 = new PriceRate { priceRateId = 17, rate = rate1, price = price9, value = Convert.ToDecimal(40.00), currency = currency2 };
            PriceRate priceRate18 = new PriceRate { priceRateId = 18, rate = rate1, price = price9, value = Convert.ToDecimal(132.40), currency = currency1 };
            PriceRate priceRate19 = new PriceRate { priceRateId = 19, rate = rate1, price = price10, value = Convert.ToDecimal(40.00), currency = currency2 };
            PriceRate priceRate20 = new PriceRate { priceRateId = 20, rate = rate1, price = price10, value = Convert.ToDecimal(132.40), currency = currency1 };


            var priceRates = new List<PriceRate>();
            priceRates.Add(priceRate1);
            priceRates.Add(priceRate2);
            priceRates.Add(priceRate3);
            priceRates.Add(priceRate4);
            priceRates.Add(priceRate5);
            priceRates.Add(priceRate6);
            priceRates.Add(priceRate7);
            priceRates.Add(priceRate8);
            priceRates.Add(priceRate9);
            priceRates.Add(priceRate10);
            priceRates.Add(priceRate11);
            priceRates.Add(priceRate12);
            priceRates.Add(priceRate13);
            priceRates.Add(priceRate14);
            priceRates.Add(priceRate15);
            priceRates.Add(priceRate16);
            priceRates.Add(priceRate17);
            priceRates.Add(priceRate18);
            priceRates.Add(priceRate19);
            priceRates.Add(priceRate20);

            priceRates.ForEach(s => context.priceRates.AddOrUpdate(p => p.priceRateId, s));

            context.SaveChanges();
        }
    }
}
