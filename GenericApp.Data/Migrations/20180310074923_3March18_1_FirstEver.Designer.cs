﻿// <auto-generated />
using GenericApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GenericApp.Data.Migrations
{
    [DbContext(typeof(GenericAppContext))]
    [Migration("20180310074923_3March18_1_FirstEver")]
    partial class _3March18_1_FirstEver
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GenericApp.Domain.Relationships.ManyToMany.ResponsibleRole_Task", b =>
                {
                    b.Property<int>("ResponsibleRoleId");

                    b.Property<int>("TaskId");

                    b.HasKey("ResponsibleRoleId", "TaskId");

                    b.HasIndex("TaskId");

                    b.ToTable("ResponsibleRole_Task");
                });

            modelBuilder.Entity("GenericApp.Domain.ResponsibleRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedBy");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Rowversion");

                    b.HasKey("Id");

                    b.ToTable("ResponsibleRole");
                });

            modelBuilder.Entity("GenericApp.Domain.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedBy");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Rowversion");

                    b.Property<int>("WorkflowId");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("GenericApp.Domain.TaskInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedBy");

                    b.Property<byte[]>("Rowversion");

                    b.Property<int>("TaskId");

                    b.Property<string>("TypeOfInput");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskInputs");
                });

            modelBuilder.Entity("GenericApp.Domain.TaskOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedBy");

                    b.Property<byte[]>("Rowversion");

                    b.Property<int>("TaskId");

                    b.Property<string>("TypeOfOutput");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskOutputs");
                });

            modelBuilder.Entity("GenericApp.Domain.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedBy");

                    b.Property<byte[]>("Rowversion");

                    b.Property<int>("TaskId");

                    b.Property<string>("TypeOfTask");

                    b.HasKey("Id");

                    b.HasIndex("TaskId")
                        .IsUnique();

                    b.ToTable("TaskTypes");
                });

            modelBuilder.Entity("GenericApp.Domain.Workflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("LastModifiedBy");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Rowversion");

                    b.HasKey("Id");

                    b.ToTable("Workflows");
                });

            modelBuilder.Entity("GenericApp.Domain.Relationships.ManyToMany.ResponsibleRole_Task", b =>
                {
                    b.HasOne("GenericApp.Domain.ResponsibleRole", "ResponsibleRole")
                        .WithMany("ResponsibleRole_Tasks")
                        .HasForeignKey("ResponsibleRoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GenericApp.Domain.Task", "Task")
                        .WithMany("ResponsibleRole_Tasks")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GenericApp.Domain.Task", b =>
                {
                    b.HasOne("GenericApp.Domain.Workflow", "Workflow")
                        .WithMany("WorkFlowTasks")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GenericApp.Domain.TaskInput", b =>
                {
                    b.HasOne("GenericApp.Domain.Task", "Task")
                        .WithMany("RequiredTaskInputs")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GenericApp.Domain.TaskOutput", b =>
                {
                    b.HasOne("GenericApp.Domain.Task", "Task")
                        .WithMany("ExpectedTaskOutputs")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GenericApp.Domain.TaskType", b =>
                {
                    b.HasOne("GenericApp.Domain.Task", "Task")
                        .WithOne("TaskType")
                        .HasForeignKey("GenericApp.Domain.TaskType", "TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
