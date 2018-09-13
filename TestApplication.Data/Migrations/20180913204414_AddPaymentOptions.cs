using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.Data.Migrations
{
    public partial class AddPaymentOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CardType = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    CardName = table.Column<string>(nullable: true),
                    ValidUntil = table.Column<DateTime>(nullable: false),
                    Enrolment_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentOptions_Enrolments_Enrolment_Id",
                        column: x => x.Enrolment_Id,
                        principalTable: "Enrolments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2018, 9, 13, 21, 44, 14, 438, DateTimeKind.Local), new DateTime(2018, 9, 13, 21, 44, 14, 439, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Enrolments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2018, 9, 13, 21, 44, 14, 439, DateTimeKind.Local), new DateTime(2018, 9, 13, 21, 44, 14, 439, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "PaymentOptions",
                columns: new[] { "Id", "CardName", "CardNumber", "CardType", "DateCreated", "DateUpdated", "Enrolment_Id", "ValidUntil" },
                values: new object[] { 1, "Test User", "1234123412341234", "VISA", new DateTime(2018, 9, 13, 21, 44, 14, 440, DateTimeKind.Local), new DateTime(2018, 9, 13, 21, 44, 14, 440, DateTimeKind.Local), 1, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentOptions_Enrolment_Id",
                table: "PaymentOptions",
                column: "Enrolment_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentOptions");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2018, 9, 13, 20, 8, 24, 360, DateTimeKind.Local), new DateTime(2018, 9, 13, 20, 8, 24, 364, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Enrolments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2018, 9, 13, 20, 8, 24, 369, DateTimeKind.Local), new DateTime(2018, 9, 13, 20, 8, 24, 369, DateTimeKind.Local) });
        }
    }
}
