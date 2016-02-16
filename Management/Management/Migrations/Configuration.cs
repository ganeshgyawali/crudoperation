using System.Collections;
using System.Collections.Generic;
using Management.Models;

namespace Management.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Management.Context.GaneshDbConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Management.Context.GaneshDbConnection context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Course> courseList = new List<Course>()
            {
                new Course()
                {
                   Name = "asp.net",
                   Description = "asp.net",
                   Fees = 2000,
                   Duration = 9,
                   DurationType = "Week",
                   AddedDate = DateTime.Now,
                     ModifiedDate = null,
                     Status = true


                  
      
                    
                },
            new Course()
               {
                Name = "advance java",
                   Description = "advance java",
                   Fees = 2000,
                   Duration = 9,
                   DurationType = "Week",
                   AddedDate = DateTime.Now,
                     ModifiedDate = null,
                     Status = true
            },
            new Course()
               {
                Name = "Adroid",
                   Description = "android",
                   Fees = 2000,
                   Duration = 9,
                   DurationType = "Week",
                   AddedDate = DateTime.Now,
                     ModifiedDate = null,
                     Status = true 
                   
            }
            };
            courseList.ForEach(c =>
            {
                context.Courses.Add(c);
                context.SaveChanges();
            });
        }
    }
}
