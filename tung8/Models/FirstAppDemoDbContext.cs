using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tung8.Models;

namespace tung8.data
{
    public class FirstAppDemoDbContext: DbContext
    {
        public FirstAppDemoDbContext()
        {
        }

        public FirstAppDemoDbContext(DbContextOptions<FirstAppDemoDbContext> options)
       : base(options)
        { }
        public DbSet<Employee> Employees { get; set; }
    }
}
