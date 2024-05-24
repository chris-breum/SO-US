using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace So_Us.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Tasks_TaskId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "EmployeeTask");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Medicines",
                newName: "AssignmentTaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_TaskId",
                table: "Medicines",
                newName: "IX_Medicines_AssignmentTaskId");

            migrationBuilder.CreateTable(
                name: "AssignmentEmployee",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    TasksTaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentEmployee", x => new { x.EmployeesEmployeeId, x.TasksTaskId });
                    table.ForeignKey(
                        name: "FK_AssignmentEmployee_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignmentEmployee_Tasks_TasksTaskId",
                        column: x => x.TasksTaskId,
                        principalTable: "Tasks",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentEmployee_TasksTaskId",
                table: "AssignmentEmployee",
                column: "TasksTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Tasks_AssignmentTaskId",
                table: "Medicines",
                column: "AssignmentTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Tasks_AssignmentTaskId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "AssignmentEmployee");

            migrationBuilder.RenameColumn(
                name: "AssignmentTaskId",
                table: "Medicines",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_AssignmentTaskId",
                table: "Medicines",
                newName: "IX_Medicines_TaskId");

            migrationBuilder.CreateTable(
                name: "EmployeeTask",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    TasksTaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTask", x => new { x.EmployeesEmployeeId, x.TasksTaskId });
                    table.ForeignKey(
                        name: "FK_EmployeeTask_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTask_Tasks_TasksTaskId",
                        column: x => x.TasksTaskId,
                        principalTable: "Tasks",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTask_TasksTaskId",
                table: "EmployeeTask",
                column: "TasksTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Tasks_TaskId",
                table: "Medicines",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");
        }
    }
}
