using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GenericApp.Data.Migrations
{
    public partial class _3March18_1_FirstEver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ManyToMany");

            migrationBuilder.EnsureSchema(
                name: "Task");

            migrationBuilder.EnsureSchema(
                name: "Workflow");

            migrationBuilder.CreateTable(
                name: "ResponsibleRole",
                schema: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rowversion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibleRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workflow",
                schema: "Workflow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rowversion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                schema: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rowversion = table.Column<byte[]>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    WorkflowId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalSchema: "Workflow",
                        principalTable: "Workflow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibleRole_Task",
                schema: "ManyToMany",
                columns: table => new
                {
                    ResponsibleRoleId = table.Column<int>(nullable: false),
                    TaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibleRole_Task", x => new { x.ResponsibleRoleId, x.TaskId });
                    table.ForeignKey(
                        name: "FK_ResponsibleRole_Task_ResponsibleRole_ResponsibleRoleId",
                        column: x => x.ResponsibleRoleId,
                        principalSchema: "Task",
                        principalTable: "ResponsibleRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponsibleRole_Task_Task_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "Task",
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskInput",
                schema: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Rowversion = table.Column<byte[]>(nullable: true),
                    TaskId = table.Column<int>(nullable: false),
                    TypeOfInput = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskInput", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskInput_Task_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "Task",
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskOutput",
                schema: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Rowversion = table.Column<byte[]>(nullable: true),
                    TaskId = table.Column<int>(nullable: false),
                    TypeOfOutput = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskOutput", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskOutput_Task_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "Task",
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskType",
                schema: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Rowversion = table.Column<byte[]>(nullable: true),
                    TaskId = table.Column<int>(nullable: false),
                    TypeOfTask = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskType_Task_TaskId",
                        column: x => x.TaskId,
                        principalSchema: "Task",
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibleRole_Task_TaskId",
                schema: "ManyToMany",
                table: "ResponsibleRole_Task",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_WorkflowId",
                schema: "Task",
                table: "Task",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskInput_TaskId",
                schema: "Task",
                table: "TaskInput",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskOutput_TaskId",
                schema: "Task",
                table: "TaskOutput",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskType_TaskId",
                schema: "Task",
                table: "TaskType",
                column: "TaskId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponsibleRole_Task",
                schema: "ManyToMany");

            migrationBuilder.DropTable(
                name: "TaskInput",
                schema: "Task");

            migrationBuilder.DropTable(
                name: "TaskOutput",
                schema: "Task");

            migrationBuilder.DropTable(
                name: "TaskType",
                schema: "Task");

            migrationBuilder.DropTable(
                name: "ResponsibleRole",
                schema: "Task");

            migrationBuilder.DropTable(
                name: "Task",
                schema: "Task");

            migrationBuilder.DropTable(
                name: "Workflow",
                schema: "Workflow");
        }
    }
}
