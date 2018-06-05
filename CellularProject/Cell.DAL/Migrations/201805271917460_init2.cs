namespace Cell.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClientTypeDb", "MinutePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ClientTypeDb", "SmsPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientTypeDb", "SmsPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.ClientTypeDb", "MinutePrice", c => c.Double(nullable: false));
        }
    }
}
