using EmployeeApi.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Designation> Designation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

       
            modelBuilder.Entity<EmployeeModel>()
                .HasOne(e => e.Department)
                .WithMany()
                .HasForeignKey(e => e.IdDepartment)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → Section
            modelBuilder.Entity<EmployeeModel>()
                .HasOne(e => e.Section)
                .WithMany()
                .HasForeignKey(e => e.IdSection)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → Designation
            modelBuilder.Entity<EmployeeModel>()
                .HasOne(e => e.Designation)
                .WithMany()
                .HasForeignKey(e => e.IdDesignation)
                .OnDelete(DeleteBehavior.Restrict);

            // 🔐 Multi-tenant safety index
            modelBuilder.Entity<EmployeeModel>()
                .HasIndex(e => new { e.IdClient, e.Id });
        }
    }
}
