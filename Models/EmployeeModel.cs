using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public int DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }

    }
}