namespace AbcStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Articles", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "Image", c => c.Binary());
        }
    }
}
