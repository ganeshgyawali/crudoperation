using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Management.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        public int Duration { get; set; }
        public string DurationType { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Status { get; set; }
    }
}