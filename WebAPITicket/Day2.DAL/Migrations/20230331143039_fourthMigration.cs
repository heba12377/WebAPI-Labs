using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTicket_Developers_IssuesId",
                table: "DeveloperTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTicket_Tickets_PatientsId",
                table: "DeveloperTicket");

            migrationBuilder.RenameColumn(
                name: "PatientsId",
                table: "DeveloperTicket",
                newName: "TicketsId");

            migrationBuilder.RenameColumn(
                name: "IssuesId",
                table: "DeveloperTicket",
                newName: "DevelopersId");

            migrationBuilder.RenameIndex(
                name: "IX_DeveloperTicket_PatientsId",
                table: "DeveloperTicket",
                newName: "IX_DeveloperTicket_TicketsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTicket_Developers_DevelopersId",
                table: "DeveloperTicket",
                column: "DevelopersId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTicket_Tickets_TicketsId",
                table: "DeveloperTicket",
                column: "TicketsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTicket_Developers_DevelopersId",
                table: "DeveloperTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTicket_Tickets_TicketsId",
                table: "DeveloperTicket");

            migrationBuilder.RenameColumn(
                name: "TicketsId",
                table: "DeveloperTicket",
                newName: "PatientsId");

            migrationBuilder.RenameColumn(
                name: "DevelopersId",
                table: "DeveloperTicket",
                newName: "IssuesId");

            migrationBuilder.RenameIndex(
                name: "IX_DeveloperTicket_TicketsId",
                table: "DeveloperTicket",
                newName: "IX_DeveloperTicket_PatientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTicket_Developers_IssuesId",
                table: "DeveloperTicket",
                column: "IssuesId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTicket_Tickets_PatientsId",
                table: "DeveloperTicket",
                column: "PatientsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
