using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityCourseResultManagementSystem.Models
{
    public class ProjectDBContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Semister> Semisters { get; set; }

        public System.Data.Entity.DbSet<UniversityCourseResultManagementSystem.Models.Teacher> Teachers { get; set; }

        public System.Data.Entity.DbSet<UniversityCourseResultManagementSystem.Models.Designation> Designations { get; set; }
    }
}