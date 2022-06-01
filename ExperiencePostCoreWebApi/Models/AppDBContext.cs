using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExperiencePostCoreWebApi.Models
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
