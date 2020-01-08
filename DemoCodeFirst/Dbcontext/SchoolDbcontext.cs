using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DemoCodeFirst.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace DemoCodeFirst.Dbcontext
{
    public class SchoolDbcontext:DbContext
    {
        public SchoolDbcontext() : base("schoolDb")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<SchoolDbcontext>());
            Database.SetInitializer(new SchoolDbinitializer());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Studentaddress> Studentaddresses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("Admin");
            //modelBuilder.Entity<Student>().ToTable("studentInfo");
            //modelBuilder.Entity<Course>().ToTable("Courses", "dbo");
            //modelBuilder.Entity<Student>().Map(m =>
            //{
            //    m.Properties(p => new { p.Id, p.Name });
            //    m.ToTable("Studentinfo");
            //}).Map(m => {
            //    m.Properties(p => new { p.Id,p.Dob});
            //    m.ToTable("Studentinfodetails");
            //});
            //modelBuilder.Entity<Student>().Map(delegate (EntityMappingConfiguration<Student> configuration)
            //{
            //    configuration.Properties(p => new { p.Id, p.Name });
            //    configuration.ToTable("Studentinfo");
            //});
            //Action<EntityMappingConfiguration<Student>> model = m =>
            //  {
            //      m.Properties(p => new { p.Id, p.Name });
            //      m.ToTable("Students");
            //  };
            //modelBuilder.Entity<Student>().Map(model);
            // modelBuilder.Entity<Student>().HasKey<int>(p => p.Id);
            //create composite key using Two fields
            //modelBuilder.Entity<Student>().HasKey(p => new { p.Id, p.Deapartmentid })
            //    .Property(p => p.Dob)
            //    .HasColumnName("Dateofbirth")
            //    .HasColumnOrder(3)
            //    .HasColumnType("datetime2")
            //    .IsOptional();
            //modelBuilder.Entity<Student>()
            //    .Property(p => p.Name)
            //    .IsFixedLength();
            //modelBuilder.Entity<Student>()
            //    .Property(p => p.Id)
            //    .HasPrecision(2,2);

            //modelBuilder.Entity<Student>().HasRequired(s => s.Studentaddress)
            //   .WithRequiredPrincipal(r => r.Student);
            // one to one and zero
            modelBuilder.Entity<Student>().HasOptional(s => s.Studentaddress)
            .WithRequired(r => r.Student);
            //one to many
            //modelBuilder.Entity<Student>().HasRequired<Department>(s => s.Department)
            //    .WithMany(d => d.students)
            //    .HasForeignKey<int>(s => s.Deapartmentid);
            /// Many to many
                


        }
    }
}