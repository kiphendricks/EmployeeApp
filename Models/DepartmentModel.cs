using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
    public class DepartmentModel
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeeModel> Employees { get; set; }
    }
}