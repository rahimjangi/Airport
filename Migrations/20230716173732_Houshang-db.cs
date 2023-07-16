using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airport.Migrations
{
    /// <inheritdoc />
    public partial class Houshangdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_loyaltyPrograms",
                schema: "air",
                table: "loyaltyPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pricingAndAvailabilities",
                schema: "air",
                table: "pricingAndAvailabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payments",
                schema: "air",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                schema: "air",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                schema: "air",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "BookingId",
                schema: "air",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                schema: "air",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "AircraftId",
                schema: "air",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                schema: "air",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "DepartureAirportId",
                schema: "air",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "DestinationAirportId",
                schema: "air",
                table: "Flights");

            migrationBuilder.RenameTable(
                name: "loyaltyPrograms",
                schema: "air",
                newName: "LoyaltyPrograms",
                newSchema: "air");

            migrationBuilder.RenameTable(
                name: "pricingAndAvailabilities",
                schema: "air",
                newName: "PricingAndAvailability",
                newSchema: "air");

            migrationBuilder.RenameTable(
                name: "payments",
                schema: "air",
                newName: "Payment",
                newSchema: "air");

            migrationBuilder.RenameTable(
                name: "Passengers",
                schema: "air",
                newName: "Passenger",
                newSchema: "air");

            migrationBuilder.RenameTable(
                name: "Flights",
                schema: "air",
                newName: "Flight",
                newSchema: "air");

            migrationBuilder.RenameColumn(
                name: "Type",
                schema: "air",
                table: "Aircrafts",
                newName: "RegistrationNumber");

            migrationBuilder.RenameColumn(
                name: "SeatingCapacity",
                schema: "air",
                table: "Aircrafts",
                newName: "TotalSeats");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "air",
                table: "Passenger",
                newName: "SeatNumber");

            migrationBuilder.RenameColumn(
                name: "ContactDetails",
                schema: "air",
                table: "Passenger",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "DepartureTime",
                schema: "air",
                table: "Flight",
                newName: "ScheduledDepartureTime");

            migrationBuilder.RenameColumn(
                name: "ArrivalTime",
                schema: "air",
                table: "Flight",
                newName: "ScheduledArrivalTime");

            migrationBuilder.AddColumn<string>(
                name: "BaggageStatus",
                schema: "air",
                table: "Baggages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BaggageTagNumber",
                schema: "air",
                table: "Baggages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FlightNumber",
                schema: "air",
                table: "Baggages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PassengerName",
                schema: "air",
                table: "Baggages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrackingNumber",
                schema: "air",
                table: "Baggages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeightUnit",
                schema: "air",
                table: "Baggages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AircraftCode",
                schema: "air",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AircraftModel",
                schema: "air",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CountryOfOriginId",
                schema: "air",
                table: "Aircrafts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentLocationId",
                schema: "air",
                table: "Aircrafts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ManufacturingDate",
                schema: "air",
                table: "Aircrafts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "air",
                table: "Passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "CurrentLatitude",
                schema: "air",
                table: "Passenger",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CurrentLongitude",
                schema: "air",
                table: "Passenger",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                schema: "air",
                table: "Passenger",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "air",
                table: "Passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "air",
                table: "Passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FlightNumber",
                schema: "air",
                table: "Passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "air",
                table: "Passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                schema: "air",
                table: "Passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                schema: "air",
                table: "Passenger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualArrivalTime",
                schema: "air",
                table: "Flight",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ActualDepartureTime",
                schema: "air",
                table: "Flight",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ArrivalGate",
                schema: "air",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalTerminal",
                schema: "air",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartureGate",
                schema: "air",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartureTerminal",
                schema: "air",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FlightNumber",
                schema: "air",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FlightStatus",
                schema: "air",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoyaltyPrograms",
                schema: "air",
                table: "LoyaltyPrograms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PricingAndAvailability",
                schema: "air",
                table: "PricingAndAvailability",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                schema: "air",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passenger",
                schema: "air",
                table: "Passenger",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flight",
                schema: "air",
                table: "Flight",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AccessibilityFeature",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibilityFeature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccessibilityOption",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessibilityFeatureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibilityOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirportAmenity",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirportServiceId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirportAmenity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirportContact",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirportContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirportLocation",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirportLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaggageStatusUpdate",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaggageStatusUpdate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardingPass",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoardingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCheckedIn = table.Column<bool>(type: "bit", nullable: false),
                    IsBoarded = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardingPass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckInRequest",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckInRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlightNotificatione",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipientUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightNotificatione", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MapRoute",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartLocationId = table.Column<int>(type: "int", nullable: false),
                    EndLocationId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceInMeters = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapRoute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassengerLocation",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityCheckpoint",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumCapacity = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityCheckpoint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityWaitTime",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityCheckpointId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WaitTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    NumberOfPeopleInQueue = table.Column<int>(type: "int", nullable: false),
                    EstimatedWaitTime = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityWaitTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translation",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportationOption",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickUpLocations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatingHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportationOption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportationProvider",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportationProvider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportationUpdate",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportationProviderId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Schedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisruptionDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportationUpdate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "air",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "air",
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_CountryOfOriginId",
                schema: "air",
                table: "Aircrafts",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_CurrentLocationId",
                schema: "air",
                table: "Aircrafts",
                column: "CurrentLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                schema: "air",
                table: "City",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_City_CurrentLocationId",
                schema: "air",
                table: "Aircrafts",
                column: "CurrentLocationId",
                principalSchema: "air",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Country_CountryOfOriginId",
                schema: "air",
                table: "Aircrafts",
                column: "CountryOfOriginId",
                principalSchema: "air",
                principalTable: "Country",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_City_CurrentLocationId",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Country_CountryOfOriginId",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropTable(
                name: "AccessibilityFeature",
                schema: "air");

            migrationBuilder.DropTable(
                name: "AccessibilityOption",
                schema: "air");

            migrationBuilder.DropTable(
                name: "AirportAmenity",
                schema: "air");

            migrationBuilder.DropTable(
                name: "AirportContact",
                schema: "air");

            migrationBuilder.DropTable(
                name: "AirportLocation",
                schema: "air");

            migrationBuilder.DropTable(
                name: "BaggageStatusUpdate",
                schema: "air");

            migrationBuilder.DropTable(
                name: "BoardingPass",
                schema: "air");

            migrationBuilder.DropTable(
                name: "CheckInRequest",
                schema: "air");

            migrationBuilder.DropTable(
                name: "City",
                schema: "air");

            migrationBuilder.DropTable(
                name: "FlightNotificatione",
                schema: "air");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "air");

            migrationBuilder.DropTable(
                name: "MapRoute",
                schema: "air");

            migrationBuilder.DropTable(
                name: "PassengerLocation",
                schema: "air");

            migrationBuilder.DropTable(
                name: "SecurityCheckpoint",
                schema: "air");

            migrationBuilder.DropTable(
                name: "SecurityWaitTime",
                schema: "air");

            migrationBuilder.DropTable(
                name: "Translation",
                schema: "air");

            migrationBuilder.DropTable(
                name: "TransportationOption",
                schema: "air");

            migrationBuilder.DropTable(
                name: "TransportationProvider",
                schema: "air");

            migrationBuilder.DropTable(
                name: "TransportationUpdate",
                schema: "air");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "air");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoyaltyPrograms",
                schema: "air",
                table: "LoyaltyPrograms");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_CountryOfOriginId",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_CurrentLocationId",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PricingAndAvailability",
                schema: "air",
                table: "PricingAndAvailability");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                schema: "air",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passenger",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flight",
                schema: "air",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "BaggageStatus",
                schema: "air",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "BaggageTagNumber",
                schema: "air",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "FlightNumber",
                schema: "air",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "PassengerName",
                schema: "air",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "TrackingNumber",
                schema: "air",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "WeightUnit",
                schema: "air",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "AircraftCode",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "AircraftModel",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "CountryOfOriginId",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "CurrentLocationId",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "ManufacturingDate",
                schema: "air",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "Address",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "CurrentLatitude",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "CurrentLongitude",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "FlightNumber",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "Nationality",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                schema: "air",
                table: "Passenger");

            migrationBuilder.DropColumn(
                name: "ActualArrivalTime",
                schema: "air",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "ActualDepartureTime",
                schema: "air",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "ArrivalGate",
                schema: "air",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "ArrivalTerminal",
                schema: "air",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "DepartureGate",
                schema: "air",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "DepartureTerminal",
                schema: "air",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "FlightNumber",
                schema: "air",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "FlightStatus",
                schema: "air",
                table: "Flight");

            migrationBuilder.RenameTable(
                name: "LoyaltyPrograms",
                schema: "air",
                newName: "loyaltyPrograms",
                newSchema: "air");

            migrationBuilder.RenameTable(
                name: "PricingAndAvailability",
                schema: "air",
                newName: "pricingAndAvailabilities",
                newSchema: "air");

            migrationBuilder.RenameTable(
                name: "Payment",
                schema: "air",
                newName: "payments",
                newSchema: "air");

            migrationBuilder.RenameTable(
                name: "Passenger",
                schema: "air",
                newName: "Passengers",
                newSchema: "air");

            migrationBuilder.RenameTable(
                name: "Flight",
                schema: "air",
                newName: "Flights",
                newSchema: "air");

            migrationBuilder.RenameColumn(
                name: "TotalSeats",
                schema: "air",
                table: "Aircrafts",
                newName: "SeatingCapacity");

            migrationBuilder.RenameColumn(
                name: "RegistrationNumber",
                schema: "air",
                table: "Aircrafts",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "SeatNumber",
                schema: "air",
                table: "Passengers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Phone",
                schema: "air",
                table: "Passengers",
                newName: "ContactDetails");

            migrationBuilder.RenameColumn(
                name: "ScheduledDepartureTime",
                schema: "air",
                table: "Flights",
                newName: "DepartureTime");

            migrationBuilder.RenameColumn(
                name: "ScheduledArrivalTime",
                schema: "air",
                table: "Flights",
                newName: "ArrivalTime");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                schema: "air",
                table: "Baggages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassengerId",
                schema: "air",
                table: "Baggages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AircraftId",
                schema: "air",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                schema: "air",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartureAirportId",
                schema: "air",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestinationAirportId",
                schema: "air",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_loyaltyPrograms",
                schema: "air",
                table: "loyaltyPrograms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pricingAndAvailabilities",
                schema: "air",
                table: "pricingAndAvailabilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payments",
                schema: "air",
                table: "payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                schema: "air",
                table: "Passengers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                schema: "air",
                table: "Flights",
                column: "Id");
        }
    }
}
