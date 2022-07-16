using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    public partial class EditTest_ReceptionTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receptions_Tests_TestId",
                table: "Receptions");

            migrationBuilder.DropIndex(
                name: "IX_Receptions_TestId",
                table: "Receptions");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Receptions");

            migrationBuilder.AddColumn<long>(
                name: "ReceptionId",
                table: "Tests",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ReseptionId",
                table: "Tests",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ReceptionId",
                table: "Tests",
                column: "ReceptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Receptions_ReceptionId",
                table: "Tests",
                column: "ReceptionId",
                principalTable: "Receptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Receptions_ReceptionId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_ReceptionId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "ReceptionId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "ReseptionId",
                table: "Tests");

            migrationBuilder.AddColumn<long>(
                name: "TestId",
                table: "Receptions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Receptions_TestId",
                table: "Receptions",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receptions_Tests_TestId",
                table: "Receptions",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
