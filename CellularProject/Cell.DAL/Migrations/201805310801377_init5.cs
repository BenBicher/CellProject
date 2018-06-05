namespace Cell.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PackageIncludeDb", "MaxMinute", c => c.Int());
            AlterColumn("dbo.PackageIncludeDb", "FixedPrice", c => c.Double());
            AlterColumn("dbo.PackageIncludeDb", "DiscountPrecentage", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PackageIncludeDb", "DiscountPrecentage", c => c.Double(nullable: false));
            AlterColumn("dbo.PackageIncludeDb", "FixedPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.PackageIncludeDb", "MaxMinute", c => c.Int(nullable: false));
        }
    }
}
