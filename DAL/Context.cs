using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EmployeeDB.db");
        }

        public Context()
            {
            /* Database.EnsureDeleted();
             Database.EnsureCreated();
             Database.Migrate();*/
           }
    }
}
