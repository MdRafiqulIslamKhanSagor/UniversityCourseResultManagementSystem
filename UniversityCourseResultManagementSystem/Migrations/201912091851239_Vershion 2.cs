namespace UniversityCourseResultManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vershion2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentCode", c => c.String(nullable: false, maxLength: 7, unicode: false));
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "DepartmentCode", c => c.String(nullable: false, maxLength: 7));
        }
    }
}
