namespace AbcStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTwoPropertiesForImage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        Kategorija = c.String(),
                        Cijena = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articles");
        }
    }
}
