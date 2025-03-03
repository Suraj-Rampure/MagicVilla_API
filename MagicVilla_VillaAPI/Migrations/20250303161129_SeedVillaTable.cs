﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vilas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "UpdatedDateTime", "sqft" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2025, 3, 3, 21, 41, 27, 618, DateTimeKind.Local).AddTicks(6116), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", "Royal Villa", 4, 200.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 550 },
                    { 2, "", new DateTime(2025, 3, 3, 21, 41, 27, 618, DateTimeKind.Local).AddTicks(6129), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", "Premium Pool Villa", 4, 300.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 550 },
                    { 3, "", new DateTime(2025, 3, 3, 21, 41, 27, 618, DateTimeKind.Local).AddTicks(6130), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg", "Luxury Pool Villa", 4, 400.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 750 },
                    { 4, "", new DateTime(2025, 3, 3, 21, 41, 27, 618, DateTimeKind.Local).AddTicks(6132), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg", "Diamond Villa", 4, 550.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 900 },
                    { 5, "", new DateTime(2025, 3, 3, 21, 41, 27, 618, DateTimeKind.Local).AddTicks(6133), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", "Diamond Pool Villa", 4, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
