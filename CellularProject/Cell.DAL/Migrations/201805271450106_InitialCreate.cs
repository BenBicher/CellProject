namespace Cell.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CallDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LineId = c.Int(nullable: false),
                        Duration = c.Double(nullable: false),
                        ExternalPrice = c.Double(nullable: false),
                        DestinationNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LineDb", t => t.LineId, cascadeDelete: true)
                .Index(t => t.LineId);
            
            CreateTable(
                "dbo.LineDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.String(maxLength: 128),
                        Number = c.String(),
                        Status = c.String(),
                        PackageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientDb", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.ClientDb",
                c => new
                    {
                        ClientId = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ClientTypeId = c.Int(nullable: false),
                        Address = c.String(),
                        ContactNumber = c.String(),
                        CallsToCenter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.ClientTypeDb", t => t.ClientTypeId, cascadeDelete: true)
                .Index(t => t.ClientTypeId);
            
            CreateTable(
                "dbo.ClientTypeDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        MinutePrice = c.Double(nullable: false),
                        SmsPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.String(maxLength: 128),
                        LineId = c.Int(nullable: false),
                        Month = c.DateTime(nullable: false),
                        TotalPayment = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientDb", t => t.ClientId)
                .ForeignKey("dbo.LineDb", t => t.LineId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.LineId);
            
            CreateTable(
                "dbo.PackageDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PackageName = c.String(),
                        PackageTotalPrice = c.Double(nullable: false),
                        LineId = c.Int(nullable: false),
                        PackageIncludesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LineDb", t => t.LineId, cascadeDelete: true)
                .Index(t => t.LineId);
            
            CreateTable(
                "dbo.PackageIncludeDb",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        IncludeName = c.String(),
                        MaxMinute = c.Int(nullable: false),
                        FixedPrice = c.Double(nullable: false),
                        DiscountPrecentage = c.Double(nullable: false),
                        SelectedNumbersId = c.Int(nullable: false),
                        MostCalledNumber = c.Boolean(nullable: false),
                        InsideFamilyCalls = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PackageDb", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.SelectedNumbersDb",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstNumber = c.String(),
                        SecondNumber = c.String(),
                        ThirdNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PackageIncludeDb", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.SMSDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExternalPrice = c.Double(nullable: false),
                        DestinationNumber = c.String(),
                        LineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LineDb", t => t.LineId, cascadeDelete: true)
                .Index(t => t.LineId);
            
            CreateTable(
                "dbo.UserDb",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CallDb", "LineId", "dbo.LineDb");
            DropForeignKey("dbo.SMSDb", "LineId", "dbo.LineDb");
            DropForeignKey("dbo.PackageIncludeDb", "Id", "dbo.PackageDb");
            DropForeignKey("dbo.SelectedNumbersDb", "Id", "dbo.PackageIncludeDb");
            DropForeignKey("dbo.PackageDb", "LineId", "dbo.LineDb");
            DropForeignKey("dbo.LineDb", "ClientId", "dbo.ClientDb");
            DropForeignKey("dbo.PaymentDb", "LineId", "dbo.LineDb");
            DropForeignKey("dbo.PaymentDb", "ClientId", "dbo.ClientDb");
            DropForeignKey("dbo.ClientDb", "ClientTypeId", "dbo.ClientTypeDb");
            DropIndex("dbo.SMSDb", new[] { "LineId" });
            DropIndex("dbo.SelectedNumbersDb", new[] { "Id" });
            DropIndex("dbo.PackageIncludeDb", new[] { "Id" });
            DropIndex("dbo.PackageDb", new[] { "LineId" });
            DropIndex("dbo.PaymentDb", new[] { "LineId" });
            DropIndex("dbo.PaymentDb", new[] { "ClientId" });
            DropIndex("dbo.ClientDb", new[] { "ClientTypeId" });
            DropIndex("dbo.LineDb", new[] { "ClientId" });
            DropIndex("dbo.CallDb", new[] { "LineId" });
            DropTable("dbo.UserDb");
            DropTable("dbo.SMSDb");
            DropTable("dbo.SelectedNumbersDb");
            DropTable("dbo.PackageIncludeDb");
            DropTable("dbo.PackageDb");
            DropTable("dbo.PaymentDb");
            DropTable("dbo.ClientTypeDb");
            DropTable("dbo.ClientDb");
            DropTable("dbo.LineDb");
            DropTable("dbo.CallDb");
        }
    }
}
