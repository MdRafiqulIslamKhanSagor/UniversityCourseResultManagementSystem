using System.Collections.Generic;
using UniversityCourseResultManagementSystem.Models;

namespace UniversityCourseResultManagementSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversityCourseResultManagementSystem.Models.ProjectDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UniversityCourseResultManagementSystem.Models.ProjectDBContext context)
        {
            if (!context.Semisters.Any())
            {
                var semisters = new List<Semister>
                {
                    new Semister { SemesterName = "Afghanistan" },
                    new Semister { SemesterName = "Albania" }
                   
                };
               
                context.SaveChanges();
            }
        }
    }
}
