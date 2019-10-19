namespace StoreMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class caegryPictureRenamer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "CategoryPictureName", c => c.String());
            DropColumn("dbo.Category", "CategoryPcitureName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "CategoryPcitureName", c => c.String());
            DropColumn("dbo.Category", "CategoryPictureName");
        }
    }
}
