namespace Cell.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientDb", "LineId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientDb", "LineId");
        }
    }
}
