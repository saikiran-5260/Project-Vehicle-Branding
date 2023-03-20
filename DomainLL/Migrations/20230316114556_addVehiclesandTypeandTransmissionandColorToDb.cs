using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Branding.Migrations
{
    /// <inheritdoc />
    public partial class addVehiclesandTypeandTransmissionandColorToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicleAndTypeAndTransmissionAndColors",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    VehicleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIN_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelCapacity = table.Column<int>(type: "int", nullable: false),
                    FuelReserveCapacity = table.Column<int>(type: "int", nullable: false),
                    MilegePerLiter = table.Column<int>(type: "int", nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    Vehicle_Transmission_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vehicle_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vehicle_Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicleAndTypeAndTransmissionAndColors");
        }
    }
}
