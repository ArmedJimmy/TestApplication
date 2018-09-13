using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.Data.Migrations
{
    public partial class SeedingTablesAndAddingExplicitFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolments_Addresses_SupplyAddressId",
                table: "Enrolments");

            migrationBuilder.DropIndex(
                name: "IX_Enrolments_SupplyAddressId",
                table: "Enrolments");

            migrationBuilder.DropColumn(
                name: "SupplyAddressId",
                table: "Enrolments");

            migrationBuilder.AddColumn<int>(
                name: "SupplyAddress_Id",
                table: "Enrolments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "DateCreated", "DateUpdated", "HouseName", "HouseNumber", "Postcode", "StreetName" },
                values: new object[] { 1, "Glasgow", new DateTime(2018, 9, 13, 20, 8, 24, 360, DateTimeKind.Local), new DateTime(2018, 9, 13, 20, 8, 24, 364, DateTimeKind.Local), null, "16", "G53 7HJ", "Main Road" });

            migrationBuilder.InsertData(
                table: "Enrolments",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Status", "SupplyAddress_Id" },
                values: new object[] { 1, new DateTime(2018, 9, 13, 20, 8, 24, 369, DateTimeKind.Local), new DateTime(2018, 9, 13, 20, 8, 24, 369, DateTimeKind.Local), 0, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Enrolments_SupplyAddress_Id",
                table: "Enrolments",
                column: "SupplyAddress_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolments_Addresses_SupplyAddress_Id",
                table: "Enrolments",
                column: "SupplyAddress_Id",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolments_Addresses_SupplyAddress_Id",
                table: "Enrolments");

            migrationBuilder.DropIndex(
                name: "IX_Enrolments_SupplyAddress_Id",
                table: "Enrolments");

            migrationBuilder.DeleteData(
                table: "Enrolments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "SupplyAddress_Id",
                table: "Enrolments");

            migrationBuilder.AddColumn<int>(
                name: "SupplyAddressId",
                table: "Enrolments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrolments_SupplyAddressId",
                table: "Enrolments",
                column: "SupplyAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolments_Addresses_SupplyAddressId",
                table: "Enrolments",
                column: "SupplyAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
