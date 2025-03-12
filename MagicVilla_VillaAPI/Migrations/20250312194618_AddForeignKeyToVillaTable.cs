using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VilaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 1, 16, 15, 724, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 1, 16, 15, 724, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 1, 16, 15, 724, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 1, 16, 15, 724, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 1, 16, 15, 724, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.CreateIndex(
                name: "IX_VilaNumbers_VillaId",
                table: "VilaNumbers",
                column: "VillaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VilaNumbers_Vilas_VillaId",
                table: "VilaNumbers",
                column: "VillaId",
                principalTable: "Vilas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VilaNumbers_Vilas_VillaId",
                table: "VilaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VilaNumbers_VillaId",
                table: "VilaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VilaNumbers");

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 18, 56, 30, 543, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 18, 56, 30, 543, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 18, 56, 30, 543, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 18, 56, 30, 543, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Vilas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 12, 18, 56, 30, 543, DateTimeKind.Local).AddTicks(1262));
        }
    }
}
