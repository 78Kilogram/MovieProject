namespace MovieProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ads",
                c => new
                    {
                        AdsID = c.Int(nullable: false, identity: true),
                        NameAds = c.String(nullable: false, maxLength: 100),
                        ImageAds = c.String(nullable: false),
                        UrlAds = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdsID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        NameCategory = c.String(nullable: false, maxLength: 100),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Homeflag = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MateDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Image = c.String(nullable: false),
                        MoreImage = c.String(storeType: "xml"),
                        Actor = c.String(),
                        Description = c.String(),
                        Directors = c.String(),
                        Time = c.String(),
                        Year = c.Int(),
                        Country = c.String(),
                        Tags = c.String(),
                        MovieLink = c.String(nullable: false),
                        TrailerLink = c.String(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Rate = c.Int(),
                        TrailerID = c.Int(nullable: false),
                        Viewed = c.Int(nullable: false),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Homeflag = c.Boolean(),
                        Hotflag = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MateDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MovieID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Trailers", t => t.TrailerID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.TrailerID);
            
            CreateTable(
                "dbo.Trailers",
                c => new
                    {
                        TrailerID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Image = c.String(nullable: false),
                        Url = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TrailerID);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Information = c.String(),
                    })
                .PrimaryKey(t => t.NewsID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Content = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        SlideID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Desciption = c.String(),
                        Image = c.String(nullable: false),
                        Url = c.String(nullable: false),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.SlideID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        SupportID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Facebook = c.String(),
                        Email = c.String(),
                        Mobile = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SupportID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Valuestring = c.String(),
                        Valueint = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        VisitedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "TrailerID", "dbo.Trailers");
            DropForeignKey("dbo.Movies", "CategoryID", "dbo.Category");
            DropIndex("dbo.Movies", new[] { "TrailerID" });
            DropIndex("dbo.Movies", new[] { "CategoryID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.Users");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Slides");
            DropTable("dbo.Pages");
            DropTable("dbo.News");
            DropTable("dbo.Trailers");
            DropTable("dbo.Movies");
            DropTable("dbo.Footers");
            DropTable("dbo.Category");
            DropTable("dbo.Ads");
        }
    }
}
