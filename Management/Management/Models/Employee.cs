using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Management.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public DateTime JoinedDate { get; set; }

        public string Salary { get; set; }
        public bool Status { get; set; }
    }
}