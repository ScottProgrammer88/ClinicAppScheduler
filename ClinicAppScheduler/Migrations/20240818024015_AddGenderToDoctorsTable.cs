using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicAppScheduler.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderToDoctorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Doctors",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Doctors");
        }
    }
}
