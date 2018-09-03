namespace waHaylliCore.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        cityId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.cityId);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        currencyId = c.Int(nullable: false, identity: true),
                        shortName = c.String(),
                        largeName = c.String(),
                        country = c.String(),
                    })
                .PrimaryKey(t => t.currencyId);
            
            CreateTable(
                "dbo.PriceRates",
                c => new
                    {
                        priceRateId = c.Int(nullable: false, identity: true),
                        value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        price_priceId = c.Int(),
                        rate_rateId = c.Int(),
                    })
                .PrimaryKey(t => t.priceRateId)
                .ForeignKey("dbo.Prices", t => t.price_priceId)
                .ForeignKey("dbo.Rates", t => t.rate_rateId)
                .Index(t => t.price_priceId)
                .Index(t => t.rate_rateId);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        priceId = c.Int(nullable: false, identity: true),
                        registration = c.DateTime(nullable: false),
                        expiration = c.DateTime(nullable: false),
                        totalPax = c.Int(nullable: false),
                        service_serviceId = c.Int(),
                    })
                .PrimaryKey(t => t.priceId)
                .ForeignKey("dbo.Services", t => t.service_serviceId)
                .Index(t => t.service_serviceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        serviceId = c.Int(nullable: false, identity: true),
                        titleService = c.String(),
                        descriptionService = c.String(),
                        city_cityId = c.Int(),
                        serviceType_serviceTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.serviceId)
                .ForeignKey("dbo.Cities", t => t.city_cityId)
                .ForeignKey("dbo.ServiceTypes", t => t.serviceType_serviceTypeId)
                .Index(t => t.city_cityId)
                .Index(t => t.serviceType_serviceTypeId);
            
            CreateTable(
                "dbo.ServiceTypes",
                c => new
                    {
                        serviceTypeId = c.Int(nullable: false, identity: true),
                        titleServiceType = c.String(),
                        descriptionServiceType = c.String(),
                    })
                .PrimaryKey(t => t.serviceTypeId);
            
            CreateTable(
                "dbo.Rates",
                c => new
                    {
                        rateId = c.Int(nullable: false, identity: true),
                        nameRate = c.String(),
                    })
                .PrimaryKey(t => t.rateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PriceRates", "rate_rateId", "dbo.Rates");
            DropForeignKey("dbo.PriceRates", "price_priceId", "dbo.Prices");
            DropForeignKey("dbo.Prices", "service_serviceId", "dbo.Services");
            DropForeignKey("dbo.Services", "serviceType_serviceTypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.Services", "city_cityId", "dbo.Cities");
            DropIndex("dbo.Services", new[] { "serviceType_serviceTypeId" });
            DropIndex("dbo.Services", new[] { "city_cityId" });
            DropIndex("dbo.Prices", new[] { "service_serviceId" });
            DropIndex("dbo.PriceRates", new[] { "rate_rateId" });
            DropIndex("dbo.PriceRates", new[] { "price_priceId" });
            DropTable("dbo.Rates");
            DropTable("dbo.ServiceTypes");
            DropTable("dbo.Services");
            DropTable("dbo.Prices");
            DropTable("dbo.PriceRates");
            DropTable("dbo.Currencies");
            DropTable("dbo.Cities");
        }
    }
}
