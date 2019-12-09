namespace UniversityCourseResultManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vershion3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "CreatedDate", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.Departments", "CreatedBy", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Departments", "ModifiedDate", c => c.String(maxLength: 20, unicode: false));
            AlterColumn("dbo.Departments", "ModifiedBy", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "ModifiedBy", c => c.String());
            AlterColumn("dbo.Departments", "ModifiedDate", c => c.String());
            AlterColumn("dbo.Departments", "CreatedBy", c => c.String());
            AlterColumn("dbo.Departments", "CreatedDate", c => c.String());
        }
    }
}
