using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace FindDuplicateEmployee
{
    public partial class EmployeeInformationContext : DbContext
    {
        public EmployeeInformationContext()
        {
        }

        public EmployeeInformationContext(DbContextOptions<EmployeeInformationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                ///* Get Connection string from appsetting Json file *///
                
                var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsetting.json");

                IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appsetting.json", true, true)
                    .Build();

                optionsBuilder.UseSqlServer(config["ConnectionString"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("numeric(18, 2)");
            });
        }
    }
}
