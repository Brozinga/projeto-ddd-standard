namespace FreelaControl.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NiveisdeAcesso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Status = c.Boolean(nullable: false),
                        DataAlteracao = c.DateTime(),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trabalhos",
                c => new
                    {
                        Titulo = c.String(nullable: false, maxLength: 100),
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false),
                        Prazo = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        ValorHora = c.Decimal(precision: 18, scale: 2),
                        ValorFechado = c.Decimal(precision: 18, scale: 2),
                        DataEntrega = c.DateTime(),
                        DataAlteracao = c.DateTime(),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Uploads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LinkUpload = c.String(nullable: false, maxLength: 255),
                        TrabalhoId = c.Guid(nullable: false),
                        Status = c.Boolean(nullable: false),
                        DataAlteracao = c.DateTime(),
                        DataCadastro = c.DateTime(nullable: false),
                        Trabalho_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trabalhos", t => t.TrabalhoId, cascadeDelete: true)
                .ForeignKey("dbo.Trabalhos", t => t.Trabalho_Id)
                .Index(t => t.TrabalhoId)
                .Index(t => t.Trabalho_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Identificador = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                        Senha = c.String(nullable: false, maxLength: 255),
                        NivelAcessoId = c.Int(nullable: false),
                        Rua = c.String(nullable: false, maxLength: 150),
                        Numero = c.String(nullable: false, maxLength: 50),
                        Bairro = c.String(nullable: false, maxLength: 100),
                        Cidade = c.String(nullable: false, maxLength: 100),
                        Estado = c.String(nullable: false, maxLength: 100),
                        Cep = c.String(nullable: false, maxLength: 50),
                        Complemento = c.String(maxLength: 150),
                        TelefoneUm = c.String(maxLength: 20),
                        TelefoneDois = c.String(maxLength: 20),
                        DataAlteracao = c.DateTime(),
                        Status = c.Boolean(),
                        DataCadastro = c.DateTime(nullable: false),
                        Nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NiveisdeAcesso", t => t.NivelAcessoId, cascadeDelete: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.NivelAcessoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "NivelAcessoId", "dbo.NiveisdeAcesso");
            DropForeignKey("dbo.Uploads", "Trabalho_Id", "dbo.Trabalhos");
            DropForeignKey("dbo.Uploads", "TrabalhoId", "dbo.Trabalhos");
            DropIndex("dbo.Usuarios", new[] { "NivelAcessoId" });
            DropIndex("dbo.Usuarios", new[] { "Email" });
            DropIndex("dbo.Uploads", new[] { "Trabalho_Id" });
            DropIndex("dbo.Uploads", new[] { "TrabalhoId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Uploads");
            DropTable("dbo.Trabalhos");
            DropTable("dbo.NiveisdeAcesso");
        }
    }
}
