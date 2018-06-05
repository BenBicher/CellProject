namespace Cell.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ClientDb", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClientDb", "Id", c => c.Int(nullable: false));
        }
    }
}
