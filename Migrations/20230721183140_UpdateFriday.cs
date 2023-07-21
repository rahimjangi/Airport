using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airport.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFriday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessibilityFeatureId",
                schema: "air",
                table: "AccessibilityOption");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "air",
                table: "TransportationUpdate",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "TransportationUpdateStatus",
                schema: "air",
                table: "TransportationUpdate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SecurityStatus",
                schema: "air",
                table: "SecurityWaitTime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "air",
                table: "BaggageStatusUpdate",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "BaggageStatus",
                schema: "air",
                table: "BaggageStatusUpdate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportationUpdateStatus",
                schema: "air",
                table: "TransportationUpdate");

            migrationBuilder.DropColumn(
                name: "SecurityStatus",
                schema: "air",
                table: "SecurityWaitTime");

            migrationBuilder.DropColumn(
                name: "BaggageStatus",
                schema: "air",
                table: "BaggageStatusUpdate");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                schema: "air",
                table: "TransportationUpdate",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                schema: "air",
                table: "BaggageStatusUpdate",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AccessibilityFeatureId",
                schema: "air",
                table: "AccessibilityOption",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
