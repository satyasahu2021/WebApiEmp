using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiEmp.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal? Salary { get; set; }
    }
}
