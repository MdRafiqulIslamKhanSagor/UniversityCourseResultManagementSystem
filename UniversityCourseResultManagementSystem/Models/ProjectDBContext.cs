﻿using System;
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
        public DbSet<CourseAssign> CourseAssign { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Student> Students { get; set; }




    }
}