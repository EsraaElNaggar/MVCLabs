namespace MVC3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelDept : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employee", name: "Departments_Id", newName: "FK_DepartmentsID");
            RenameIndex(table: "dbo.Employee", name: "IX_Departments_Id", newName: "IX_FK_DepartmentsID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employee", name: "IX_FK_DepartmentsID", newName: "IX_Departments_Id");
            RenameColumn(table: "dbo.Employee", name: "FK_DepartmentsID", newName: "Departments_Id");
        }
    }
}
