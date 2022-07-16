using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    public partial class EditTest_ReceptionTBLV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Receptions_ReceptionId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "ReseptionId",
                table: "Tests");

            migrationBuilder.AlterColumn<long>(
                name: "ReceptionId",
                table: "Tests",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Receptions_ReceptionId",
                table: "Tests",
                column: "ReceptionId",
                principalTable: "Receptions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Receptions_ReceptionId",
                table: "Tests");

            migrationBuilder.AlterColumn<long>(
                name: "ReceptionId",
                table: "Tests",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ReseptionId",
                table: "Tests",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Receptions_ReceptionId",
                table: "Tests",
                column: "ReceptionId",
                principalTable: "Receptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
