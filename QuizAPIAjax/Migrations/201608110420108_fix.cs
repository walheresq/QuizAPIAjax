namespace QuizAPIAjax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cursoes", "Estudiante_Id", "dbo.Estudiantes");
            DropIndex("dbo.Cursoes", new[] { "Estudiante_Id" });
            DropColumn("dbo.Cursoes", "IdEstudiante");
            DropColumn("dbo.Cursoes", "Estudiante_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cursoes", "Estudiante_Id", c => c.Int());
            AddColumn("dbo.Cursoes", "IdEstudiante", c => c.Int(nullable: false));
            CreateIndex("dbo.Cursoes", "Estudiante_Id");
            AddForeignKey("dbo.Cursoes", "Estudiante_Id", "dbo.Estudiantes", "Id");
        }
    }
}
