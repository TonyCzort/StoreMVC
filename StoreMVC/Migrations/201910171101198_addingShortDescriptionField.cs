namespace StoreMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingShortDescriptionField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "ShortDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "ShortDescription");
        }
    }
}
