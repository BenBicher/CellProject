namespace Cell.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ClientDb", "ContactNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClientDb", "ContactNumber", c => c.String());
        }
    }
}
