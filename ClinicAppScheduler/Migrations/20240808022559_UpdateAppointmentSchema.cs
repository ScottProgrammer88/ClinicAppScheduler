using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAppScheduler.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAppointmentSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApointmentTime",
                table: "Appointments",
                newName: "AppointmentTime");

            migrationBuilder.RenameColumn(
                name: "ApointmentDate",
                table: "Appointments",
                newName: "AppointmentDate");

            migrationBuilder.RenameColumn(
                name: "ApointmentId",
                table: "Appointments",
                newName: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentTime",
                table: "Appointments",
                newName: "ApointmentTime");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Appointments",
                newName: "ApointmentDate");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "Appointments",
                newName: "ApointmentId");
        }
    }
}
