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

    }
}