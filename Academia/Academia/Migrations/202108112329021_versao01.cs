namespace Academia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Pessoas",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(maxLength: 50),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Modalidade_IdModalidade = c.Int(),
                        Modalidade_IdModalidade1 = c.Int(),
                    })
                .PrimaryKey(t => t.CPF)
                .ForeignKey("public.Modalidades", t => t.Modalidade_IdModalidade)
                .ForeignKey("public.Modalidades", t => t.Modalidade_IdModalidade1)
                .Index(t => t.Modalidade_IdModalidade)
                .Index(t => t.Modalidade_IdModalidade1);
            
            CreateTable(
                "public.Modalidades",
                c => new
                    {
                        IdModalidade = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.IdModalidade);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Pessoas", "Modalidade_IdModalidade1", "public.Modalidades");
            DropForeignKey("public.Pessoas", "Modalidade_IdModalidade", "public.Modalidades");
            DropIndex("public.Pessoas", new[] { "Modalidade_IdModalidade1" });
            DropIndex("public.Pessoas", new[] { "Modalidade_IdModalidade" });
            DropTable("public.Modalidades");
            DropTable("public.Pessoas");
        }
    }
}
