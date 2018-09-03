namespace waHaylliCore.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PriceRates", "currency_currencyId", c => c.Int());
            CreateIndex("dbo.PriceRates", "currency_currencyId");
            AddForeignKey("dbo.PriceRates", "currency_currencyId", "dbo.Currencies", "currencyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PriceRates", "currency_currencyId", "dbo.Currencies");
            DropIndex("dbo.PriceRates", new[] { "currency_currencyId" });
            DropColumn("dbo.PriceRates", "currency_currencyId");
        }
    }
}
