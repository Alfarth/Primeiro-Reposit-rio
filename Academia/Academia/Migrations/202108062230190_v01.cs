namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Pessoas",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(maxLength: 50),
                        Modalidade = c.String(),
                        Modalidade1 = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CPF);
            
            CreateTable(
                "public.Modalidades",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
        
        public override void Down()
        {
            DropTable("public.Modalidades");
            DropTable("public.Pessoas");
        }
    }
}
