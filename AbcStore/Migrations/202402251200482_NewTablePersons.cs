namespace AbcStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTablePersons : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Email = c.String(),
                        OIB = c.Int(nullable: false),
                        KorisnikId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persons");
        }
    }
}
