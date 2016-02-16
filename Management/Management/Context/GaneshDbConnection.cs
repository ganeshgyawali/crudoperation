using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using Management.Models;

namespace Management.Context
{
    public class GaneshDbConnection:DbContext
    {
        public GaneshDbConnection() : base("DefaultConnection")
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; } 

    }
}