using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAppScheduler.Migrations
{
    /// <inheritdoc />
    public partial class InputDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "EmailAddress", "FullName", "Gender", "LicenseNumber" },
                values: new object[,]
                {
                    { 1, "smith1@yahoo.com", "Dr.J Smith", "F", "ABC123456" },
                    { 2, "indianajones@gmail.com", "Dr.Robert Jones", "M", "DEF789101" },
                    { 3, "blackwidow@yahoo.com", "Dr.Scarlett Johansson", "F", "GHI904710" },
                    { 4, "ironman@comcast.com", "Dr.Tony S", "M", "JKL220035" },
                    { 5, "price@yahoo.com", "Dr.Chloe Price", "F", "MNO010101" },
                    { 6, "scarers@gmail.com", "Dr.Mike Wasoski", "M", "PQR246810" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 6);
        }
    }
}
