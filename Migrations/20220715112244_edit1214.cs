using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    public partial class edit1214 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "Receptions");

            migrationBuilder.DropColumn(
                name: "InsuranceName",
                table: "Receptions");

            migrationBuilder.DropColumn(
                name: "PatientName",
                table: "Receptions");

            migrationBuilder.AddColumn<long>(
                name: "DoctorId",
                table: "Receptions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "InsuranceId",
                table: "Receptions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PatientId",
                table: "Receptions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Receptions_DoctorId",
                table: "Receptions",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptions_InsuranceId",
                table: "Receptions",
                column: "InsuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptions_PatientId",
                table: "Receptions",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receptions_Doctors_DoctorId",
                table: "Receptions",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receptions_Insurances_InsuranceId",
                table: "Receptions",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receptions_Patients_PatientId",
                table: "Receptions",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receptions_Doctors_DoctorId",
                table: "Receptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Receptions_Insurances_InsuranceId",
                table: "Receptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Receptions_Patients_PatientId",
                table: "Receptions");

            migrationBuilder.DropIndex(
                name: "IX_Receptions_DoctorId",
                table: "Receptions");

            migrationBuilder.DropIndex(
                name: "IX_Receptions_InsuranceId",
                table: "Receptions");

            migrationBuilder.DropIndex(
                name: "IX_Receptions_PatientId",
                table: "Receptions");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Receptions");

            migrationBuilder.DropColumn(
                name: "InsuranceId",
                table: "Receptions");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Receptions");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "Receptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InsuranceName",
                table: "Receptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PatientName",
                table: "Receptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
