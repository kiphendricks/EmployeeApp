using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Models
{
    public class EmployeeAppContext : DbContext
    {
        public EmployeeAppContext (DbContextOptions<EmployeeAppContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeApp.Models.DepartmentModel> Department { get; set; }
        public DbSet<EmployeeApp.Models.EmployeeModel> Employee { get; set; }
    }
}