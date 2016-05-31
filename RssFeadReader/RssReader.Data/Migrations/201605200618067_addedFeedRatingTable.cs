namespace RssReader.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFeedRatingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeedRating",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100),
                        FeedTitle = c.String(nullable: false, maxLength: 200),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FeedRating");
        }
    }
}
