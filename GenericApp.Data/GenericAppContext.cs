using Tasks.Domain;
using Tasks.Domain.Relationships.ManyToMany;
using Microsoft.EntityFrameworkCore;
using System;

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
        public DbSet<ResponsibleRole_Task> ResponsibleRole_Tasks { get; set; }
        #endregion
                

        public GenericAppContext(DbContextOptions<GenericAppContext> options)
            :base (options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workflow>().ToTable(name: "Workflow", schema: "Task");
            modelBuilder.Entity<ResponsibleRole>().ToTable(name: "ResponsibleRole", schema: "Task");
            modelBuilder.Entity<Task>().ToTable(name: "Task", schema: "Task");
            modelBuilder.Entity<TaskType>().ToTable(name: "TaskType", schema: "Task");
            modelBuilder.Entity<TaskInput>().ToTable(name: "TaskInput", schema: "Task");
            modelBuilder.Entity<TaskOutput>().ToTable(name: "TaskOutput", schema: "Task");

            modelBuilder.Entity<ResponsibleRole_Task>().ToTable(name: "ResponsibleRole_Task", schema: "ManyToMany");          

            modelBuilder.Entity<ResponsibleRole_Task>()
                .HasKey(k => new { k.ResponsibleRoleId, k.TaskId });

     

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                //modelBuilder.Entity(entityType.Name).Property<bool>("IsDeleted");
                modelBuilder.Entity(entityType.Name).Ignore("IsDirty");

                modelBuilder.Entity(entityType.Name).Property<byte>("Rowversion").IsRowVersion().ValueGeneratedOnAddOrUpdate();
                modelBuilder.Entity(entityType.Name).Property<DateTime>("Created").ValueGeneratedOnAdd();
                modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModified").ValueGeneratedOnAddOrUpdate();
            }

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer
            //    (
            //        "Server = DESKTOP-8E34R4N\\SQLEXPRESS; Database = GenericDB; Trusted_Connection = True;"
            //    );
            //optionsBuilder.EnableSensitiveDataLogging(); // remove this later.
            //base.OnConfiguring(optionsBuilder); This does nothing.
        }
    }
}
