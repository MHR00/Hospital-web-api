using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Migrations
{
    public partial class edit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctersId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctersId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctersId",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "PatientsId",
                table: "Doctors",
                newName: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PatientId",
                table: "Doctors",
                column: "PatientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Patients_PatientId",
                table: "Doctors",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Patients_PatientId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_PatientId",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Doctors",
                newName: "PatientsId");

            migrationBuilder.AddColumn<long>(
                name: "DoctersId",
                table: "Patients",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctersId",
                table: "Patients",
                column: "DoctersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctersId",
                table: "Patients",
                column: "DoctersId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
