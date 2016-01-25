namespace CadastroDeClienteSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Empresa = c.String(),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                        Site = c.String(),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
