using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTicket_tickets_PatientsId",
                table: "DeveloperTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_tickets_Departments_DepartmentId",
                table: "tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tickets",
                table: "tickets");

            migrationBuilder.RenameTable(
                name: "tickets",
                newName: "Tickets");

            migrationBuilder.RenameIndex(
                name: "IX_tickets_DepartmentId",
                table: "Tickets",
                newName: "IX_Tickets_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTicket_Tickets_PatientsId",
                table: "DeveloperTicket",
                column: "PatientsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Departments_DepartmentId",
                table: "Tickets",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTicket_Tickets_PatientsId",
                table: "DeveloperTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Departments_DepartmentId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "tickets");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_DepartmentId",
                table: "tickets",
                newName: "IX_tickets_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tickets",
                table: "tickets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTicket_tickets_PatientsId",
                table: "DeveloperTicket",
                column: "PatientsId",
                principalTable: "tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_Departments_DepartmentId",
                table: "tickets",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
