using System.Collections.Generic;
using waHaylliCore.EntityModel;

namespace waHaylliCore.DataAccess
{
    public class Data
    {
        public List<ServiceType> serviceType = new List<ServiceType>();
        public List<City> cities = new List<City>();
        public List<State> states = new List<State>();
        public List<County> counties = new List<County>();
        public List<Service> services = new List<Service>();
        public List<Currency> currencies = new List<Currency>();
        public List<Rate> rates = new List<Rate>();
        public List<Price> prices = new List<Price>();
        public List<PriceRate> priceRates = new List<PriceRate>();
        public Data() {

            serviceType.Add(new ServiceType(0, "Transport", "Transport"));
            serviceType.Add(new ServiceType(1, "Guides", "Guides"));
            serviceType.Add(new ServiceType(2, "Entrances", "Entrances"));
            serviceType.Add(new ServiceType(3, "Trains", "Trains"));
            serviceType.Add(new ServiceType(4, "Assistant Guides", "Assistant Guides"));
            serviceType.Add(new ServiceType(5, "Fees", "Fees"));

            services.Add(new Service(0, "Transporte Van", "Transporte Van", serviceType[0]));
            services.Add(new Service(1, "Transporte Sprinter 8", "Transporte Sprinter 8", serviceType[0]));
            services.Add(new Service(2, "Transporte Sprinter 14", "Transporte Sprinter 14", serviceType[0]));
            services.Add(new Service(3, "Transporte Bus", "Transporte Bus", serviceType[0]));
            services.Add(new Service(4, "Guide English", "Guide English", serviceType[1]));
            services.Add(new Service(5, "Guide Spanish", "Guide Spanish", serviceType[1]));
            services.Add(new Service(6, "Ticket de entrada a Templo Coricancha", "Ticket de entrada a Templo Coricancha", serviceType[2]));
            services.Add(new Service(7, "Ticket de entrada a la catedral del cusco", "Ticket de entrada a la catedral del cusco", serviceType[2]));
            services.Add(new Service(8, "Boleto turístico parcial", "Boleto turístico parcial", serviceType[2]));
            services.Add(new Service(9, "Fees stripe 2.9%+0,30", "Fees stripe 2.9%+0,30", serviceType[5]));


             states.Add(new State(1,"Cusco"));
             states.Add(new State(2, "Lima"));
             states.Add(new State(3, "Arequipa"));
             states.Add(new State(4, "Puno"));

             counties.Add(new County(1, "Cusco", states[0]));            
             counties.Add(new County(2, "Lima", states[1]));
             counties.Add(new County(3, "Arequipa", states[2]));
             counties.Add(new County(4, "Puno", states[3]));
             counties.Add(new County(5, "Urubamba", states[0]));

             cities.Add(new City(1,"Cusco",counties[0]));
             cities.Add(new City(2, "urubamba", counties[4]));
             cities.Add(new City(3, "San Roman", counties[3]));
             cities.Add(new City(4, "Miraflores", counties[1]));
             cities.Add(new City(5, "Arequipa", counties[2]));

             currencies.Add(new Currency(0, "PEN", "Nuevo Sol", "Peru"));
             currencies.Add(new Currency(1, "USD", "Dolar", "United States"));
             currencies.Add(new Currency(2, "EUR", "Euro", "Europa"));

            rates.Add(new Rate(0,"Por Persona",currencies[0]));
            rates.Add(new Rate(1, "Por Persona", currencies[1]));
            rates.Add(new Rate(2, "Por Grupo", currencies[0]));
            rates.Add(new Rate(3, "Por Grupo", currencies[1]));

            
            prices.Add(new Price(0,new System.DateTime(), new System.DateTime(),services[0],4));
            prices.Add(new Price(1, new System.DateTime(), new System.DateTime(), services[1], 8));
            prices.Add(new Price(2, new System.DateTime(), new System.DateTime(), services[2], 14));
            prices.Add(new Price(3, new System.DateTime(), new System.DateTime(), services[3], 32));

            prices.Add(new Price(4, new System.DateTime(), new System.DateTime(), services[4], 4));
            prices.Add(new Price(5, new System.DateTime(), new System.DateTime(), services[4], 8));
            prices.Add(new Price(6, new System.DateTime(), new System.DateTime(), services[4], 14));
            prices.Add(new Price(7, new System.DateTime(), new System.DateTime(), services[4], 32));

            prices.Add(new Price(8, new System.DateTime(), new System.DateTime(), services[6], 4));
            prices.Add(new Price(9, new System.DateTime(), new System.DateTime(), services[6], 8));
            prices.Add(new Price(10, new System.DateTime(), new System.DateTime(), services[6],14));
            prices.Add(new Price(11, new System.DateTime(), new System.DateTime(), services[6], 32));

            prices.Add(new Price(12, new System.DateTime(), new System.DateTime(), services[7], 4));
            prices.Add(new Price(13, new System.DateTime(), new System.DateTime(), services[7], 8));
            prices.Add(new Price(14, new System.DateTime(), new System.DateTime(), services[7], 14));
            prices.Add(new Price(15, new System.DateTime(), new System.DateTime(), services[7], 32));

            prices.Add(new Price(16, new System.DateTime(), new System.DateTime(), services[8], 4));
            prices.Add(new Price(17, new System.DateTime(), new System.DateTime(), services[8], 8));
            prices.Add(new Price(18, new System.DateTime(), new System.DateTime(), services[8], 14));
            prices.Add(new Price(19, new System.DateTime(), new System.DateTime(), services[8], 32));

            prices.Add(new Price(20, new System.DateTime(), new System.DateTime(), services[9], 4));
            prices.Add(new Price(21, new System.DateTime(), new System.DateTime(), services[9], 8));
            prices.Add(new Price(22, new System.DateTime(), new System.DateTime(), services[9], 14));
            prices.Add(new Price(23, new System.DateTime(), new System.DateTime(), services[9], 32));

            priceRates.Add(new PriceRate(0,     prices[0], rates[3], 39));
            priceRates.Add(new PriceRate(1,     prices[1], rates[3], 43));
            priceRates.Add(new PriceRate(2,     prices[2], rates[3], 52));
            priceRates.Add(new PriceRate(3,     prices[3], rates[3], 90));

            priceRates.Add(new PriceRate(4,     prices[4], rates[3], 40));
            priceRates.Add(new PriceRate(5,     prices[5], rates[3], 40));
            priceRates.Add(new PriceRate(6,     prices[6], rates[3], 40));
            priceRates.Add(new PriceRate(7,     prices[7], rates[3], 40));
           

            priceRates.Add(new PriceRate(8,     prices[8], rates[3],   18.46M));
            priceRates.Add(new PriceRate(9,     prices[9], rates[3],   36.92M));
            priceRates.Add(new PriceRate(10,     prices[10], rates[3], 64.62M));
            priceRates.Add(new PriceRate(11,     prices[11], rates[3], 147.69M));

            priceRates.Add(new PriceRate(12,     prices[12], rates[3], 30.77M));
            priceRates.Add(new PriceRate(13,     prices[13], rates[3], 61.54M));
            priceRates.Add(new PriceRate(14,     prices[14], rates[3], 107.69M));
            priceRates.Add(new PriceRate(15,     prices[15], rates[3], 246.15M));

            priceRates.Add(new PriceRate(16,     prices[16], rates[3], 86.15M));
            priceRates.Add(new PriceRate(17,     prices[17], rates[3], 172.31M));
            priceRates.Add(new PriceRate(18,     prices[18], rates[3], 301.54M));
            priceRates.Add(new PriceRate(19,     prices[19], rates[3], 689.23M));

            priceRates.Add(new PriceRate(20,     prices[20], rates[3], 2.48M));
            priceRates.Add(new PriceRate(21,     prices[21], rates[3], 2.19M));
            priceRates.Add(new PriceRate(22,     prices[22], rates[3], 2.04M));
            priceRates.Add(new PriceRate(23,     prices[23], rates[3], 1.90M));
            



        }
    }
}
