namespace Cell.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PackageDb", "LineId", "dbo.LineDb");
            DropIndex("dbo.PackageDb", new[] { "LineId" });
            AlterColumn("dbo.PackageDb", "LineId", c => c.Int());
            AlterColumn("dbo.PackageDb", "PackageIncludesId", c => c.Int());
            CreateIndex("dbo.PackageDb", "LineId");
            AddForeignKey("dbo.PackageDb", "LineId", "dbo.LineDb", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PackageDb", "LineId", "dbo.LineDb");
            DropIndex("dbo.PackageDb", new[] { "LineId" });
            AlterColumn("dbo.PackageDb", "PackageIncludesId", c => c.Int(nullable: false));
            AlterColumn("dbo.PackageDb", "LineId", c => c.Int(nullable: false));
            CreateIndex("dbo.PackageDb", "LineId");
            AddForeignKey("dbo.PackageDb", "LineId", "dbo.LineDb", "Id", cascadeDelete: true);
        }
    }
}
