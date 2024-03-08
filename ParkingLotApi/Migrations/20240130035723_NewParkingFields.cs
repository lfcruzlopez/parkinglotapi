using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingLotApi.Migrations
{
    /// <inheritdoc />
    public partial class NewParkingFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "ParkingLots",
                newName: "HoursOperations");

            migrationBuilder.AddColumn<decimal>(
                name: "Latitud",
                table: "ParkingLots",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Longitud",
                table: "ParkingLots",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ParkingLots",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "ParkingLots");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "ParkingLots");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ParkingLots");

            migrationBuilder.RenameColumn(
                name: "HoursOperations",
                table: "ParkingLots",
                newName: "Location");
        }
    }
}
