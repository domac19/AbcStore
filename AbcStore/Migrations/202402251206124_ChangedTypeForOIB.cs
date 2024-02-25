namespace AbcStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTypeForOIB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persons", "OIB", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persons", "OIB", c => c.Int(nullable: false));
        }
    }
}
