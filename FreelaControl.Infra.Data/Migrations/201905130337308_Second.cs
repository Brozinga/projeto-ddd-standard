namespace FreelaControl.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Uploads", "TrabalhoId", "dbo.Trabalhos");
            DropIndex("dbo.Uploads", new[] { "TrabalhoId" });
            DropIndex("dbo.Uploads", new[] { "Trabalho_Id" });
            DropColumn("dbo.Uploads", "Trabalho_Id");
            RenameColumn(table: "dbo.Uploads", name: "TrabalhoId", newName: "Trabalho_Id");
            AlterColumn("dbo.Uploads", "Trabalho_Id", c => c.Guid());
            CreateIndex("dbo.Uploads", "Trabalho_Id");
            AddForeignKey("dbo.Uploads", "Trabalho_Id", "dbo.Trabalhos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uploads", "Trabalho_Id", "dbo.Trabalhos");
            DropIndex("dbo.Uploads", new[] { "Trabalho_Id" });
            AlterColumn("dbo.Uploads", "Trabalho_Id", c => c.Guid(nullable: false));
            RenameColumn(table: "dbo.Uploads", name: "Trabalho_Id", newName: "TrabalhoId");
            AddColumn("dbo.Uploads", "Trabalho_Id", c => c.Guid());
            CreateIndex("dbo.Uploads", "Trabalho_Id");
            CreateIndex("dbo.Uploads", "TrabalhoId");
            AddForeignKey("dbo.Uploads", "TrabalhoId", "dbo.Trabalhos", "Id", cascadeDelete: true);
        }
    }
}
