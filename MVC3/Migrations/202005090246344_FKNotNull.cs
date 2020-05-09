namespace MVC3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKNotNull : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employee", "FK_DepartmentsID", "dbo.Departments");
            DropIndex("dbo.Employee", new[] { "FK_DepartmentsID" });
            AlterColumn("dbo.Employee", "FK_DepartmentsID", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "FK_DepartmentsID");
            AddForeignKey("dbo.Employee", "FK_DepartmentsID", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "FK_DepartmentsID", "dbo.Departments");
            DropIndex("dbo.Employee", new[] { "FK_DepartmentsID" });
            AlterColumn("dbo.Employee", "FK_DepartmentsID", c => c.Int());
            CreateIndex("dbo.Employee", "FK_DepartmentsID");
            AddForeignKey("dbo.Employee", "FK_DepartmentsID", "dbo.Departments", "Id");
        }
    }
}
