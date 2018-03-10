﻿using GenericApp.Domain;
using GenericApp.Domain.Relationships.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace GenericApp.Data
{
    public class GenericAppContext : DbContext
    {

        #region Workflow Tables
        public DbSet<Workflow> Workflows { get; set; }
        #endregion

        #region Task Tables
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<TaskInput> TaskInputs { get; set; }
        public DbSet<TaskOutput> TaskOutputs { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResponsibleRole_Task>()
                .HasKey(k => new { k.ResponsibleRoleId, k.TaskId });

            //modelBuilder.Entity<Task>()
            //    .Property(p => p.TaskType).IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (
                    "Server = DESKTOP-8E34R4N\\SQLEXPRESS; Database = GenericDB; Trusted_Connection = True;"
                );
            //base.OnConfiguring(optionsBuilder); This does nothing.
        }
    }
}
