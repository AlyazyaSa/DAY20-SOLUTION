using DAY20.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAY20.MYdbContext
{
    internal class ApplicationdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-OH39326H\\MSSQLSERVER01;Initial Catalog=EmployeeCompany;Integrated Security=True");
        }
           public DbSet<Employee> Employees {get; set;}
          public DbSet<Department> Department { get; set; }
 

    }
}
