namespace MVC3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeptTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employee", "Departments_Id", c => c.Int());
            CreateIndex("dbo.Employee", "Departments_Id");
            AddForeignKey("dbo.Employee", "Departments_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Employee", "Departments_Id", "dbo.Departments");
            DropIndex("dbo.Employee", new[] { "Departments_Id" });
            DropColumn("dbo.Employee", "Departments_Id");
            DropTable("dbo.Departments");
        }
    }
}
