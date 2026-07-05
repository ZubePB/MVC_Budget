using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Budget.Migrations
{
    /// <inheritdoc />
    public partial class addRecurrence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_BusinessCategories_CategoryId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_BusinessSuppliers_SupplierId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "BusinessCategories");

            migrationBuilder.DropTable(
                name: "BusinessSuppliers");

            migrationBuilder.AddColumn<bool>(
                name: "Recurrent",
                table: "Transactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTransaction = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTransaction = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "NumberOfTransaction", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Wood", 100, 1991.1300000000001 },
                    { 2, "Aluminium", 100, 2145.9699999999998 },
                    { 3, "Iron", 100, 2204.8299999999999 },
                    { 4, "Stainless Steel", 100, 2266.98 },
                    { 5, "Screws", 100, 2326.6599999999999 },
                    { 6, "Wood Tools", 100, 2076.6199999999999 },
                    { 7, "Door Accessories", 100, 2071.27 },
                    { 8, "Glass", 100, 2333.8800000000001 },
                    { 9, "Metal Tools", 100, 1979.6900000000001 },
                    { 10, "Glass Accessories", 100, 2154.23 }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Name", "NumberOfTransaction", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Glasson", 300, 6617.7799999999997 },
                    { 2, "Bauhaus", 200, 4056.3099999999999 },
                    { 3, "Scierie de Romont", 100, 1991.1300000000001 },
                    { 4, "Sofraver SA", 200, 4488.1099999999997 },
                    { 5, "Commerce de Fer Fribourgeois", 200, 4397.9300000000003 }
                });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.350000000000001, new DateTime(2026, 7, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.8500000000000001, new DateTime(2026, 7, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 54.93, new DateTime(2026, 7, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.880000000000001, new DateTime(2026, 7, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.559999999999999, new DateTime(2026, 7, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.890000000000001, new DateTime(2026, 7, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.059999999999999, new DateTime(2026, 7, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.9700000000000006, new DateTime(2026, 7, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.57, new DateTime(2026, 7, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.1999999999999993, new DateTime(2026, 7, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.210000000000001, new DateTime(2026, 7, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.44, new DateTime(2026, 7, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.75, new DateTime(2026, 7, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.239999999999998, new DateTime(2026, 7, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 62.700000000000003, new DateTime(2026, 7, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 80.299999999999997, new DateTime(2026, 7, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.369999999999999, new DateTime(2026, 7, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.530000000000001, new DateTime(2026, 7, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.710000000000001, new DateTime(2026, 7, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.170000000000002, new DateTime(2026, 7, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.7799999999999998, new DateTime(2026, 7, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.3700000000000001, new DateTime(2026, 7, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 78.349999999999994, new DateTime(2026, 7, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.5899999999999999, new DateTime(2026, 7, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.380000000000001, new DateTime(2026, 7, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.060000000000002, new DateTime(2026, 7, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.909999999999997, new DateTime(2026, 7, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.96, new DateTime(2026, 7, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 48.909999999999997, new DateTime(2026, 7, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.27, new DateTime(2026, 7, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.18, new DateTime(2026, 7, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.120000000000001, new DateTime(2026, 7, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.379999999999999, new DateTime(2026, 7, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.9399999999999999, new DateTime(2026, 7, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.530000000000001, new DateTime(2026, 7, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.850000000000001, new DateTime(2026, 7, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.390000000000001, new DateTime(2026, 7, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.16, new DateTime(2026, 7, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.5700000000000003, new DateTime(2026, 7, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.530000000000001, new DateTime(2026, 7, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.6500000000000004, new DateTime(2026, 7, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.960000000000001, new DateTime(2026, 7, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.440000000000001, new DateTime(2026, 7, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.4400000000000004, new DateTime(2026, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.460000000000001, new DateTime(2026, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.039999999999999, new DateTime(2026, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.35, new DateTime(2026, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.3700000000000001, new DateTime(2026, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.399999999999999, new DateTime(2026, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.890000000000001, new DateTime(2026, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.3099999999999996, new DateTime(2026, 7, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.399999999999999, new DateTime(2026, 7, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "Recurrent" },
                values: new object[] { new DateTime(2026, 7, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.920000000000002, new DateTime(2026, 7, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.8300000000000001, new DateTime(2026, 7, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 30.890000000000001, new DateTime(2026, 7, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.030000000000001, new DateTime(2026, 8, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.0099999999999998, new DateTime(2026, 8, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.6099999999999994, new DateTime(2026, 8, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.579999999999998, new DateTime(2026, 8, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 33.329999999999998, new DateTime(2026, 8, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.199999999999999, new DateTime(2026, 8, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 41.880000000000003, new DateTime(2026, 8, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.8399999999999999, new DateTime(2026, 8, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.970000000000001, new DateTime(2026, 8, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.809999999999999, new DateTime(2026, 8, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.02, new DateTime(2026, 8, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.31, new DateTime(2026, 8, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.8099999999999996, new DateTime(2026, 8, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.470000000000001, new DateTime(2026, 8, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.23, new DateTime(2026, 8, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 64.049999999999997, new DateTime(2026, 8, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 57.810000000000002, new DateTime(2026, 8, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 57.759999999999998, new DateTime(2026, 8, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 37.390000000000001, new DateTime(2026, 8, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.539999999999999, new DateTime(2026, 8, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.800000000000001, new DateTime(2026, 8, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.460000000000001, new DateTime(2026, 8, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.6500000000000004, new DateTime(2026, 8, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.559999999999999, new DateTime(2026, 8, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.7400000000000002, new DateTime(2026, 8, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.739999999999998, new DateTime(2026, 8, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.77, new DateTime(2026, 8, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.4199999999999999, new DateTime(2026, 8, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.539999999999999, new DateTime(2026, 8, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.48, new DateTime(2026, 8, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.28, new DateTime(2026, 8, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 56.359999999999999, new DateTime(2026, 8, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.3700000000000001, new DateTime(2026, 8, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.67, new DateTime(2026, 8, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 43.149999999999999, new DateTime(2026, 8, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.559999999999999, new DateTime(2026, 8, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 47.270000000000003, new DateTime(2026, 8, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.579999999999998, new DateTime(2026, 8, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.8899999999999999, new DateTime(2026, 8, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.9400000000000004, new DateTime(2026, 8, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.859999999999999, new DateTime(2026, 8, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.149999999999999, new DateTime(2026, 8, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.48, new DateTime(2026, 8, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.48, new DateTime(2026, 8, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.1200000000000001, new DateTime(2026, 8, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.6600000000000001, new DateTime(2026, 8, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.189999999999998, new DateTime(2026, 8, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 40.460000000000001, new DateTime(2026, 8, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.75, new DateTime(2026, 8, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.299999999999997, new DateTime(2026, 8, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.75, new DateTime(2026, 8, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.9500000000000002, new DateTime(2026, 8, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.800000000000001, new DateTime(2026, 8, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.1500000000000004, new DateTime(2026, 8, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.760000000000002, new DateTime(2026, 8, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.4900000000000002, new DateTime(2026, 8, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.32, new DateTime(2026, 8, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.6399999999999997, new DateTime(2026, 8, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.129999999999999, new DateTime(2026, 8, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.7400000000000002, new DateTime(2026, 8, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.559999999999999, new DateTime(2026, 8, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.1699999999999999, new DateTime(2026, 8, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.48, new DateTime(2026, 9, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.120000000000001, new DateTime(2026, 9, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.32, new DateTime(2026, 9, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.469999999999999, new DateTime(2026, 9, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.970000000000001, new DateTime(2026, 9, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.99, new DateTime(2026, 9, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.4199999999999999, new DateTime(2026, 9, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.0, new DateTime(2026, 9, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.6699999999999999, new DateTime(2026, 9, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.039999999999999, new DateTime(2026, 9, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.19, new DateTime(2026, 9, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.449999999999999, new DateTime(2026, 9, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.880000000000001, new DateTime(2026, 9, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 70.450000000000003, new DateTime(2026, 9, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.93, new DateTime(2026, 9, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.640000000000001, new DateTime(2026, 9, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.85, new DateTime(2026, 9, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.3499999999999996, new DateTime(2026, 9, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.4100000000000001, new DateTime(2026, 9, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.9699999999999998, new DateTime(2026, 9, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.670000000000002, new DateTime(2026, 9, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.75, new DateTime(2026, 9, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.600000000000001, new DateTime(2026, 9, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.609999999999999, new DateTime(2026, 9, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.3300000000000001, new DateTime(2026, 9, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.050000000000001, new DateTime(2026, 9, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.52, new DateTime(2026, 9, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 42.109999999999999, new DateTime(2026, 9, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.989999999999998, new DateTime(2026, 9, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.32, new DateTime(2026, 9, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.329999999999998, new DateTime(2026, 9, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 41.93, new DateTime(2026, 9, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.25, new DateTime(2026, 9, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.1099999999999999, new DateTime(2026, 9, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.579999999999998, new DateTime(2026, 9, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.75, new DateTime(2026, 9, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.9500000000000002, new DateTime(2026, 9, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.550000000000001, new DateTime(2026, 9, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.5599999999999996, new DateTime(2026, 9, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.989999999999998, new DateTime(2026, 9, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.1599999999999999, new DateTime(2026, 9, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.030000000000001, new DateTime(2026, 9, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 60.659999999999997, new DateTime(2026, 9, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.1500000000000004, new DateTime(2026, 9, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.81, new DateTime(2026, 9, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.539999999999999, new DateTime(2026, 9, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.46, new DateTime(2026, 9, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.670000000000002, new DateTime(2026, 9, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.829999999999998, new DateTime(2026, 9, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.1100000000000003, new DateTime(2026, 9, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.710000000000001, new DateTime(2026, 9, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.739999999999998, new DateTime(2026, 9, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.26, new DateTime(2026, 9, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 33.560000000000002, new DateTime(2026, 9, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.859999999999999, new DateTime(2026, 9, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.199999999999999, new DateTime(2026, 9, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.5199999999999996, new DateTime(2026, 9, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.3300000000000001, new DateTime(2026, 9, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.16, new DateTime(2026, 9, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.8599999999999999, new DateTime(2026, 9, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.69, new DateTime(2026, 9, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.510000000000002, new DateTime(2026, 9, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.600000000000001, new DateTime(2026, 9, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.030000000000001, new DateTime(2026, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 47.049999999999997, new DateTime(2026, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.16, new DateTime(2026, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 47.539999999999999, new DateTime(2026, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.0800000000000001, new DateTime(2026, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.050000000000001, new DateTime(2026, 9, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.44, new DateTime(2026, 10, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.119999999999997, new DateTime(2026, 10, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.720000000000001, new DateTime(2026, 10, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.949999999999999, new DateTime(2026, 10, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 42.829999999999998, new DateTime(2026, 10, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.0, new DateTime(2026, 10, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.3799999999999999, new DateTime(2026, 10, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.289999999999999, new DateTime(2026, 10, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.379999999999999, new DateTime(2026, 10, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.439999999999998, new DateTime(2026, 10, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 64.170000000000002, new DateTime(2026, 10, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.0300000000000002, new DateTime(2026, 10, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.640000000000001, new DateTime(2026, 10, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.79, new DateTime(2026, 10, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.199999999999999, new DateTime(2026, 10, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.120000000000001, new DateTime(2026, 10, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 76.079999999999998, new DateTime(2026, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.43, new DateTime(2026, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.1200000000000001, new DateTime(2026, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.690000000000001, new DateTime(2026, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.78, new DateTime(2026, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.809999999999999, new DateTime(2026, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 75.900000000000006, new DateTime(2026, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 44.719999999999999, new DateTime(2026, 10, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.81, new DateTime(2026, 10, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 59.829999999999998, new DateTime(2026, 10, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 66.730000000000004, new DateTime(2026, 10, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 30.75, new DateTime(2026, 10, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 55.030000000000001, new DateTime(2026, 10, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.690000000000001, new DateTime(2026, 10, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.350000000000001, new DateTime(2026, 10, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.1400000000000001, new DateTime(2026, 10, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.720000000000001, new DateTime(2026, 10, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.859999999999999, new DateTime(2026, 10, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.780000000000001, new DateTime(2026, 10, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.4400000000000004, new DateTime(2026, 10, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.799999999999997, new DateTime(2026, 10, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.300000000000001, new DateTime(2026, 10, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.469999999999999, new DateTime(2026, 10, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.550000000000001, new DateTime(2026, 10, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.73, new DateTime(2026, 10, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.210000000000001, new DateTime(2026, 10, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 43.390000000000001, new DateTime(2026, 10, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.030000000000001, new DateTime(2026, 10, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.84, new DateTime(2026, 10, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.09, new DateTime(2026, 10, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.6399999999999997, new DateTime(2026, 10, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.560000000000002, new DateTime(2026, 10, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.59, new DateTime(2026, 10, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.199999999999999, new DateTime(2026, 10, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.29, new DateTime(2026, 10, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.800000000000001, new DateTime(2026, 10, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.829999999999998, new DateTime(2026, 10, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.220000000000001, new DateTime(2026, 10, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.649999999999999, new DateTime(2026, 10, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.039999999999999, new DateTime(2026, 10, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.949999999999999, new DateTime(2026, 10, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.5199999999999996, new DateTime(2026, 10, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.460000000000001, new DateTime(2026, 10, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.7000000000000002, new DateTime(2026, 10, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.7599999999999998, new DateTime(2026, 10, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.039999999999999, new DateTime(2026, 10, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 60.119999999999997, new DateTime(2026, 10, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 46.07, new DateTime(2026, 10, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.48, new DateTime(2026, 10, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 81.0, new DateTime(2026, 10, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 67.590000000000003, new DateTime(2026, 10, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 53.25, new DateTime(2026, 10, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.969999999999999, new DateTime(2026, 10, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.870000000000001, new DateTime(2026, 10, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 41.810000000000002, new DateTime(2026, 10, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.9499999999999993, new DateTime(2026, 10, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.280000000000001, new DateTime(2026, 10, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.789999999999999, new DateTime(2026, 10, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.15, new DateTime(2026, 11, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.91, new DateTime(2026, 11, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.280000000000001, new DateTime(2026, 11, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.260000000000002, new DateTime(2026, 11, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.649999999999999, new DateTime(2026, 11, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 48.0, new DateTime(2026, 11, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.94, new DateTime(2026, 11, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.02, new DateTime(2026, 11, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.940000000000001, new DateTime(2026, 11, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.690000000000001, new DateTime(2026, 11, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.27, new DateTime(2026, 11, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.57, new DateTime(2026, 11, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.899999999999999, new DateTime(2026, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.2200000000000006, new DateTime(2026, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.2199999999999998, new DateTime(2026, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.41, new DateTime(2026, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.73, new DateTime(2026, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.4700000000000006, new DateTime(2026, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.949999999999999, new DateTime(2026, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 57.289999999999999, new DateTime(2026, 11, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.51, new DateTime(2026, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.379999999999999, new DateTime(2026, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.219999999999999, new DateTime(2026, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.8500000000000001, new DateTime(2026, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.329999999999998, new DateTime(2026, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.869999999999999, new DateTime(2026, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 30.940000000000001, new DateTime(2026, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.039999999999999, new DateTime(2026, 11, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.2300000000000004, new DateTime(2026, 11, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.66, new DateTime(2026, 11, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 72.920000000000002, new DateTime(2026, 11, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 43.210000000000001, new DateTime(2026, 11, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.1600000000000001, new DateTime(2026, 11, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.65, new DateTime(2026, 11, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.8199999999999998, new DateTime(2026, 11, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.960000000000001, new DateTime(2026, 11, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.7199999999999998, new DateTime(2026, 11, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.470000000000001, new DateTime(2026, 11, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.46, new DateTime(2026, 11, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.640000000000001, new DateTime(2026, 11, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.670000000000002, new DateTime(2026, 11, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.050000000000001, new DateTime(2026, 11, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.27, new DateTime(2026, 11, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.449999999999999, new DateTime(2026, 11, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.869999999999999, new DateTime(2026, 11, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.789999999999999, new DateTime(2026, 11, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.1699999999999999, new DateTime(2026, 11, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.6500000000000004, new DateTime(2026, 11, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.1399999999999997, new DateTime(2026, 11, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.109999999999999, new DateTime(2026, 11, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.949999999999999, new DateTime(2026, 11, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.02, new DateTime(2026, 11, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.420000000000002, new DateTime(2026, 11, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.3899999999999999, new DateTime(2026, 11, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.399999999999999, new DateTime(2026, 11, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.48, new DateTime(2026, 11, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.66, new DateTime(2026, 11, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.670000000000002, new DateTime(2026, 11, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.18, new DateTime(2026, 11, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 37.439999999999998, new DateTime(2026, 11, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 55.729999999999997, new DateTime(2026, 11, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.5600000000000001, new DateTime(2026, 11, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.9, new DateTime(2026, 11, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.43, new DateTime(2026, 11, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.67, new DateTime(2026, 11, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.300000000000001, new DateTime(2026, 11, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.0399999999999991, new DateTime(2026, 11, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.5199999999999996, new DateTime(2026, 11, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.550000000000001, new DateTime(2026, 11, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 74.599999999999994, new DateTime(2026, 11, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.1400000000000001, new DateTime(2026, 11, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.25, new DateTime(2026, 12, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.8200000000000003, new DateTime(2026, 12, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.300000000000001, new DateTime(2026, 12, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.43, new DateTime(2026, 12, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.620000000000001, new DateTime(2026, 12, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.57, new DateTime(2026, 12, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.789999999999999, new DateTime(2026, 12, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.1699999999999999, new DateTime(2026, 12, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.25, new DateTime(2026, 12, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.809999999999999, new DateTime(2026, 12, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 53.439999999999998, new DateTime(2026, 12, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.02, new DateTime(2026, 12, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 42.950000000000003, new DateTime(2026, 12, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.2400000000000002, new DateTime(2026, 12, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.4299999999999997, new DateTime(2026, 12, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.559999999999999, new DateTime(2026, 12, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.059999999999999, new DateTime(2026, 12, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.17, new DateTime(2026, 12, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.6, new DateTime(2026, 12, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.9500000000000002, new DateTime(2026, 12, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.96, new DateTime(2026, 12, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.25, new DateTime(2026, 12, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.3300000000000001, new DateTime(2026, 12, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.140000000000001, new DateTime(2026, 12, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.9199999999999999, new DateTime(2026, 12, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.559999999999999, new DateTime(2026, 12, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.059999999999999, new DateTime(2026, 12, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.390000000000001, new DateTime(2026, 12, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 52.0, new DateTime(2026, 12, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.020000000000003, new DateTime(2026, 12, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 37.109999999999999, new DateTime(2026, 12, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.840000000000003, new DateTime(2026, 12, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.359999999999999, new DateTime(2026, 12, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.4100000000000001, new DateTime(2026, 12, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.02, new DateTime(2026, 12, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.469999999999999, new DateTime(2026, 12, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.1699999999999999, new DateTime(2026, 12, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.879999999999999, new DateTime(2026, 12, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.619999999999999, new DateTime(2026, 12, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.300000000000001, new DateTime(2026, 12, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.3499999999999996, new DateTime(2026, 12, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.649999999999999, new DateTime(2026, 12, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.060000000000002, new DateTime(2026, 12, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 37.829999999999998, new DateTime(2026, 12, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.050000000000001, new DateTime(2026, 12, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.899999999999999, new DateTime(2026, 12, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.09, new DateTime(2026, 12, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 37.490000000000002, new DateTime(2026, 12, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 41.950000000000003, new DateTime(2026, 12, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.02, new DateTime(2026, 12, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.66, new DateTime(2026, 12, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.26, new DateTime(2026, 12, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.6600000000000001, new DateTime(2026, 12, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.399999999999999, new DateTime(2026, 12, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 42.399999999999999, new DateTime(2026, 12, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.369999999999999, new DateTime(2027, 1, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 42.380000000000003, new DateTime(2027, 1, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.710000000000001, new DateTime(2027, 1, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.920000000000002, new DateTime(2027, 1, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.199999999999999, new DateTime(2027, 1, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.1200000000000001, new DateTime(2027, 1, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.460000000000001, new DateTime(2027, 1, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 76.260000000000005, new DateTime(2027, 1, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.01, new DateTime(2027, 1, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.780000000000001, new DateTime(2027, 1, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.300000000000001, new DateTime(2027, 1, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.240000000000002, new DateTime(2027, 1, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 57.189999999999998, new DateTime(2027, 1, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.289999999999999, new DateTime(2027, 1, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.779999999999999, new DateTime(2027, 1, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 91.670000000000002, new DateTime(2027, 1, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.609999999999999, new DateTime(2027, 1, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.32, new DateTime(2027, 1, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.52, new DateTime(2027, 1, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.950000000000003, new DateTime(2027, 1, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.2400000000000002, new DateTime(2027, 1, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 56.240000000000002, new DateTime(2027, 1, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.2699999999999996, new DateTime(2027, 1, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.4600000000000009, new DateTime(2027, 1, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.48, new DateTime(2027, 1, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.7599999999999998, new DateTime(2027, 1, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 42.18, new DateTime(2027, 1, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.879999999999999, new DateTime(2027, 1, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.0, new DateTime(2027, 1, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.8899999999999997, new DateTime(2027, 1, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.33, new DateTime(2027, 1, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.289999999999999, new DateTime(2027, 1, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.379999999999999, new DateTime(2027, 1, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.299999999999997, new DateTime(2027, 1, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.54, new DateTime(2027, 1, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.3600000000000003, new DateTime(2027, 1, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.81, new DateTime(2027, 1, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.280000000000001, new DateTime(2027, 1, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.220000000000001, new DateTime(2027, 1, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.7100000000000009, new DateTime(2027, 1, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.600000000000001, new DateTime(2027, 1, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.870000000000001, new DateTime(2027, 1, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.219999999999999, new DateTime(2027, 1, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.6299999999999999, new DateTime(2027, 1, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 40.159999999999997, new DateTime(2027, 1, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.0499999999999998, new DateTime(2027, 1, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.379999999999999, new DateTime(2027, 1, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.8900000000000006, new DateTime(2027, 1, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.199999999999999, new DateTime(2027, 1, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.5500000000000007, new DateTime(2027, 1, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 67.329999999999998, new DateTime(2027, 1, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.699999999999999, new DateTime(2027, 1, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.02, new DateTime(2027, 1, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.5700000000000003, new DateTime(2027, 1, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.7200000000000006, new DateTime(2027, 1, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.4700000000000002, new DateTime(2027, 1, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.030000000000001, new DateTime(2027, 1, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.869999999999999, new DateTime(2027, 1, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.7599999999999998, new DateTime(2027, 1, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.670000000000002, new DateTime(2027, 1, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.5, new DateTime(2027, 1, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.91, new DateTime(2027, 1, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.4600000000000009, new DateTime(2027, 1, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.54, new DateTime(2027, 1, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.31, new DateTime(2027, 2, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.3699999999999992, new DateTime(2027, 2, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 54.859999999999999, new DateTime(2027, 2, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.32, new DateTime(2027, 2, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 50.710000000000001, new DateTime(2027, 2, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 44.490000000000002, new DateTime(2027, 2, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.739999999999998, new DateTime(2027, 2, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.530000000000001, new DateTime(2027, 2, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.3300000000000001, new DateTime(2027, 2, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.170000000000002, new DateTime(2027, 2, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.090000000000003, new DateTime(2027, 2, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.590000000000003, new DateTime(2027, 2, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 30.140000000000001, new DateTime(2027, 2, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.539999999999999, new DateTime(2027, 2, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.3099999999999996, new DateTime(2027, 2, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.7000000000000002, new DateTime(2027, 2, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.02, new DateTime(2027, 2, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.549999999999997, new DateTime(2027, 2, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.7999999999999998, new DateTime(2027, 2, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.6200000000000001, new DateTime(2027, 2, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 49.43, new DateTime(2027, 2, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.140000000000001, new DateTime(2027, 2, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.350000000000001, new DateTime(2027, 2, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.84, new DateTime(2027, 2, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.68, new DateTime(2027, 2, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.949999999999999, new DateTime(2027, 2, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.3099999999999996, new DateTime(2027, 2, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.07, new DateTime(2027, 2, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.210000000000001, new DateTime(2027, 2, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.27, new DateTime(2027, 2, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.740000000000002, new DateTime(2027, 2, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.5, new DateTime(2027, 2, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.77, new DateTime(2027, 2, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.210000000000001, new DateTime(2027, 2, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.780000000000001, new DateTime(2027, 2, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.4000000000000004, new DateTime(2027, 2, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.530000000000001, new DateTime(2027, 2, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.779999999999999, new DateTime(2027, 2, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.8899999999999997, new DateTime(2027, 2, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.720000000000001, new DateTime(2027, 2, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.8899999999999997, new DateTime(2027, 2, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.880000000000001, new DateTime(2027, 2, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 31.23, new DateTime(2027, 2, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.77, new DateTime(2027, 2, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.81, new DateTime(2027, 2, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.469999999999999, new DateTime(2027, 2, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.5, new DateTime(2027, 2, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.07, new DateTime(2027, 3, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.27, new DateTime(2027, 3, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.2400000000000002, new DateTime(2027, 3, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.4900000000000002, new DateTime(2027, 3, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.9199999999999999, new DateTime(2027, 3, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.73, new DateTime(2027, 3, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.120000000000001, new DateTime(2027, 3, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.289999999999999, new DateTime(2027, 3, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 66.599999999999994, new DateTime(2027, 3, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 31.23, new DateTime(2027, 3, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.649999999999999, new DateTime(2027, 3, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.1299999999999999, new DateTime(2027, 3, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.529999999999999, new DateTime(2027, 3, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 40.030000000000001, new DateTime(2027, 3, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.6099999999999999, new DateTime(2027, 3, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.039999999999999, new DateTime(2027, 3, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.09, new DateTime(2027, 3, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.390000000000001, new DateTime(2027, 3, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 64.689999999999998, new DateTime(2027, 3, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.4699999999999998, new DateTime(2027, 3, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.309999999999999, new DateTime(2027, 3, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 58.609999999999999, new DateTime(2027, 3, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.0399999999999991, new DateTime(2027, 3, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.280000000000001, new DateTime(2027, 3, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.15, new DateTime(2027, 3, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.079999999999998, new DateTime(2027, 3, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 60.899999999999999, new DateTime(2027, 3, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 41.07, new DateTime(2027, 3, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 44.020000000000003, new DateTime(2027, 3, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.1099999999999999, new DateTime(2027, 3, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.67, new DateTime(2027, 3, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.759999999999998, new DateTime(2027, 3, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.41, new DateTime(2027, 3, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 76.769999999999996, new DateTime(2027, 3, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.52, new DateTime(2027, 3, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.490000000000002, new DateTime(2027, 3, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.649999999999999, new DateTime(2027, 3, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.4000000000000004, new DateTime(2027, 3, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.59, new DateTime(2027, 3, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 83.099999999999994, new DateTime(2027, 3, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.6699999999999999, new DateTime(2027, 3, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.619999999999999, new DateTime(2027, 3, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.760000000000002, new DateTime(2027, 3, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.23, new DateTime(2027, 3, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.779999999999999, new DateTime(2027, 3, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.65, new DateTime(2027, 3, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 73.620000000000005, new DateTime(2027, 3, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.49, new DateTime(2027, 3, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.609999999999999, new DateTime(2027, 3, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.42, new DateTime(2027, 3, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.77, new DateTime(2027, 3, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 33.280000000000001, new DateTime(2027, 3, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.6400000000000006, new DateTime(2027, 4, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.3900000000000001, new DateTime(2027, 4, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.6900000000000004, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.0699999999999998, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.520000000000003, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.940000000000001, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.3099999999999996, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.2000000000000002, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 47.189999999999998, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.9399999999999999, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.399999999999999, new DateTime(2027, 4, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.73, new DateTime(2027, 4, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.09, new DateTime(2027, 4, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.390000000000001, new DateTime(2027, 4, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.7300000000000004, new DateTime(2027, 4, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 31.649999999999999, new DateTime(2027, 4, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.74, new DateTime(2027, 4, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.07, new DateTime(2027, 4, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.329999999999998, new DateTime(2027, 4, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 44.5, new DateTime(2027, 4, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.960000000000001, new DateTime(2027, 4, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.559999999999999, new DateTime(2027, 4, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.66, new DateTime(2027, 4, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.07, new DateTime(2027, 4, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.0299999999999998, new DateTime(2027, 4, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.859999999999999, new DateTime(2027, 4, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.399999999999999, new DateTime(2027, 4, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.54, new DateTime(2027, 4, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 31.109999999999999, new DateTime(2027, 4, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.579999999999998, new DateTime(2027, 4, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.84, new DateTime(2027, 4, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.27, new DateTime(2027, 4, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 76.769999999999996, new DateTime(2027, 4, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.050000000000001, new DateTime(2027, 4, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.57, new DateTime(2027, 4, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.2000000000000002, new DateTime(2027, 4, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 67.299999999999997, new DateTime(2027, 4, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.969999999999999, new DateTime(2027, 4, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 40.079999999999998, new DateTime(2027, 4, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.4400000000000004, new DateTime(2027, 4, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.359999999999999, new DateTime(2027, 4, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.369999999999999, new DateTime(2027, 4, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.949999999999999, new DateTime(2027, 4, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.4199999999999999, new DateTime(2027, 4, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.620000000000001, new DateTime(2027, 4, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 49.25, new DateTime(2027, 4, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.010000000000002, new DateTime(2027, 4, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.57, new DateTime(2027, 4, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.71, new DateTime(2027, 4, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.3799999999999999, new DateTime(2027, 4, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.899999999999999, new DateTime(2027, 4, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.3799999999999999, new DateTime(2027, 4, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.6699999999999999, new DateTime(2027, 4, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.949999999999999, new DateTime(2027, 4, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.5700000000000003, new DateTime(2027, 4, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.32, new DateTime(2027, 4, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.140000000000001, new DateTime(2027, 4, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.720000000000001, new DateTime(2027, 4, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.25, new DateTime(2027, 4, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.559999999999999, new DateTime(2027, 4, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.050000000000001, new DateTime(2027, 5, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.3899999999999997, new DateTime(2027, 5, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.43, new DateTime(2027, 5, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 44.43, new DateTime(2027, 5, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.350000000000001, new DateTime(2027, 5, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.199999999999999, new DateTime(2027, 5, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.120000000000001, new DateTime(2027, 5, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.9900000000000002, new DateTime(2027, 5, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.23, new DateTime(2027, 5, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.34, new DateTime(2027, 5, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.1699999999999999, new DateTime(2027, 5, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.329999999999998, new DateTime(2027, 5, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.719999999999999, new DateTime(2027, 5, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 66.0, new DateTime(2027, 5, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.85, new DateTime(2027, 5, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.280000000000001, new DateTime(2027, 5, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.68, new DateTime(2027, 5, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.149999999999999, new DateTime(2027, 5, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.359999999999999, new DateTime(2027, 5, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.48, new DateTime(2027, 5, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.48, new DateTime(2027, 5, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.9000000000000004, new DateTime(2027, 5, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.210000000000001, new DateTime(2027, 5, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.619999999999999, new DateTime(2027, 5, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.82, new DateTime(2027, 5, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.25, new DateTime(2027, 5, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.289999999999999, new DateTime(2027, 5, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.99, new DateTime(2027, 5, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.0099999999999998, new DateTime(2027, 5, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.27, new DateTime(2027, 5, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 47.369999999999997, new DateTime(2027, 5, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 54.380000000000003, new DateTime(2027, 5, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.23, new DateTime(2027, 5, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.060000000000002, new DateTime(2027, 5, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.1600000000000001, new DateTime(2027, 5, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.3900000000000001, new DateTime(2027, 5, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 73.540000000000006, new DateTime(2027, 5, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.3899999999999997, new DateTime(2027, 5, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.699999999999999, new DateTime(2027, 5, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.42, new DateTime(2027, 5, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.829999999999998, new DateTime(2027, 5, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.670000000000002, new DateTime(2027, 5, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.0, new DateTime(2027, 5, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.440000000000001, new DateTime(2027, 5, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 37.219999999999999, new DateTime(2027, 5, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.969999999999999, new DateTime(2027, 5, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 31.640000000000001, new DateTime(2027, 5, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.539999999999999, new DateTime(2027, 5, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.43, new DateTime(2027, 5, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.399999999999999, new DateTime(2027, 5, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.300000000000001, new DateTime(2027, 5, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.02, new DateTime(2027, 5, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.079999999999998, new DateTime(2027, 5, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.4800000000000004, new DateTime(2027, 5, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.69, new DateTime(2027, 6, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.970000000000001, new DateTime(2027, 6, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.380000000000001, new DateTime(2027, 6, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.879999999999999, new DateTime(2027, 6, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.640000000000001, new DateTime(2027, 6, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 44.310000000000002, new DateTime(2027, 6, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.52, new DateTime(2027, 6, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.760000000000002, new DateTime(2027, 6, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.53, new DateTime(2027, 6, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 60.079999999999998, new DateTime(2027, 6, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.6400000000000006, new DateTime(2027, 6, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.6400000000000006, new DateTime(2027, 6, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.109999999999999, new DateTime(2027, 6, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.280000000000001, new DateTime(2027, 6, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.02, new DateTime(2027, 6, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.600000000000001, new DateTime(2027, 6, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.2400000000000002, new DateTime(2027, 6, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.539999999999999, new DateTime(2027, 6, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 30.170000000000002, new DateTime(2027, 6, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.91, new DateTime(2027, 6, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.19, new DateTime(2027, 6, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.3799999999999999, new DateTime(2027, 6, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.75, new DateTime(2027, 6, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.579999999999998, new DateTime(2027, 6, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.6999999999999993, new DateTime(2027, 6, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.75, new DateTime(2027, 6, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.5700000000000003, new DateTime(2027, 6, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.0099999999999998, new DateTime(2027, 6, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.82, new DateTime(2027, 6, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.41, new DateTime(2027, 6, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 30.23, new DateTime(2027, 6, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 47.359999999999999, new DateTime(2027, 6, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.710000000000001, new DateTime(2027, 6, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 33.460000000000001, new DateTime(2027, 6, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 68.209999999999994, new DateTime(2027, 6, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 31.93, new DateTime(2027, 6, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 86.170000000000002, new DateTime(2027, 6, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.48, new DateTime(2027, 6, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.15, new DateTime(2027, 6, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.899999999999999, new DateTime(2027, 6, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.090000000000003, new DateTime(2027, 6, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.52, new DateTime(2027, 6, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.4199999999999999, new DateTime(2027, 6, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.190000000000001, new DateTime(2027, 6, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.0999999999999996, new DateTime(2027, 6, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.9199999999999999, new DateTime(2027, 6, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.539999999999999, new DateTime(2027, 6, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 56.729999999999997, new DateTime(2027, 6, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.4299999999999997, new DateTime(2027, 6, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.329999999999998, new DateTime(2027, 6, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.9400000000000004, new DateTime(2027, 6, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.829999999999998, new DateTime(2027, 6, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 52.369999999999997, new DateTime(2027, 6, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.98, new DateTime(2027, 6, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 79.909999999999997, new DateTime(2027, 6, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.48, new DateTime(2027, 6, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.3700000000000001, new DateTime(2027, 6, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.879999999999999, new DateTime(2027, 6, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.260000000000002, new DateTime(2027, 6, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.510000000000002, new DateTime(2027, 6, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.75, new DateTime(2027, 6, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.0199999999999996, new DateTime(2027, 6, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 76.909999999999997, new DateTime(2027, 6, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.809999999999999, new DateTime(2027, 6, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.039999999999999, new DateTime(2027, 6, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.21, new DateTime(2027, 6, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.9199999999999999, new DateTime(2027, 6, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.6299999999999999, new DateTime(2027, 6, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.149999999999999, new DateTime(2027, 7, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 42.219999999999999, new DateTime(2027, 7, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.970000000000001, new DateTime(2027, 7, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.090000000000003, new DateTime(2027, 7, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.8899999999999997, new DateTime(2027, 7, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.43, new DateTime(2027, 7, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.93, new DateTime(2027, 7, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.5199999999999996, new DateTime(2027, 7, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.5, new DateTime(2027, 7, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.82, new DateTime(2027, 7, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.3799999999999999, new DateTime(2027, 7, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.280000000000001, new DateTime(2027, 7, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.190000000000001, new DateTime(2027, 7, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.84, new DateTime(2027, 7, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.84, new DateTime(2027, 7, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.969999999999999, new DateTime(2027, 7, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.3700000000000001, new DateTime(2027, 7, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.300000000000001, new DateTime(2027, 7, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.08, new DateTime(2027, 7, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 42.799999999999997, new DateTime(2027, 7, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.56, new DateTime(2027, 7, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.54, new DateTime(2027, 7, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.69, new DateTime(2027, 7, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.890000000000001, new DateTime(2027, 7, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.59, new DateTime(2027, 7, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.75, new DateTime(2027, 7, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.0, new DateTime(2027, 7, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.390000000000001, new DateTime(2027, 7, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.259999999999998, new DateTime(2027, 7, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.559999999999999, new DateTime(2027, 7, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.8100000000000001, new DateTime(2027, 7, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.0, new DateTime(2027, 7, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 49.539999999999999, new DateTime(2027, 7, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.120000000000001, new DateTime(2027, 7, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.039999999999999, new DateTime(2027, 7, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.370000000000001, new DateTime(2027, 7, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.550000000000001, new DateTime(2027, 7, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.619999999999999, new DateTime(2027, 7, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.2799999999999998, new DateTime(2027, 7, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.3000000000000007, new DateTime(2027, 7, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.239999999999998, new DateTime(2027, 7, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.09, new DateTime(2027, 7, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.970000000000001, new DateTime(2027, 7, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.26, new DateTime(2027, 7, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.390000000000001, new DateTime(2027, 7, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.3599999999999999, new DateTime(2027, 7, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.600000000000001, new DateTime(2027, 7, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.119999999999999, new DateTime(2027, 7, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 62.229999999999997, new DateTime(2027, 7, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.56, new DateTime(2027, 7, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.719999999999999, new DateTime(2027, 7, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.8199999999999998, new DateTime(2027, 7, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.7200000000000002, new DateTime(2027, 7, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.1800000000000002, new DateTime(2027, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.34, new DateTime(2027, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.420000000000002, new DateTime(2027, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.829999999999998, new DateTime(2027, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.940000000000001, new DateTime(2027, 7, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.539999999999999, new DateTime(2027, 7, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.75, new DateTime(2027, 7, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.09, new DateTime(2027, 7, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.0, new DateTime(2027, 7, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.27, new DateTime(2027, 7, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.550000000000001, new DateTime(2027, 8, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.9000000000000004, new DateTime(2027, 8, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.2300000000000004, new DateTime(2027, 8, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.699999999999999, new DateTime(2027, 8, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 39.18, new DateTime(2027, 8, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.66, new DateTime(2027, 8, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.77, new DateTime(2027, 8, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.710000000000001, new DateTime(2027, 8, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.66, new DateTime(2027, 8, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 47.0, new DateTime(2027, 8, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.3700000000000001, new DateTime(2027, 8, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.879999999999999, new DateTime(2027, 8, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.66, new DateTime(2027, 8, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 33.380000000000003, new DateTime(2027, 8, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.5, new DateTime(2027, 8, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.130000000000001, new DateTime(2027, 8, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.380000000000001, new DateTime(2027, 8, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.3599999999999994, new DateTime(2027, 8, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.9100000000000001, new DateTime(2027, 8, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.52, new DateTime(2027, 8, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.16, new DateTime(2027, 8, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.739999999999998, new DateTime(2027, 8, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 62.289999999999999, new DateTime(2027, 8, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.920000000000002, new DateTime(2027, 8, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.770000000000003, new DateTime(2027, 8, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.0, new DateTime(2027, 8, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.6400000000000006, new DateTime(2027, 8, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.969999999999999, new DateTime(2027, 8, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 28.239999999999998, new DateTime(2027, 8, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.829999999999998, new DateTime(2027, 8, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.3900000000000006, new DateTime(2027, 8, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.280000000000001, new DateTime(2027, 8, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.109999999999999, new DateTime(2027, 8, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.25, new DateTime(2027, 8, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.460000000000001, new DateTime(2027, 8, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.5, new DateTime(2027, 8, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.760000000000002, new DateTime(2027, 8, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.489999999999998, new DateTime(2027, 8, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.859999999999999, new DateTime(2027, 8, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.09, new DateTime(2027, 8, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.859999999999999, new DateTime(2027, 8, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.800000000000001, new DateTime(2027, 8, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.960000000000001, new DateTime(2027, 8, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.420000000000002, new DateTime(2027, 8, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.6899999999999999, new DateTime(2027, 8, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 49.170000000000002, new DateTime(2027, 8, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.91, new DateTime(2027, 8, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.620000000000001, new DateTime(2027, 8, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Date", "Recurrent" },
                values: new object[] { new DateTime(2027, 8, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.949999999999999, new DateTime(2027, 8, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.79, new DateTime(2027, 8, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 47.759999999999998, new DateTime(2027, 8, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.899999999999999, new DateTime(2027, 8, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.279999999999999, new DateTime(2027, 8, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.260000000000002, new DateTime(2027, 8, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.8799999999999999, new DateTime(2027, 8, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.6900000000000004, new DateTime(2027, 8, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.3899999999999997, new DateTime(2027, 8, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.469999999999999, new DateTime(2027, 8, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.190000000000001, new DateTime(2027, 8, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 40.219999999999999, new DateTime(2027, 8, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 49.149999999999999, new DateTime(2027, 8, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.890000000000001, new DateTime(2027, 8, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 53.369999999999997, new DateTime(2027, 9, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.8300000000000001, new DateTime(2027, 9, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.06, new DateTime(2027, 9, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.5099999999999998, new DateTime(2027, 9, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.32, new DateTime(2027, 9, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.76, new DateTime(2027, 9, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.940000000000001, new DateTime(2027, 9, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 48.32, new DateTime(2027, 9, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.06, new DateTime(2027, 9, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.4199999999999999, new DateTime(2027, 9, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.539999999999999, new DateTime(2027, 9, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.5, new DateTime(2027, 9, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.039999999999999, new DateTime(2027, 9, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.739999999999998, new DateTime(2027, 9, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.489999999999998, new DateTime(2027, 9, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 40.759999999999998, new DateTime(2027, 9, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 53.049999999999997, new DateTime(2027, 9, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.73, new DateTime(2027, 9, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.66, new DateTime(2027, 9, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.3200000000000001, new DateTime(2027, 9, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.07, new DateTime(2027, 9, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.33, new DateTime(2027, 9, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.899999999999999, new DateTime(2027, 9, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 71.349999999999994, new DateTime(2027, 9, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.2300000000000004, new DateTime(2027, 9, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.059999999999999, new DateTime(2027, 9, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.630000000000001, new DateTime(2027, 9, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 70.609999999999999, new DateTime(2027, 9, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.2200000000000006, new DateTime(2027, 9, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.48, new DateTime(2027, 9, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 17.370000000000001, new DateTime(2027, 9, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.609999999999999, new DateTime(2027, 9, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.8300000000000001, new DateTime(2027, 9, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 55.530000000000001, new DateTime(2027, 9, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.6799999999999997, new DateTime(2027, 9, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.300000000000001, new DateTime(2027, 9, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.760000000000002, new DateTime(2027, 9, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 11.85, new DateTime(2027, 9, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.309999999999999, new DateTime(2027, 9, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.18, new DateTime(2027, 9, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.23, new DateTime(2027, 9, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 21.039999999999999, new DateTime(2027, 9, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 31.079999999999998, new DateTime(2027, 9, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.649999999999999, new DateTime(2027, 9, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.969999999999999, new DateTime(2027, 9, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.68, new DateTime(2027, 9, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 30.100000000000001, new DateTime(2027, 9, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 30.030000000000001, new DateTime(2027, 9, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.83, new DateTime(2027, 9, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.59, new DateTime(2027, 9, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.2000000000000002, new DateTime(2027, 9, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.8200000000000003, new DateTime(2027, 9, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.220000000000001, new DateTime(2027, 9, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 33.869999999999997, new DateTime(2027, 9, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.07, new DateTime(2027, 9, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.9199999999999999, new DateTime(2027, 9, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 7.8600000000000003, new DateTime(2027, 9, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.46, new DateTime(2027, 9, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.76, new DateTime(2027, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.04, new DateTime(2027, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 40.840000000000003, new DateTime(2027, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.75, new DateTime(2027, 9, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.75, new DateTime(2027, 9, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.5600000000000005, new DateTime(2027, 9, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.239999999999998, new DateTime(2027, 10, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.460000000000001, new DateTime(2027, 10, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.470000000000001, new DateTime(2027, 10, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.710000000000001, new DateTime(2027, 10, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.939999999999998, new DateTime(2027, 10, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.240000000000002, new DateTime(2027, 10, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.3399999999999999, new DateTime(2027, 10, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.66, new DateTime(2027, 10, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.300000000000001, new DateTime(2027, 10, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.699999999999999, new DateTime(2027, 10, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.759999999999998, new DateTime(2027, 10, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.52, new DateTime(2027, 10, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.23, new DateTime(2027, 10, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 15.640000000000001, new DateTime(2027, 10, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.399999999999999, new DateTime(2027, 10, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.8399999999999999, new DateTime(2027, 10, 10, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 43.43, new DateTime(2027, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.420000000000002, new DateTime(2027, 10, 11, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.969999999999999, new DateTime(2027, 10, 12, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 35.200000000000003, new DateTime(2027, 10, 13, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.34, new DateTime(2027, 10, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.1099999999999999, new DateTime(2027, 10, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.1800000000000002, new DateTime(2027, 10, 14, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.93, new DateTime(2027, 10, 15, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 50.969999999999999, new DateTime(2027, 10, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 36.859999999999999, new DateTime(2027, 10, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 33.189999999999998, new DateTime(2027, 10, 16, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.489999999999998, new DateTime(2027, 10, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.93, new DateTime(2027, 10, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.420000000000002, new DateTime(2027, 10, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 38.159999999999997, new DateTime(2027, 10, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.3899999999999999, new DateTime(2027, 10, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.82, new DateTime(2027, 10, 17, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 2.48, new DateTime(2027, 10, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.850000000000001, new DateTime(2027, 10, 18, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.300000000000001, new DateTime(2027, 10, 19, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 27.670000000000002, new DateTime(2027, 10, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 10.029999999999999, new DateTime(2027, 10, 20, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.25, new DateTime(2027, 10, 21, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.59, new DateTime(2027, 10, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 37.020000000000003, new DateTime(2027, 10, 22, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 32.710000000000001, new DateTime(2027, 10, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.2199999999999998, new DateTime(2027, 10, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.699999999999999, new DateTime(2027, 10, 23, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 5.1900000000000004, new DateTime(2027, 10, 24, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 20.940000000000001, new DateTime(2027, 10, 25, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.5300000000000002, new DateTime(2027, 10, 26, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 19.289999999999999, new DateTime(2027, 10, 27, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 25.559999999999999, new DateTime(2027, 10, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 18.199999999999999, new DateTime(2027, 10, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 26.879999999999999, new DateTime(2027, 10, 28, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 40.259999999999998, new DateTime(2027, 10, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.66, new DateTime(2027, 10, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.390000000000001, new DateTime(2027, 10, 29, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.25, new DateTime(2027, 10, 30, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 8.2100000000000009, new DateTime(2027, 10, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 60.170000000000002, new DateTime(2027, 10, 31, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.41, new DateTime(2027, 11, 1, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.6600000000000001, new DateTime(2027, 11, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 16.789999999999999, new DateTime(2027, 11, 2, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 45.5, new DateTime(2027, 11, 3, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 12.93, new DateTime(2027, 11, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 13.44, new DateTime(2027, 11, 4, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 29.129999999999999, new DateTime(2027, 11, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 48.630000000000003, new DateTime(2027, 11, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 14.050000000000001, new DateTime(2027, 11, 5, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 3.0099999999999998, new DateTime(2027, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 41.969999999999999, new DateTime(2027, 11, 6, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 4.4299999999999997, new DateTime(2027, 11, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 1.97, new DateTime(2027, 11, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 34.299999999999997, new DateTime(2027, 11, 7, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 22.890000000000001, new DateTime(2027, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.4000000000000004, new DateTime(2027, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 9.5399999999999991, new DateTime(2027, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 23.879999999999999, new DateTime(2027, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 49.189999999999998, new DateTime(2027, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 24.100000000000001, new DateTime(2027, 11, 8, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Amount", "Date", "Recurrent" },
                values: new object[] { 6.9199999999999999, new DateTime(2027, 11, 9, 20, 7, 38, 536, DateTimeKind.Local).AddTicks(6335), false });

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Suppliers_SupplierId",
                table: "Transactions",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Suppliers_SupplierId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Recurrent",
                table: "Transactions");

            migrationBuilder.CreateTable(
                name: "BusinessCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTransaction = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessSuppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTransaction = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessSuppliers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BusinessCategories",
                columns: new[] { "Id", "Name", "NumberOfTransaction", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Wood", 100, 2109.23 },
                    { 2, "Aluminium", 100, 2193.8499999999999 },
                    { 3, "Iron", 100, 1981.71 },
                    { 4, "Stainless Steel", 100, 2361.0599999999999 },
                    { 5, "Screws", 100, 2055.1199999999999 },
                    { 6, "Wood Tools", 100, 2509.23 },
                    { 7, "Door Accessories", 100, 1817.3 },
                    { 8, "Glass", 100, 2034.1800000000001 },
                    { 9, "Metal Tools", 100, 2371.0500000000002 },
                    { 10, "Glass Accessories", 100, 1940.8 }
                });

            migrationBuilder.InsertData(
                table: "BusinessSuppliers",
                columns: new[] { "Id", "Name", "NumberOfTransaction", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Glasson", 300, 6536.6199999999999 },
                    { 2, "Bauhaus", 200, 4880.2799999999997 },
                    { 3, "Scierie de Romont", 100, 2109.23 },
                    { 4, "Sofraver SA", 200, 3974.98 },
                    { 5, "Commerce de Fer Fribourgeois", 200, 3872.4200000000001 }
                });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.369999999999999, new DateTime(2026, 6, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.75, new DateTime(2026, 6, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 32.149999999999999, new DateTime(2026, 6, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.7999999999999998, new DateTime(2026, 6, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 80.5, new DateTime(2026, 6, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.04, new DateTime(2026, 6, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.220000000000001, new DateTime(2026, 6, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 60.689999999999998, new DateTime(2026, 6, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.059999999999999, new DateTime(2026, 6, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.219999999999999, new DateTime(2026, 6, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 77.75, new DateTime(2026, 6, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.6499999999999999, new DateTime(2026, 6, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.690000000000001, new DateTime(2026, 6, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.1999999999999993, new DateTime(2026, 6, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.210000000000001, new DateTime(2026, 6, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.4500000000000002, new DateTime(2026, 6, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.43, new DateTime(2026, 6, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.7599999999999998, new DateTime(2026, 6, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.280000000000001, new DateTime(2026, 6, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.780000000000001, new DateTime(2026, 6, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 57.789999999999999, new DateTime(2026, 6, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.239999999999998, new DateTime(2026, 6, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.25, new DateTime(2026, 6, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.640000000000001, new DateTime(2026, 6, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.960000000000001, new DateTime(2026, 6, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.1299999999999999, new DateTime(2026, 6, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.140000000000001, new DateTime(2026, 6, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 35.049999999999997, new DateTime(2026, 6, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.940000000000001, new DateTime(2026, 6, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.029999999999999, new DateTime(2026, 6, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.869999999999999, new DateTime(2026, 6, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.0199999999999996, new DateTime(2026, 6, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.719999999999999, new DateTime(2026, 6, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.57, new DateTime(2026, 6, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.520000000000003, new DateTime(2026, 6, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 54.100000000000001, new DateTime(2026, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.9, new DateTime(2026, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.83, new DateTime(2026, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 46.359999999999999, new DateTime(2026, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 53.649999999999999, new DateTime(2026, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 63.460000000000001, new DateTime(2026, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.989999999999998, new DateTime(2026, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 48.630000000000003, new DateTime(2026, 6, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.9199999999999999, new DateTime(2026, 6, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.43, new DateTime(2026, 6, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.210000000000001, new DateTime(2026, 6, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.270000000000003, new DateTime(2026, 6, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.08, new DateTime(2026, 6, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.260000000000002, new DateTime(2026, 6, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 31.98, new DateTime(2026, 6, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.469999999999999, new DateTime(2026, 6, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.449999999999999, new DateTime(2026, 6, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2026, 6, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.33, new DateTime(2026, 6, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.720000000000001, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.5, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.4199999999999999, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.0, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 48.810000000000002, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.469999999999999, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.079999999999998, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 38.0, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.039999999999999, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.3799999999999999, new DateTime(2026, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.41, new DateTime(2026, 6, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.629999999999999, new DateTime(2026, 6, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.699999999999999, new DateTime(2026, 6, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 32.609999999999999, new DateTime(2026, 7, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.050000000000001, new DateTime(2026, 7, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 31.530000000000001, new DateTime(2026, 7, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.760000000000002, new DateTime(2026, 7, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.6, new DateTime(2026, 7, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 82.329999999999998, new DateTime(2026, 7, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 32.119999999999997, new DateTime(2026, 7, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 69.640000000000001, new DateTime(2026, 7, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.7799999999999998, new DateTime(2026, 7, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.969999999999999, new DateTime(2026, 7, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 41.740000000000002, new DateTime(2026, 7, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.920000000000002, new DateTime(2026, 7, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.879999999999999, new DateTime(2026, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.399999999999999, new DateTime(2026, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.690000000000001, new DateTime(2026, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.619999999999999, new DateTime(2026, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.8200000000000003, new DateTime(2026, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.7300000000000004, new DateTime(2026, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.739999999999998, new DateTime(2026, 7, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.600000000000001, new DateTime(2026, 7, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.109999999999999, new DateTime(2026, 7, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.609999999999999, new DateTime(2026, 7, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.1899999999999999, new DateTime(2026, 7, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.649999999999999, new DateTime(2026, 7, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 66.5, new DateTime(2026, 7, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.85, new DateTime(2026, 7, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 32.740000000000002, new DateTime(2026, 7, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.3200000000000003, new DateTime(2026, 7, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.619999999999999, new DateTime(2026, 7, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.4800000000000004, new DateTime(2026, 7, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.18, new DateTime(2026, 7, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.420000000000002, new DateTime(2026, 7, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.7899999999999991, new DateTime(2026, 7, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.4399999999999995, new DateTime(2026, 7, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 31.370000000000001, new DateTime(2026, 7, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.27, new DateTime(2026, 7, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.119999999999999, new DateTime(2026, 7, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 97.799999999999997, new DateTime(2026, 7, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.48, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.670000000000002, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.460000000000001, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.25, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.899999999999999, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.73, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 59.829999999999998, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.239999999999998, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.550000000000001, new DateTime(2026, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.34, new DateTime(2026, 7, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.3799999999999999, new DateTime(2026, 7, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.380000000000001, new DateTime(2026, 7, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.07, new DateTime(2026, 7, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.899999999999999, new DateTime(2026, 7, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.1699999999999999, new DateTime(2026, 7, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 50.799999999999997, new DateTime(2026, 7, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.7200000000000002, new DateTime(2026, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 59.5, new DateTime(2026, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.600000000000001, new DateTime(2026, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 32.530000000000001, new DateTime(2026, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.100000000000001, new DateTime(2026, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 62.189999999999998, new DateTime(2026, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.640000000000001, new DateTime(2026, 7, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.630000000000003, new DateTime(2026, 7, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 42.969999999999999, new DateTime(2026, 7, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.109999999999999, new DateTime(2026, 7, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.719999999999999, new DateTime(2026, 7, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 46.380000000000003, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.039999999999999, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 65.5, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 43.030000000000001, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 53.07, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.140000000000001, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.0599999999999996, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.7100000000000009, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.3799999999999999, new DateTime(2026, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 42.630000000000003, new DateTime(2026, 7, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.3700000000000001, new DateTime(2026, 7, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 71.549999999999997, new DateTime(2026, 7, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.82, new DateTime(2026, 7, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.8900000000000001, new DateTime(2026, 7, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.79, new DateTime(2026, 7, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.51, new DateTime(2026, 7, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.5099999999999998, new DateTime(2026, 7, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.34, new DateTime(2026, 8, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.68, new DateTime(2026, 8, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.600000000000001, new DateTime(2026, 8, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 31.57, new DateTime(2026, 8, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.100000000000001, new DateTime(2026, 8, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.649999999999999, new DateTime(2026, 8, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.7400000000000002, new DateTime(2026, 8, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.18, new DateTime(2026, 8, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.69, new DateTime(2026, 8, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.199999999999999, new DateTime(2026, 8, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.73, new DateTime(2026, 8, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 54.609999999999999, new DateTime(2026, 8, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.210000000000001, new DateTime(2026, 8, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.42, new DateTime(2026, 8, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.050000000000001, new DateTime(2026, 8, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.899999999999999, new DateTime(2026, 8, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.73, new DateTime(2026, 8, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.5, new DateTime(2026, 8, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.8300000000000001, new DateTime(2026, 8, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.120000000000001, new DateTime(2026, 8, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 66.370000000000005, new DateTime(2026, 8, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 79.040000000000006, new DateTime(2026, 8, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 43.289999999999999, new DateTime(2026, 8, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.66, new DateTime(2026, 8, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.050000000000001, new DateTime(2026, 8, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.07, new DateTime(2026, 8, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.8799999999999999, new DateTime(2026, 8, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.880000000000003, new DateTime(2026, 8, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.3400000000000001, new DateTime(2026, 8, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.75, new DateTime(2026, 8, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.52, new DateTime(2026, 8, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.770000000000003, new DateTime(2026, 8, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.5599999999999996, new DateTime(2026, 8, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.9699999999999998, new DateTime(2026, 8, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.3799999999999999, new DateTime(2026, 8, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.41, new DateTime(2026, 8, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.329999999999998, new DateTime(2026, 8, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.92, new DateTime(2026, 8, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.8499999999999996, new DateTime(2026, 8, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.039999999999999, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.510000000000002, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.9000000000000004, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.829999999999998, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.469999999999999, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.4900000000000002, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.890000000000001, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.239999999999998, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.77, new DateTime(2026, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.219999999999999, new DateTime(2026, 8, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.199999999999999, new DateTime(2026, 8, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.939999999999998, new DateTime(2026, 8, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.3899999999999997, new DateTime(2026, 8, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 44.43, new DateTime(2026, 8, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.83, new DateTime(2026, 8, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.99, new DateTime(2026, 8, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.539999999999999, new DateTime(2026, 8, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 46.909999999999997, new DateTime(2026, 8, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 56.189999999999998, new DateTime(2026, 8, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.43, new DateTime(2026, 8, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.359999999999999, new DateTime(2026, 8, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 31.190000000000001, new DateTime(2026, 8, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.7799999999999998, new DateTime(2026, 8, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.809999999999999, new DateTime(2026, 8, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.199999999999999, new DateTime(2026, 8, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.0899999999999999, new DateTime(2026, 8, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 40.0, new DateTime(2026, 9, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.49, new DateTime(2026, 9, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.33, new DateTime(2026, 9, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 93.0, new DateTime(2026, 9, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.260000000000002, new DateTime(2026, 9, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.34, new DateTime(2026, 9, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.1400000000000006, new DateTime(2026, 9, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.699999999999999, new DateTime(2026, 9, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.6799999999999997, new DateTime(2026, 9, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.399999999999999, new DateTime(2026, 9, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.2300000000000004, new DateTime(2026, 9, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 39.68, new DateTime(2026, 9, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.649999999999999, new DateTime(2026, 9, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.560000000000002, new DateTime(2026, 9, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.04, new DateTime(2026, 9, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.850000000000001, new DateTime(2026, 9, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.9299999999999997, new DateTime(2026, 9, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.2999999999999998, new DateTime(2026, 9, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.190000000000001, new DateTime(2026, 9, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.880000000000001, new DateTime(2026, 9, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.379999999999999, new DateTime(2026, 9, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.79, new DateTime(2026, 9, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.06, new DateTime(2026, 9, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.76, new DateTime(2026, 9, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.9699999999999998, new DateTime(2026, 9, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.2400000000000002, new DateTime(2026, 9, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.25, new DateTime(2026, 9, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.8799999999999999, new DateTime(2026, 9, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.7999999999999998, new DateTime(2026, 9, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 46.950000000000003, new DateTime(2026, 9, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.7699999999999996, new DateTime(2026, 9, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.1200000000000001, new DateTime(2026, 9, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.579999999999998, new DateTime(2026, 9, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 52.740000000000002, new DateTime(2026, 9, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.1200000000000001, new DateTime(2026, 9, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.789999999999999, new DateTime(2026, 9, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.3099999999999996, new DateTime(2026, 9, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.9900000000000002, new DateTime(2026, 9, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.17, new DateTime(2026, 9, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.630000000000001, new DateTime(2026, 9, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.27, new DateTime(2026, 9, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.6699999999999999, new DateTime(2026, 9, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 64.299999999999997, new DateTime(2026, 9, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.0, new DateTime(2026, 9, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.34, new DateTime(2026, 9, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.619999999999997, new DateTime(2026, 9, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.27, new DateTime(2026, 9, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.529999999999999, new DateTime(2026, 9, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.5600000000000001, new DateTime(2026, 9, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.48, new DateTime(2026, 9, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.7599999999999998, new DateTime(2026, 9, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.6200000000000001, new DateTime(2026, 9, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.5099999999999998, new DateTime(2026, 9, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.68, new DateTime(2026, 9, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.5600000000000001, new DateTime(2026, 9, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.5600000000000001, new DateTime(2026, 9, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.2799999999999994, new DateTime(2026, 9, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.420000000000002, new DateTime(2026, 9, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.4199999999999999, new DateTime(2026, 9, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.170000000000002, new DateTime(2026, 9, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.2699999999999996, new DateTime(2026, 9, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.84, new DateTime(2026, 9, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.0, new DateTime(2026, 9, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.1899999999999995, new DateTime(2026, 9, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 44.609999999999999, new DateTime(2026, 9, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.859999999999999, new DateTime(2026, 10, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.49, new DateTime(2026, 10, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.699999999999999, new DateTime(2026, 10, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.440000000000001, new DateTime(2026, 10, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.1899999999999999, new DateTime(2026, 10, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.27, new DateTime(2026, 10, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.870000000000001, new DateTime(2026, 10, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.809999999999999, new DateTime(2026, 10, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.289999999999999, new DateTime(2026, 10, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.899999999999999, new DateTime(2026, 10, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.869999999999999, new DateTime(2026, 10, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.98, new DateTime(2026, 10, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.529999999999999, new DateTime(2026, 10, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.07, new DateTime(2026, 10, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.46, new DateTime(2026, 10, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.9000000000000004, new DateTime(2026, 10, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.6999999999999993, new DateTime(2026, 10, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.0899999999999999, new DateTime(2026, 10, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.3599999999999994, new DateTime(2026, 10, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.6899999999999999, new DateTime(2026, 10, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.059999999999999, new DateTime(2026, 10, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.09, new DateTime(2026, 10, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.0899999999999999, new DateTime(2026, 10, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.18, new DateTime(2026, 10, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.0600000000000005, new DateTime(2026, 10, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.52, new DateTime(2026, 10, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.84, new DateTime(2026, 10, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.890000000000001, new DateTime(2026, 10, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 53.090000000000003, new DateTime(2026, 10, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.7800000000000002, new DateTime(2026, 10, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.530000000000001, new DateTime(2026, 10, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.059999999999999, new DateTime(2026, 10, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.309999999999999, new DateTime(2026, 10, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.93, new DateTime(2026, 10, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.649999999999999, new DateTime(2026, 10, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.0, new DateTime(2026, 10, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.68, new DateTime(2026, 10, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.379999999999999, new DateTime(2026, 10, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.140000000000001, new DateTime(2026, 10, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 46.229999999999997, new DateTime(2026, 10, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.359999999999999, new DateTime(2026, 10, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.7400000000000002, new DateTime(2026, 10, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 56.450000000000003, new DateTime(2026, 10, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.1200000000000001, new DateTime(2026, 10, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.829999999999998, new DateTime(2026, 10, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.210000000000001, new DateTime(2026, 10, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.629999999999999, new DateTime(2026, 10, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.34, new DateTime(2026, 10, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.77, new DateTime(2026, 10, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.3700000000000001, new DateTime(2026, 10, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.76, new DateTime(2026, 10, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.300000000000001, new DateTime(2026, 10, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.08, new DateTime(2026, 10, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.77, new DateTime(2026, 10, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.409999999999997, new DateTime(2026, 10, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.420000000000002, new DateTime(2026, 10, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.81, new DateTime(2026, 10, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.5, new DateTime(2026, 10, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.5, new DateTime(2026, 10, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.93, new DateTime(2026, 10, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.0699999999999998, new DateTime(2026, 10, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.879999999999999, new DateTime(2026, 10, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.1499999999999999, new DateTime(2026, 10, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.91, new DateTime(2026, 10, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.0299999999999998, new DateTime(2026, 10, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.18, new DateTime(2026, 10, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.3599999999999994, new DateTime(2026, 10, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.9, new DateTime(2026, 10, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.609999999999999, new DateTime(2026, 10, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.289999999999999, new DateTime(2026, 10, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 39.520000000000003, new DateTime(2026, 10, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.5099999999999998, new DateTime(2026, 10, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.899999999999999, new DateTime(2026, 10, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.520000000000003, new DateTime(2026, 10, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.5, new DateTime(2026, 11, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.460000000000001, new DateTime(2026, 11, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.879999999999999, new DateTime(2026, 11, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.24, new DateTime(2026, 11, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.199999999999999, new DateTime(2026, 11, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.8500000000000001, new DateTime(2026, 11, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.210000000000001, new DateTime(2026, 11, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.7799999999999998, new DateTime(2026, 11, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.920000000000002, new DateTime(2026, 11, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 80.0, new DateTime(2026, 11, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.33, new DateTime(2026, 11, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 39.82, new DateTime(2026, 11, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.91, new DateTime(2026, 11, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.880000000000003, new DateTime(2026, 11, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 51.200000000000003, new DateTime(2026, 11, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.859999999999999, new DateTime(2026, 11, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.870000000000001, new DateTime(2026, 11, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.6400000000000006, new DateTime(2026, 11, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.0, new DateTime(2026, 11, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.91, new DateTime(2026, 11, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.229999999999997, new DateTime(2026, 11, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.879999999999999, new DateTime(2026, 11, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.29, new DateTime(2026, 11, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.140000000000001, new DateTime(2026, 11, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.399999999999999, new DateTime(2026, 11, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 40.270000000000003, new DateTime(2026, 11, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.899999999999999, new DateTime(2026, 11, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.54, new DateTime(2026, 11, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 43.090000000000003, new DateTime(2026, 11, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.850000000000001, new DateTime(2026, 11, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.73, new DateTime(2026, 11, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.06, new DateTime(2026, 11, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.71, new DateTime(2026, 11, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.350000000000001, new DateTime(2026, 11, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.91, new DateTime(2026, 11, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.800000000000001, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.0299999999999994, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.34, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.43, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.6200000000000001, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.2599999999999998, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.44, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.829999999999998, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 40.049999999999997, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.4800000000000004, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.0800000000000001, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.3899999999999997, new DateTime(2026, 11, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.629999999999999, new DateTime(2026, 11, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 43.719999999999999, new DateTime(2026, 11, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.1300000000000008, new DateTime(2026, 11, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 57.439999999999998, new DateTime(2026, 11, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.300000000000001, new DateTime(2026, 11, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.640000000000001, new DateTime(2026, 11, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 57.310000000000002, new DateTime(2026, 11, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.649999999999999, new DateTime(2026, 11, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.059999999999999, new DateTime(2026, 11, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.810000000000002, new DateTime(2026, 11, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.8100000000000005, new DateTime(2026, 11, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.460000000000001, new DateTime(2026, 12, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.129999999999999, new DateTime(2026, 12, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.760000000000002, new DateTime(2026, 12, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.27, new DateTime(2026, 12, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.270000000000003, new DateTime(2026, 12, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.159999999999997, new DateTime(2026, 12, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.140000000000001, new DateTime(2026, 12, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.960000000000001, new DateTime(2026, 12, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.100000000000001, new DateTime(2026, 12, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.079999999999998, new DateTime(2026, 12, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.59, new DateTime(2026, 12, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.140000000000001, new DateTime(2026, 12, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.6100000000000003, new DateTime(2026, 12, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.510000000000002, new DateTime(2026, 12, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 46.119999999999997, new DateTime(2026, 12, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.789999999999999, new DateTime(2026, 12, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 63.57, new DateTime(2026, 12, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.5, new DateTime(2026, 12, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.57, new DateTime(2026, 12, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.800000000000001, new DateTime(2026, 12, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.73, new DateTime(2026, 12, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 67.069999999999993, new DateTime(2026, 12, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.010000000000002, new DateTime(2026, 12, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.8799999999999999, new DateTime(2026, 12, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.41, new DateTime(2026, 12, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 43.060000000000002, new DateTime(2026, 12, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.6600000000000001, new DateTime(2026, 12, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.43, new DateTime(2026, 12, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.5600000000000001, new DateTime(2026, 12, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 54.810000000000002, new DateTime(2026, 12, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.91, new DateTime(2026, 12, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.16, new DateTime(2026, 12, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.390000000000001, new DateTime(2026, 12, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.91, new DateTime(2026, 12, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.41, new DateTime(2026, 12, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.4199999999999999, new DateTime(2026, 12, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.100000000000001, new DateTime(2026, 12, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.0, new DateTime(2026, 12, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 31.350000000000001, new DateTime(2026, 12, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.4800000000000004, new DateTime(2026, 12, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.4000000000000004, new DateTime(2026, 12, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.52, new DateTime(2026, 12, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.3900000000000001, new DateTime(2026, 12, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.079999999999998, new DateTime(2026, 12, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.6899999999999995, new DateTime(2026, 12, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.92, new DateTime(2026, 12, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.629999999999999, new DateTime(2026, 12, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.620000000000001, new DateTime(2026, 12, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.539999999999999, new DateTime(2026, 12, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.8800000000000008, new DateTime(2026, 12, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 58.840000000000003, new DateTime(2026, 12, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.49, new DateTime(2026, 12, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.329999999999998, new DateTime(2026, 12, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.170000000000002, new DateTime(2026, 12, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.56, new DateTime(2027, 1, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.41, new DateTime(2027, 1, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.600000000000001, new DateTime(2027, 1, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 35.579999999999998, new DateTime(2027, 1, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 39.259999999999998, new DateTime(2027, 1, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.899999999999999, new DateTime(2027, 1, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.260000000000002, new DateTime(2027, 1, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.039999999999999, new DateTime(2027, 1, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.25, new DateTime(2027, 1, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.27, new DateTime(2027, 1, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.77, new DateTime(2027, 1, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.199999999999999, new DateTime(2027, 1, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.3399999999999999, new DateTime(2027, 1, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.970000000000001, new DateTime(2027, 1, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.1699999999999999, new DateTime(2027, 1, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.7800000000000002, new DateTime(2027, 1, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.140000000000001, new DateTime(2027, 1, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.6, new DateTime(2027, 1, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.289999999999999, new DateTime(2027, 1, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.390000000000001, new DateTime(2027, 1, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.1200000000000001, new DateTime(2027, 1, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 58.119999999999997, new DateTime(2027, 1, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 41.399999999999999, new DateTime(2027, 1, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.8099999999999996, new DateTime(2027, 1, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.579999999999998, new DateTime(2027, 1, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.3600000000000003, new DateTime(2027, 1, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.9000000000000004, new DateTime(2027, 1, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.4100000000000001, new DateTime(2027, 1, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.710000000000001, new DateTime(2027, 1, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.8499999999999996, new DateTime(2027, 1, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.149999999999999, new DateTime(2027, 1, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.08, new DateTime(2027, 1, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 60.329999999999998, new DateTime(2027, 1, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.73, new DateTime(2027, 1, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.0, new DateTime(2027, 1, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 35.939999999999998, new DateTime(2027, 1, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.09, new DateTime(2027, 1, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 59.640000000000001, new DateTime(2027, 1, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.27, new DateTime(2027, 1, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.74, new DateTime(2027, 1, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 57.520000000000003, new DateTime(2027, 1, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 54.280000000000001, new DateTime(2027, 1, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.600000000000001, new DateTime(2027, 1, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.079999999999998, new DateTime(2027, 1, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.0199999999999996, new DateTime(2027, 1, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.390000000000001, new DateTime(2027, 1, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.93, new DateTime(2027, 1, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.0599999999999996, new DateTime(2027, 1, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.350000000000001, new DateTime(2027, 1, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.350000000000001, new DateTime(2027, 1, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.7599999999999998, new DateTime(2027, 1, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.539999999999999, new DateTime(2027, 1, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 64.560000000000002, new DateTime(2027, 1, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.93, new DateTime(2027, 1, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.98, new DateTime(2027, 1, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.460000000000001, new DateTime(2027, 1, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.09, new DateTime(2027, 1, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.73, new DateTime(2027, 1, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.390000000000001, new DateTime(2027, 1, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.8899999999999997, new DateTime(2027, 1, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.3400000000000001, new DateTime(2027, 1, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.6499999999999999, new DateTime(2027, 1, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.18, new DateTime(2027, 1, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.6099999999999999, new DateTime(2027, 2, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 61.200000000000003, new DateTime(2027, 2, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.0, new DateTime(2027, 2, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.83, new DateTime(2027, 2, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.8399999999999999, new DateTime(2027, 2, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 40.170000000000002, new DateTime(2027, 2, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.84, new DateTime(2027, 2, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.710000000000001, new DateTime(2027, 2, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.2400000000000002, new DateTime(2027, 2, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.600000000000001, new DateTime(2027, 2, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 71.709999999999994, new DateTime(2027, 2, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 64.459999999999994, new DateTime(2027, 2, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.859999999999999, new DateTime(2027, 2, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.7599999999999998, new DateTime(2027, 2, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.75, new DateTime(2027, 2, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.48, new DateTime(2027, 2, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.869999999999997, new DateTime(2027, 2, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.75, new DateTime(2027, 2, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.989999999999998, new DateTime(2027, 2, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.699999999999999, new DateTime(2027, 2, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 54.310000000000002, new DateTime(2027, 2, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.6300000000000008, new DateTime(2027, 2, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.469999999999999, new DateTime(2027, 2, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.77, new DateTime(2027, 2, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.760000000000002, new DateTime(2027, 2, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.129999999999999, new DateTime(2027, 2, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.4, new DateTime(2027, 2, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.579999999999998, new DateTime(2027, 2, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.120000000000001, new DateTime(2027, 2, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.850000000000001, new DateTime(2027, 2, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.4800000000000004, new DateTime(2027, 2, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.350000000000001, new DateTime(2027, 2, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.609999999999999, new DateTime(2027, 2, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.4900000000000002, new DateTime(2027, 2, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.449999999999999, new DateTime(2027, 2, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.470000000000001, new DateTime(2027, 2, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.140000000000001, new DateTime(2027, 2, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 41.0, new DateTime(2027, 2, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.73, new DateTime(2027, 2, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 57.82, new DateTime(2027, 2, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.510000000000002, new DateTime(2027, 2, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.539999999999999, new DateTime(2027, 2, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.34, new DateTime(2027, 2, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.85, new DateTime(2027, 2, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.9299999999999997, new DateTime(2027, 2, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.49, new DateTime(2027, 2, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.2400000000000002, new DateTime(2027, 2, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.940000000000001, new DateTime(2027, 2, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.98, new DateTime(2027, 3, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.6399999999999997, new DateTime(2027, 3, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.77, new DateTime(2027, 3, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.109999999999999, new DateTime(2027, 3, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.68, new DateTime(2027, 3, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.030000000000001, new DateTime(2027, 3, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.0, new DateTime(2027, 3, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.0, new DateTime(2027, 3, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.35, new DateTime(2027, 3, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.620000000000001, new DateTime(2027, 3, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.51, new DateTime(2027, 3, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.350000000000001, new DateTime(2027, 3, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.59, new DateTime(2027, 3, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.2699999999999996, new DateTime(2027, 3, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.5600000000000001, new DateTime(2027, 3, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.52, new DateTime(2027, 3, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.039999999999999, new DateTime(2027, 3, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.289999999999999, new DateTime(2027, 3, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.379999999999999, new DateTime(2027, 3, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.960000000000001, new DateTime(2027, 3, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.510000000000002, new DateTime(2027, 3, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 58.189999999999998, new DateTime(2027, 3, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.710000000000001, new DateTime(2027, 3, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.699999999999999, new DateTime(2027, 3, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.3599999999999994, new DateTime(2027, 3, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.850000000000001, new DateTime(2027, 3, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.0, new DateTime(2027, 3, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 49.859999999999999, new DateTime(2027, 3, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.4100000000000001, new DateTime(2027, 3, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.8699999999999992, new DateTime(2027, 3, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.720000000000001, new DateTime(2027, 3, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 66.920000000000002, new DateTime(2027, 3, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.579999999999998, new DateTime(2027, 3, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.350000000000001, new DateTime(2027, 3, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.609999999999999, new DateTime(2027, 3, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.4299999999999997, new DateTime(2027, 3, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.3700000000000001, new DateTime(2027, 3, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.9399999999999999, new DateTime(2027, 3, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.390000000000001, new DateTime(2027, 3, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.2599999999999998, new DateTime(2027, 3, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.5999999999999996, new DateTime(2027, 3, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.93, new DateTime(2027, 3, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 67.420000000000002, new DateTime(2027, 3, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.969999999999999, new DateTime(2027, 3, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.5899999999999999, new DateTime(2027, 3, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.58, new DateTime(2027, 3, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.780000000000001, new DateTime(2027, 3, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.0, new DateTime(2027, 3, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 67.0, new DateTime(2027, 3, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.2400000000000002, new DateTime(2027, 3, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.91, new DateTime(2027, 3, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 64.519999999999996, new DateTime(2027, 3, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.6900000000000004, new DateTime(2027, 3, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.149999999999999, new DateTime(2027, 3, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.79, new DateTime(2027, 3, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.85, new DateTime(2027, 3, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.73, new DateTime(2027, 3, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.24, new DateTime(2027, 3, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 52.07, new DateTime(2027, 3, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.109999999999999, new DateTime(2027, 3, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.25, new DateTime(2027, 3, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.9, new DateTime(2027, 3, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 44.140000000000001, new DateTime(2027, 3, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.879999999999999, new DateTime(2027, 3, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.100000000000001, new DateTime(2027, 3, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 71.390000000000001, new DateTime(2027, 3, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.68, new DateTime(2027, 3, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.5, new DateTime(2027, 3, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 43.920000000000002, new DateTime(2027, 3, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.109999999999999, new DateTime(2027, 3, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.309999999999999, new DateTime(2027, 3, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.359999999999999, new DateTime(2027, 3, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.689999999999998, new DateTime(2027, 4, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.800000000000001, new DateTime(2027, 4, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.54, new DateTime(2027, 4, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.129999999999999, new DateTime(2027, 4, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 70.040000000000006, new DateTime(2027, 4, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 66.200000000000003, new DateTime(2027, 4, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.52, new DateTime(2027, 4, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 32.579999999999998, new DateTime(2027, 4, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.989999999999998, new DateTime(2027, 4, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.5899999999999999, new DateTime(2027, 4, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 44.0, new DateTime(2027, 4, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.68, new DateTime(2027, 4, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.1099999999999994, new DateTime(2027, 4, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.35, new DateTime(2027, 4, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.9000000000000004, new DateTime(2027, 4, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 78.480000000000004, new DateTime(2027, 4, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.170000000000002, new DateTime(2027, 4, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.02, new DateTime(2027, 4, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 63.039999999999999, new DateTime(2027, 4, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.4000000000000004, new DateTime(2027, 4, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.289999999999999, new DateTime(2027, 4, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 70.0, new DateTime(2027, 4, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.559999999999999, new DateTime(2027, 4, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.52, new DateTime(2027, 4, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.140000000000001, new DateTime(2027, 4, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.07, new DateTime(2027, 4, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.350000000000001, new DateTime(2027, 4, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.840000000000003, new DateTime(2027, 4, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.8100000000000001, new DateTime(2027, 4, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 55.189999999999998, new DateTime(2027, 4, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.780000000000001, new DateTime(2027, 4, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.559999999999999, new DateTime(2027, 4, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.210000000000001, new DateTime(2027, 4, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.5899999999999999, new DateTime(2027, 4, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.869999999999999, new DateTime(2027, 4, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.0899999999999999, new DateTime(2027, 4, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.6200000000000001, new DateTime(2027, 4, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.17, new DateTime(2027, 4, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.6100000000000003, new DateTime(2027, 4, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.1900000000000004, new DateTime(2027, 4, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.6399999999999997, new DateTime(2027, 4, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.9500000000000002, new DateTime(2027, 4, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.3900000000000001, new DateTime(2027, 4, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.16, new DateTime(2027, 4, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.170000000000002, new DateTime(2027, 4, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.9800000000000004, new DateTime(2027, 4, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.08, new DateTime(2027, 4, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.629999999999999, new DateTime(2027, 4, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.76, new DateTime(2027, 4, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.8499999999999996, new DateTime(2027, 4, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.920000000000002, new DateTime(2027, 4, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.07, new DateTime(2027, 4, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.640000000000001, new DateTime(2027, 4, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.379999999999999, new DateTime(2027, 4, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.91, new DateTime(2027, 4, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.359999999999999, new DateTime(2027, 4, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 77.829999999999998, new DateTime(2027, 5, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.640000000000001, new DateTime(2027, 5, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.119999999999997, new DateTime(2027, 5, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.9500000000000002, new DateTime(2027, 5, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.6499999999999999, new DateTime(2027, 5, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.440000000000001, new DateTime(2027, 5, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.949999999999999, new DateTime(2027, 5, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.32, new DateTime(2027, 5, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.490000000000002, new DateTime(2027, 5, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.29, new DateTime(2027, 5, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.489999999999998, new DateTime(2027, 5, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.04, new DateTime(2027, 5, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.79, new DateTime(2027, 5, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 68.659999999999997, new DateTime(2027, 5, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.120000000000001, new DateTime(2027, 5, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.359999999999999, new DateTime(2027, 5, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.260000000000002, new DateTime(2027, 5, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.5499999999999998, new DateTime(2027, 5, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.75, new DateTime(2027, 5, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.5899999999999999, new DateTime(2027, 5, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 57.719999999999999, new DateTime(2027, 5, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.69, new DateTime(2027, 5, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.23, new DateTime(2027, 5, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.6100000000000003, new DateTime(2027, 5, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.280000000000001, new DateTime(2027, 5, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.9500000000000002, new DateTime(2027, 5, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.710000000000001, new DateTime(2027, 5, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.73, new DateTime(2027, 5, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.91, new DateTime(2027, 5, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.4100000000000001, new DateTime(2027, 5, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.25, new DateTime(2027, 5, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.26, new DateTime(2027, 5, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.7300000000000004, new DateTime(2027, 5, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.0, new DateTime(2027, 5, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 60.100000000000001, new DateTime(2027, 5, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.600000000000001, new DateTime(2027, 5, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 49.5, new DateTime(2027, 5, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.24, new DateTime(2027, 5, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.609999999999999, new DateTime(2027, 5, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 31.949999999999999, new DateTime(2027, 5, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.15, new DateTime(2027, 5, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.359999999999999, new DateTime(2027, 5, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.29, new DateTime(2027, 5, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.440000000000001, new DateTime(2027, 5, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.690000000000001, new DateTime(2027, 5, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.25, new DateTime(2027, 5, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.890000000000001, new DateTime(2027, 5, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.5, new DateTime(2027, 5, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.08, new DateTime(2027, 5, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 60.039999999999999, new DateTime(2027, 5, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.3500000000000001, new DateTime(2027, 5, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.26, new DateTime(2027, 5, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.19, new DateTime(2027, 5, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.039999999999999, new DateTime(2027, 5, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.8700000000000001, new DateTime(2027, 5, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.359999999999999, new DateTime(2027, 5, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.890000000000001, new DateTime(2027, 5, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.210000000000001, new DateTime(2027, 5, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.82, new DateTime(2027, 5, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 81.0, new DateTime(2027, 5, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.220000000000001, new DateTime(2027, 5, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.949999999999999, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.310000000000002, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.119999999999999, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.48, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.66, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.640000000000001, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.34, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.1299999999999999, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.81, new DateTime(2027, 5, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.710000000000001, new DateTime(2027, 5, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.23, new DateTime(2027, 5, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.4900000000000002, new DateTime(2027, 5, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 52.969999999999999, new DateTime(2027, 5, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.42, new DateTime(2027, 5, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.379999999999999, new DateTime(2027, 5, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.899999999999999, new DateTime(2027, 6, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.969999999999999, new DateTime(2027, 6, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.8300000000000001, new DateTime(2027, 6, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 56.350000000000001, new DateTime(2027, 6, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.420000000000002, new DateTime(2027, 6, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.8699999999999992, new DateTime(2027, 6, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.5800000000000001, new DateTime(2027, 6, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.75, new DateTime(2027, 6, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.08, new DateTime(2027, 6, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.210000000000001, new DateTime(2027, 6, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 38.600000000000001, new DateTime(2027, 6, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.52, new DateTime(2027, 6, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.350000000000001, new DateTime(2027, 6, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.7200000000000002, new DateTime(2027, 6, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.49, new DateTime(2027, 6, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.79, new DateTime(2027, 6, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.5499999999999998, new DateTime(2027, 6, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.299999999999997, new DateTime(2027, 6, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.15, new DateTime(2027, 6, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 47.950000000000003, new DateTime(2027, 6, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 57.619999999999997, new DateTime(2027, 6, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.370000000000001, new DateTime(2027, 6, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.82, new DateTime(2027, 6, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.859999999999999, new DateTime(2027, 6, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.93, new DateTime(2027, 6, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.399999999999999, new DateTime(2027, 6, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.359999999999999, new DateTime(2027, 6, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.27, new DateTime(2027, 6, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.32, new DateTime(2027, 6, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.48, new DateTime(2027, 6, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 41.039999999999999, new DateTime(2027, 6, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.030000000000001, new DateTime(2027, 6, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.140000000000001, new DateTime(2027, 6, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 50.030000000000001, new DateTime(2027, 6, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 64.879999999999995, new DateTime(2027, 6, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.16, new DateTime(2027, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.42, new DateTime(2027, 6, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.109999999999999, new DateTime(2027, 6, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.300000000000001, new DateTime(2027, 6, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 43.18, new DateTime(2027, 6, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.800000000000001, new DateTime(2027, 6, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.379999999999999, new DateTime(2027, 6, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.0, new DateTime(2027, 6, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.4000000000000004, new DateTime(2027, 6, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.869999999999999, new DateTime(2027, 6, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.0899999999999999, new DateTime(2027, 6, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.93, new DateTime(2027, 6, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.719999999999999, new DateTime(2027, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 35.439999999999998, new DateTime(2027, 6, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.949999999999999, new DateTime(2027, 6, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.1200000000000001, new DateTime(2027, 7, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.670000000000002, new DateTime(2027, 7, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.870000000000001, new DateTime(2027, 7, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 44.600000000000001, new DateTime(2027, 7, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 46.0, new DateTime(2027, 7, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 78.209999999999994, new DateTime(2027, 7, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.140000000000001, new DateTime(2027, 7, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.489999999999998, new DateTime(2027, 7, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.23, new DateTime(2027, 7, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.2400000000000002, new DateTime(2027, 7, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.109999999999999, new DateTime(2027, 7, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.32, new DateTime(2027, 7, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.609999999999999, new DateTime(2027, 7, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 844,
                column: "Date",
                value: new DateTime(2027, 7, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.6400000000000001, new DateTime(2027, 7, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.470000000000001, new DateTime(2027, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.050000000000001, new DateTime(2027, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.199999999999999, new DateTime(2027, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.5599999999999996, new DateTime(2027, 7, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.73, new DateTime(2027, 7, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.82, new DateTime(2027, 7, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.3100000000000005, new DateTime(2027, 7, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.82, new DateTime(2027, 7, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.379999999999999, new DateTime(2027, 7, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 39.520000000000003, new DateTime(2027, 7, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 44.390000000000001, new DateTime(2027, 7, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.91, new DateTime(2027, 7, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.010000000000002, new DateTime(2027, 7, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.359999999999999, new DateTime(2027, 7, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.5, new DateTime(2027, 7, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.600000000000001, new DateTime(2027, 7, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.710000000000001, new DateTime(2027, 7, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.010000000000002, new DateTime(2027, 7, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.2000000000000002, new DateTime(2027, 7, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.399999999999999, new DateTime(2027, 7, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.27, new DateTime(2027, 7, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.25, new DateTime(2027, 7, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.66, new DateTime(2027, 7, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.3399999999999999, new DateTime(2027, 7, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.670000000000002, new DateTime(2027, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.1699999999999999, new DateTime(2027, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.85, new DateTime(2027, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 53.859999999999999, new DateTime(2027, 7, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.77, new DateTime(2027, 7, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.899999999999999, new DateTime(2027, 7, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.4100000000000001, new DateTime(2027, 7, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.7199999999999998, new DateTime(2027, 7, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.6600000000000001, new DateTime(2027, 7, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.58, new DateTime(2027, 7, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.699999999999999, new DateTime(2027, 7, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.460000000000001, new DateTime(2027, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.96, new DateTime(2027, 7, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.809999999999999, new DateTime(2027, 7, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.59, new DateTime(2027, 7, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.8599999999999994, new DateTime(2027, 7, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.920000000000002, new DateTime(2027, 7, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.52, new DateTime(2027, 7, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.07, new DateTime(2027, 7, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.9500000000000002, new DateTime(2027, 7, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.280000000000001, new DateTime(2027, 8, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 61.560000000000002, new DateTime(2027, 8, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.550000000000001, new DateTime(2027, 8, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.649999999999999, new DateTime(2027, 8, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.149999999999999, new DateTime(2027, 8, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 41.219999999999999, new DateTime(2027, 8, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 42.859999999999999, new DateTime(2027, 8, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.93, new DateTime(2027, 8, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.890000000000001, new DateTime(2027, 8, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.52, new DateTime(2027, 8, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.0199999999999996, new DateTime(2027, 8, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.7999999999999998, new DateTime(2027, 8, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.43, new DateTime(2027, 8, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 76.299999999999997, new DateTime(2027, 8, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.129999999999999, new DateTime(2027, 8, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.73, new DateTime(2027, 8, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.68, new DateTime(2027, 8, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 32.590000000000003, new DateTime(2027, 8, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.5899999999999999, new DateTime(2027, 8, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.6800000000000002, new DateTime(2027, 8, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.52, new DateTime(2027, 8, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 89.099999999999994, new DateTime(2027, 8, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.21, new DateTime(2027, 8, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 50.82, new DateTime(2027, 8, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.380000000000001, new DateTime(2027, 8, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.07, new DateTime(2027, 8, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.780000000000001, new DateTime(2027, 8, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 26.829999999999998, new DateTime(2027, 8, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.0600000000000001, new DateTime(2027, 8, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.550000000000001, new DateTime(2027, 8, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.7300000000000004, new DateTime(2027, 8, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.99, new DateTime(2027, 8, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.8900000000000001, new DateTime(2027, 8, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.629999999999999, new DateTime(2027, 8, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.289999999999999, new DateTime(2027, 8, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.899999999999999, new DateTime(2027, 8, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.9000000000000004, new DateTime(2027, 8, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.0600000000000001, new DateTime(2027, 8, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 37.380000000000003, new DateTime(2027, 8, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.030000000000001, new DateTime(2027, 8, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 1.3899999999999999, new DateTime(2027, 8, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.2000000000000002, new DateTime(2027, 8, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.1899999999999995, new DateTime(2027, 8, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.4199999999999999, new DateTime(2027, 8, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.710000000000001, new DateTime(2027, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.0300000000000002, new DateTime(2027, 8, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.8099999999999996, new DateTime(2027, 8, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 25.690000000000001, new DateTime(2027, 8, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.289999999999999, new DateTime(2027, 8, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.0099999999999998, new DateTime(2027, 8, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.4199999999999999, new DateTime(2027, 8, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.829999999999998, new DateTime(2027, 8, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.8399999999999999, new DateTime(2027, 8, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 4.3600000000000003, new DateTime(2027, 8, 29, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.73, new DateTime(2027, 8, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 17.25, new DateTime(2027, 8, 30, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.6800000000000002, new DateTime(2027, 8, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.74, new DateTime(2027, 8, 31, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.27, new DateTime(2027, 9, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.280000000000001, new DateTime(2027, 9, 1, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.06, new DateTime(2027, 9, 2, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.3499999999999996, new DateTime(2027, 9, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.289999999999999, new DateTime(2027, 9, 3, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 12.470000000000001, new DateTime(2027, 9, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 20.34, new DateTime(2027, 9, 4, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.0199999999999996, new DateTime(2027, 9, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.140000000000001, new DateTime(2027, 9, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 33.700000000000003, new DateTime(2027, 9, 5, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 27.559999999999999, new DateTime(2027, 9, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.210000000000001, new DateTime(2027, 9, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 10.699999999999999, new DateTime(2027, 9, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 29.57, new DateTime(2027, 9, 6, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 28.379999999999999, new DateTime(2027, 9, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 36.479999999999997, new DateTime(2027, 9, 7, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.880000000000003, new DateTime(2027, 9, 8, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 2.3599999999999999, new DateTime(2027, 9, 9, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.32, new DateTime(2027, 9, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.59, new DateTime(2027, 9, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.460000000000001, new DateTime(2027, 9, 10, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 11.890000000000001, new DateTime(2027, 9, 11, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.9500000000000002, new DateTime(2027, 9, 12, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 6.29, new DateTime(2027, 9, 13, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 18.18, new DateTime(2027, 9, 14, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 34.850000000000001, new DateTime(2027, 9, 15, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 15.07, new DateTime(2027, 9, 16, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 23.98, new DateTime(2027, 9, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 13.130000000000001, new DateTime(2027, 9, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.3700000000000001, new DateTime(2027, 9, 17, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 16.010000000000002, new DateTime(2027, 9, 18, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.8399999999999999, new DateTime(2027, 9, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 21.32, new DateTime(2027, 9, 19, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.850000000000001, new DateTime(2027, 9, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.8300000000000001, new DateTime(2027, 9, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 31.100000000000001, new DateTime(2027, 9, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 22.609999999999999, new DateTime(2027, 9, 20, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 45.68, new DateTime(2027, 9, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 3.9700000000000002, new DateTime(2027, 9, 21, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.640000000000001, new DateTime(2027, 9, 22, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 8.3399999999999999, new DateTime(2027, 9, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 9.2699999999999996, new DateTime(2027, 9, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 43.590000000000003, new DateTime(2027, 9, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 19.73, new DateTime(2027, 9, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.039999999999999, new DateTime(2027, 9, 23, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 50.119999999999997, new DateTime(2027, 9, 24, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.49, new DateTime(2027, 9, 25, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.27, new DateTime(2027, 9, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 24.84, new DateTime(2027, 9, 26, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 14.77, new DateTime(2027, 9, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 5.2999999999999998, new DateTime(2027, 9, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 7.4100000000000001, new DateTime(2027, 9, 27, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Amount", "Date" },
                values: new object[] { 30.329999999999998, new DateTime(2027, 9, 28, 15, 14, 39, 912, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_BusinessCategories_CategoryId",
                table: "Transactions",
                column: "CategoryId",
                principalTable: "BusinessCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_BusinessSuppliers_SupplierId",
                table: "Transactions",
                column: "SupplierId",
                principalTable: "BusinessSuppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
