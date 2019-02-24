namespace Sinco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artiMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        codigo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articuloes");
        }
    }
}
