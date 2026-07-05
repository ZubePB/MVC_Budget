using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Budget.Migrations
{
    /// <inheritdoc />
    public partial class tryAddSuppliers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfTransactions = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Wood", 2363.7399999999998 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Aluminium", 1975.73 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Iron", 1943.3599999999999 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Stainless Steel", 1913.1800000000001 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Screws", 1790.8699999999999 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Wood Tools", 2614.48 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Door Accessories", 2050.1399999999999 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Glass", 2011.03 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Metal Tools", 2360.8600000000001 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Glass Accessories", 2194.5599999999999 });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Name", "NumberOfTransaction", "TotalAmount" },
                values: new object[,]
                {
                    { 1, "Glasson", 300, 0.0 },
                    { 2, "Bauhaus", 200, 0.0 },
                    { 3, "Scierie de Romont", 100, 0.0 },
                    { 4, "Sofraver SA", 200, 0.0 },
                    { 5, "Commerce de Fer Fribourgeois", 200, 0.0 }
                });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.030000000000001, new DateTime(2026, 5, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_0", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.8600000000000003, new DateTime(2026, 5, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_0", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.7800000000000002, new DateTime(2026, 5, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_0", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 53.18, new DateTime(2026, 5, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_0", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.850000000000001, new DateTime(2026, 5, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_0", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.8100000000000005, new DateTime(2026, 5, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_0", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.710000000000001, new DateTime(2026, 5, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_0", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.85, new DateTime(2026, 5, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_0", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.109999999999999, new DateTime(2026, 5, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_0", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 70.879999999999995, new DateTime(2026, 5, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_1", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 57.840000000000003, new DateTime(2026, 5, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_1", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.710000000000001, new DateTime(2026, 5, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_1", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.25, new DateTime(2026, 5, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_1", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.4499999999999993, new DateTime(2026, 5, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_1", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.039999999999999, new DateTime(2026, 5, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_1", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.5, new DateTime(2026, 5, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_1", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 61.460000000000001, new DateTime(2026, 5, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_1", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 42.810000000000002, new DateTime(2026, 5, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_1", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.550000000000001, new DateTime(2026, 5, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_1", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 47.539999999999999, new DateTime(2026, 5, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_2", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.530000000000001, new DateTime(2026, 5, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_2", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.140000000000001, new DateTime(2026, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_2", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.0, new DateTime(2026, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_2", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.6199999999999992, new DateTime(2026, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_2", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.059999999999999, new DateTime(2026, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_2", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.3500000000000001, new DateTime(2026, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_2", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 56.149999999999999, new DateTime(2026, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_2", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.32, new DateTime(2026, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_2", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.5599999999999996, new DateTime(2026, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_2", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.359999999999999, new DateTime(2026, 6, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_3", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.51, new DateTime(2026, 6, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_3", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.950000000000003, new DateTime(2026, 6, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_3", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 51.439999999999998, new DateTime(2026, 6, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_3", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.27, new DateTime(2026, 6, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_3", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.0, new DateTime(2026, 6, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_3", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.149999999999999, new DateTime(2026, 6, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_3", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.9699999999999998, new DateTime(2026, 6, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_3", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.5500000000000007, new DateTime(2026, 6, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_3", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.800000000000001, new DateTime(2026, 6, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_3", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 43.479999999999997, new DateTime(2026, 6, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_4", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.4199999999999999, new DateTime(2026, 6, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_4", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 58.450000000000003, new DateTime(2026, 6, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_4", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.5399999999999991, new DateTime(2026, 6, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_4", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.68, new DateTime(2026, 6, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_4", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 43.770000000000003, new DateTime(2026, 6, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_4", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.43, new DateTime(2026, 6, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_4", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.440000000000001, new DateTime(2026, 6, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_4", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.420000000000002, new DateTime(2026, 6, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_4", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 45.409999999999997, new DateTime(2026, 6, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_4", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.789999999999999, new DateTime(2026, 6, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_5", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 46.530000000000001, new DateTime(2026, 6, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_5", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.940000000000001, new DateTime(2026, 6, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_5", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 39.219999999999999, new DateTime(2026, 6, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_5", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.7599999999999998, new DateTime(2026, 6, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_5", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 39.149999999999999, new DateTime(2026, 6, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_5", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.969999999999999, new DateTime(2026, 6, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_5", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.16, new DateTime(2026, 6, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_5", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.609999999999999, new DateTime(2026, 6, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_5", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.960000000000001, new DateTime(2026, 6, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_5", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.7300000000000004, new DateTime(2026, 6, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_6", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.300000000000001, new DateTime(2026, 6, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_6", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.359999999999999, new DateTime(2026, 6, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_6", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.76, new DateTime(2026, 6, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_6", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.5899999999999999, new DateTime(2026, 6, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_6", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.02, new DateTime(2026, 6, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_6", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.2800000000000002, new DateTime(2026, 6, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_6", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.2999999999999998, new DateTime(2026, 6, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_6", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.140000000000001, new DateTime(2026, 6, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_6", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 63.960000000000001, new DateTime(2026, 6, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_6", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.49, new DateTime(2026, 6, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_7", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 48.380000000000003, new DateTime(2026, 6, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_7", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.2300000000000004, new DateTime(2026, 6, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_7", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 39.840000000000003, new DateTime(2026, 6, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_7", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.0, new DateTime(2026, 6, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_7", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.390000000000001, new DateTime(2026, 6, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_7", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.969999999999999, new DateTime(2026, 6, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_7", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.370000000000001, new DateTime(2026, 6, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_7", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.57, new DateTime(2026, 6, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_7", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.359999999999999, new DateTime(2026, 6, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_7", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.8899999999999997, new DateTime(2026, 6, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_8", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.6099999999999999, new DateTime(2026, 6, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_8", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.579999999999998, new DateTime(2026, 6, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_8", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.0899999999999999, new DateTime(2026, 6, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_8", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.3999999999999999, new DateTime(2026, 6, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_8", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.7200000000000002, new DateTime(2026, 6, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_8", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.9100000000000001, new DateTime(2026, 6, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_8", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.5999999999999996, new DateTime(2026, 6, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_8", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.6899999999999995, new DateTime(2026, 6, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_8", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.1199999999999992, new DateTime(2026, 6, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_8", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.41, new DateTime(2026, 6, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_9", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.5800000000000001, new DateTime(2026, 6, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_9", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.71, new DateTime(2026, 6, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_9", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.489999999999998, new DateTime(2026, 6, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_9", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.010000000000002, new DateTime(2026, 6, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_9", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.550000000000001, new DateTime(2026, 6, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_9", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.51, new DateTime(2026, 6, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_9", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.0, new DateTime(2026, 6, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_9", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 57.030000000000001, new DateTime(2026, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_9", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.260000000000002, new DateTime(2026, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_9", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.4, new DateTime(2026, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_10", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.1099999999999999, new DateTime(2026, 6, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_10", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.1099999999999994, new DateTime(2026, 6, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_10", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.5, new DateTime(2026, 6, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_10", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.29, new DateTime(2026, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_10", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.09, new DateTime(2026, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_10", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.960000000000001, new DateTime(2026, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_10", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.3799999999999999, new DateTime(2026, 6, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_10", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 43.670000000000002, new DateTime(2026, 6, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_10", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.359999999999999, new DateTime(2026, 6, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_10", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.91, new DateTime(2026, 7, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_11", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.620000000000001, new DateTime(2026, 7, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_11", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.890000000000001, new DateTime(2026, 7, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_11", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.8700000000000001, new DateTime(2026, 7, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_11", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.9400000000000004, new DateTime(2026, 7, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_11", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.170000000000002, new DateTime(2026, 7, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_11", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.600000000000001, new DateTime(2026, 7, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_11", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 35.700000000000003, new DateTime(2026, 7, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_11", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.42, new DateTime(2026, 7, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_11", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.56, new DateTime(2026, 7, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_11", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.5300000000000002, new DateTime(2026, 7, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_12", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.52, new DateTime(2026, 7, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_12", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.289999999999999, new DateTime(2026, 7, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_12", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.960000000000001, new DateTime(2026, 7, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_12", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.879999999999999, new DateTime(2026, 7, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_12", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.600000000000001, new DateTime(2026, 7, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_12", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 58.810000000000002, new DateTime(2026, 7, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_12", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.899999999999999, new DateTime(2026, 7, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_12", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.300000000000001, new DateTime(2026, 7, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_12", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.4299999999999997, new DateTime(2026, 7, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_12", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.359999999999999, new DateTime(2026, 7, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_13", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.420000000000002, new DateTime(2026, 7, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_13", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.5199999999999996, new DateTime(2026, 7, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_13", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.949999999999999, new DateTime(2026, 7, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_13", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.1600000000000001, new DateTime(2026, 7, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_13", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 35.649999999999999, new DateTime(2026, 7, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_13", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.8400000000000001, new DateTime(2026, 7, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_13", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.700000000000003, new DateTime(2026, 7, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_13", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.870000000000001, new DateTime(2026, 7, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_13", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.65, new DateTime(2026, 7, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_13", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.2599999999999998, new DateTime(2026, 7, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_14", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.039999999999999, new DateTime(2026, 7, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_14", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.710000000000001, new DateTime(2026, 7, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_14", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 40.57, new DateTime(2026, 7, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_14", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.8799999999999999, new DateTime(2026, 7, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_14", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.949999999999999, new DateTime(2026, 7, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_14", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.300000000000001, new DateTime(2026, 7, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_14", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.800000000000001, new DateTime(2026, 7, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_14", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.199999999999999, new DateTime(2026, 7, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_14", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 50.670000000000002, new DateTime(2026, 7, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_14", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.2200000000000002, new DateTime(2026, 7, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_15", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.700000000000003, new DateTime(2026, 7, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_15", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.98, new DateTime(2026, 7, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_15", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.399999999999999, new DateTime(2026, 7, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_15", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.74, new DateTime(2026, 7, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_15", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.949999999999999, new DateTime(2026, 7, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_15", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.8800000000000008, new DateTime(2026, 7, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_15", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 64.040000000000006, new DateTime(2026, 7, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_15", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.51, new DateTime(2026, 7, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_15", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.24, new DateTime(2026, 7, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_15", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.9100000000000001, new DateTime(2026, 7, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_16", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.6200000000000001, new DateTime(2026, 7, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_16", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.9399999999999999, new DateTime(2026, 7, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_16", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.25, new DateTime(2026, 7, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_16", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.75, new DateTime(2026, 8, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_16", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.4400000000000004, new DateTime(2026, 8, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_16", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.379999999999999, new DateTime(2026, 8, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_16", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.68, new DateTime(2026, 8, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_16", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.859999999999999, new DateTime(2026, 8, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_16", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.940000000000001, new DateTime(2026, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_16", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.970000000000001, new DateTime(2026, 8, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_17", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.210000000000001, new DateTime(2026, 8, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_17", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.0600000000000001, new DateTime(2026, 8, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_17", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.3799999999999999, new DateTime(2026, 8, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_17", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.199999999999999, new DateTime(2026, 8, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_17", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.25, new DateTime(2026, 8, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_17", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.1200000000000001, new DateTime(2026, 8, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_17", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.0, new DateTime(2026, 8, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_17", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.079999999999998, new DateTime(2026, 8, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_17", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.100000000000001, new DateTime(2026, 8, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_17", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.190000000000001, new DateTime(2026, 8, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_18", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.229999999999997, new DateTime(2026, 8, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_18", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.1200000000000001, new DateTime(2026, 8, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_18", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.9699999999999998, new DateTime(2026, 8, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_18", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.460000000000001, new DateTime(2026, 8, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_18", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.0, new DateTime(2026, 8, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_18", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 39.0, new DateTime(2026, 8, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_18", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.81, new DateTime(2026, 8, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_18", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.59, new DateTime(2026, 8, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_18", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.07, new DateTime(2026, 8, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_18", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.670000000000002, new DateTime(2026, 8, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_19", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.300000000000001, new DateTime(2026, 8, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_19", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.48, new DateTime(2026, 8, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_19", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.809999999999999, new DateTime(2026, 8, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_19", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.879999999999999, new DateTime(2026, 8, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_19", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.9, new DateTime(2026, 8, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_19", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.0899999999999999, new DateTime(2026, 8, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_19", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 42.579999999999998, new DateTime(2026, 8, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_19", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.9100000000000001, new DateTime(2026, 8, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_19", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.899999999999999, new DateTime(2026, 8, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_19", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.289999999999999, new DateTime(2026, 8, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_20", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.329999999999998, new DateTime(2026, 8, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_20", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.379999999999999, new DateTime(2026, 8, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_20", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.699999999999999, new DateTime(2026, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_20", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.3499999999999996, new DateTime(2026, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_20", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.5900000000000001, new DateTime(2026, 8, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_20", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.670000000000002, new DateTime(2026, 8, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_20", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.4600000000000009, new DateTime(2026, 8, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_20", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.470000000000001, new DateTime(2026, 8, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_20", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.449999999999999, new DateTime(2026, 8, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_20", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.9000000000000004, new DateTime(2026, 8, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_21", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.32, new DateTime(2026, 8, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_21", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.030000000000001, new DateTime(2026, 9, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_21", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.609999999999999, new DateTime(2026, 9, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_21", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.06, new DateTime(2026, 9, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_21", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.45, new DateTime(2026, 9, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_21", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.620000000000001, new DateTime(2026, 9, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_21", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.54, new DateTime(2026, 9, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_21", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.059999999999999, new DateTime(2026, 9, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_21", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.649999999999999, new DateTime(2026, 9, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_21", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 66.75, new DateTime(2026, 9, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_22", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.3799999999999999, new DateTime(2026, 9, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_22", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.969999999999999, new DateTime(2026, 9, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_22", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 34.100000000000001, new DateTime(2026, 9, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_22", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.76, new DateTime(2026, 9, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_22", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 90.950000000000003, new DateTime(2026, 9, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_22", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.59, new DateTime(2026, 9, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_22", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.32, new DateTime(2026, 9, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_22", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.649999999999999, new DateTime(2026, 9, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_22", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.760000000000002, new DateTime(2026, 9, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_22", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.699999999999999, new DateTime(2026, 9, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_23", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.989999999999998, new DateTime(2026, 9, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_23", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.2899999999999991, new DateTime(2026, 9, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_23", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.6799999999999997, new DateTime(2026, 9, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_23", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.710000000000001, new DateTime(2026, 9, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_23", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.890000000000001, new DateTime(2026, 9, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_23", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 42.219999999999999, new DateTime(2026, 9, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_23", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.369999999999999, new DateTime(2026, 9, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_23", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.43, new DateTime(2026, 9, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_23", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.7000000000000002, new DateTime(2026, 9, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_23", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.050000000000001, new DateTime(2026, 9, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_24", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.140000000000001, new DateTime(2026, 9, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_24", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 66.730000000000004, new DateTime(2026, 9, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_24", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.93, new DateTime(2026, 9, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_24", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.510000000000002, new DateTime(2026, 9, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_24", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.049999999999997, new DateTime(2026, 9, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_24", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.380000000000001, new DateTime(2026, 9, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_24", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.8499999999999996, new DateTime(2026, 9, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_24", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.41, new DateTime(2026, 9, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_24", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.619999999999999, new DateTime(2026, 9, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_24", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.689999999999998, new DateTime(2026, 9, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_25", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 40.5, new DateTime(2026, 9, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_25", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.0700000000000003, new DateTime(2026, 9, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_25", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 39.189999999999998, new DateTime(2026, 9, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_25", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.99, new DateTime(2026, 9, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_25", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.859999999999999, new DateTime(2026, 9, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_25", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.54, new DateTime(2026, 9, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_25", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.710000000000001, new DateTime(2026, 9, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_25", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.199999999999999, new DateTime(2026, 9, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_25", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.190000000000001, new DateTime(2026, 9, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_25", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.7599999999999998, new DateTime(2026, 9, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_26", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.8100000000000005, new DateTime(2026, 9, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_26", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.7400000000000002, new DateTime(2026, 9, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_26", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.0300000000000002, new DateTime(2026, 9, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_26", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.8399999999999999, new DateTime(2026, 9, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_26", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.59, new DateTime(2026, 9, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_26", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.780000000000001, new DateTime(2026, 9, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_26", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.210000000000001, new DateTime(2026, 10, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_26", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.219999999999999, new DateTime(2026, 10, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_26", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.57, new DateTime(2026, 10, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_26", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.629999999999999, new DateTime(2026, 10, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_27", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.399999999999999, new DateTime(2026, 10, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_27", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 48.969999999999999, new DateTime(2026, 10, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_27", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.329999999999998, new DateTime(2026, 10, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_27", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.91, new DateTime(2026, 10, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_27", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.220000000000001, new DateTime(2026, 10, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_27", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 53.960000000000001, new DateTime(2026, 10, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_27", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.870000000000001, new DateTime(2026, 10, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_27", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.1999999999999993, new DateTime(2026, 10, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_27", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.579999999999998, new DateTime(2026, 10, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_27", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.780000000000001, new DateTime(2026, 10, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_28", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.609999999999999, new DateTime(2026, 10, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_28", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.7999999999999998, new DateTime(2026, 10, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_28", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.800000000000001, new DateTime(2026, 10, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_28", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.4900000000000002, new DateTime(2026, 10, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_28", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.48, new DateTime(2026, 10, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_28", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.4100000000000001, new DateTime(2026, 10, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_28", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.960000000000001, new DateTime(2026, 10, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_28", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 40.68, new DateTime(2026, 10, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_28", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.91, new DateTime(2026, 10, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_28", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.050000000000001, new DateTime(2026, 10, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_29", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.740000000000002, new DateTime(2026, 10, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_29", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.0999999999999996, new DateTime(2026, 10, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_29", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.9900000000000002, new DateTime(2026, 10, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_29", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.510000000000002, new DateTime(2026, 10, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_29", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.619999999999997, new DateTime(2026, 10, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_29", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.289999999999999, new DateTime(2026, 10, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_29", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.8900000000000001, new DateTime(2026, 10, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_29", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.0500000000000007, new DateTime(2026, 10, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_29", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.859999999999999, new DateTime(2026, 10, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_29", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.640000000000001, new DateTime(2026, 10, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_30", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.1799999999999997, new DateTime(2026, 10, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_30", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.379999999999999, new DateTime(2026, 10, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_30", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.170000000000002, new DateTime(2026, 10, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_30", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.57, new DateTime(2026, 10, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_30", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.800000000000001, new DateTime(2026, 10, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_30", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.850000000000001, new DateTime(2026, 10, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_30", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.219999999999999, new DateTime(2026, 10, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_30", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.390000000000001, new DateTime(2026, 10, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_30", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.149999999999999, new DateTime(2026, 10, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_30", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.890000000000001, new DateTime(2026, 10, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_31", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.16, new DateTime(2026, 10, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_31", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.170000000000002, new DateTime(2026, 10, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_31", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.43, new DateTime(2026, 10, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_31", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 76.159999999999997, new DateTime(2026, 10, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_31", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.25, new DateTime(2026, 11, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_31", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.5, new DateTime(2026, 11, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_31", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.620000000000001, new DateTime(2026, 11, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_31", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.2599999999999998, new DateTime(2026, 11, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_31", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.66, new DateTime(2026, 11, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_31", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 42.299999999999997, new DateTime(2026, 11, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_32", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.539999999999999, new DateTime(2026, 11, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_32", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.969999999999999, new DateTime(2026, 11, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_32", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.210000000000001, new DateTime(2026, 11, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_32", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.3300000000000001, new DateTime(2026, 11, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_32", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.960000000000001, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_32", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.41, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_32", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.1399999999999997, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_32", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.949999999999999, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_32", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 58.030000000000001, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_32", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.460000000000001, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_33", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.44, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_33", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 42.149999999999999, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_33", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.75, new DateTime(2026, 11, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_33", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.5900000000000001, new DateTime(2026, 11, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_33", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.9900000000000002, new DateTime(2026, 11, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_33", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.109999999999999, new DateTime(2026, 11, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_33", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.050000000000001, new DateTime(2026, 11, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_33", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.0, new DateTime(2026, 11, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_33", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.7699999999999996, new DateTime(2026, 11, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_33", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 45.340000000000003, new DateTime(2026, 11, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_34", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.7400000000000002, new DateTime(2026, 11, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_34", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.289999999999999, new DateTime(2026, 11, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_34", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 49.420000000000002, new DateTime(2026, 11, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_34", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.439999999999998, new DateTime(2026, 11, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_34", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.770000000000003, new DateTime(2026, 11, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_34", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 73.650000000000006, new DateTime(2026, 11, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_34", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.690000000000001, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_34", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 35.119999999999997, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_34", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.260000000000002, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_34", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.420000000000002, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_35", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.2300000000000004, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_35", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.44, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_35", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.719999999999999, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_35", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.5499999999999998, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_35", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.210000000000001, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_35", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.719999999999999, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_35", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.719999999999999, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_35", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.57, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_35", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 65.269999999999996, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_35", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.079999999999998, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_36", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.300000000000001, new DateTime(2026, 11, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_36", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 50.969999999999999, new DateTime(2026, 11, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_36", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.3900000000000006, new DateTime(2026, 11, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_36", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.289999999999999, new DateTime(2026, 11, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_36", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.279999999999999, new DateTime(2026, 11, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_36", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.77, new DateTime(2026, 11, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_36", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.779999999999999, new DateTime(2026, 11, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_36", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 40.890000000000001, new DateTime(2026, 11, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_36", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.93, new DateTime(2026, 11, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_36", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.23, new DateTime(2026, 11, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_37", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.119999999999999, new DateTime(2026, 11, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_37", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.879999999999999, new DateTime(2026, 11, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_37", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.57, new DateTime(2026, 11, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_37", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.98, new DateTime(2026, 11, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_37", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.260000000000002, new DateTime(2026, 11, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_37", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.4100000000000001, new DateTime(2026, 11, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_37", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.75, new DateTime(2026, 11, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_37", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.960000000000001, new DateTime(2026, 11, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_37", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 44.380000000000003, new DateTime(2026, 11, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_37", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.340000000000003, new DateTime(2026, 11, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_38", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.17, new DateTime(2026, 11, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_38", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.0500000000000007, new DateTime(2026, 11, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_38", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.07, new DateTime(2026, 11, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_38", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 75.859999999999999, new DateTime(2026, 11, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_38", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.859999999999999, new DateTime(2026, 11, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_38", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.699999999999999, new DateTime(2026, 11, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_38", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.4400000000000004, new DateTime(2026, 11, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_38", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.710000000000001, new DateTime(2026, 11, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_38", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.8999999999999999, new DateTime(2026, 11, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_38", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.960000000000001, new DateTime(2026, 12, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_39", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.1699999999999999, new DateTime(2026, 12, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_39", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.329999999999998, new DateTime(2026, 12, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_39", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.1799999999999997, new DateTime(2026, 12, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_39", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.48, new DateTime(2026, 12, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_39", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 43.770000000000003, new DateTime(2026, 12, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_39", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.48, new DateTime(2026, 12, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_39", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.52, new DateTime(2026, 12, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_39", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.5, new DateTime(2026, 12, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_39", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.159999999999997, new DateTime(2026, 12, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_39", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 57.350000000000001, new DateTime(2026, 12, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_40", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.8399999999999999, new DateTime(2026, 12, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_40", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.079999999999998, new DateTime(2026, 12, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_40", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.1000000000000001, new DateTime(2026, 12, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_40", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.8700000000000001, new DateTime(2026, 12, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_40", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.510000000000002, new DateTime(2026, 12, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_40", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.41, new DateTime(2026, 12, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_40", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.7000000000000002, new DateTime(2026, 12, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_40", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.1600000000000001, new DateTime(2026, 12, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_40", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.649999999999999, new DateTime(2026, 12, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_40", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.0, new DateTime(2026, 12, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_41", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 43.380000000000003, new DateTime(2026, 12, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_41", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.359999999999999, new DateTime(2026, 12, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_41", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.8700000000000001, new DateTime(2026, 12, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_41", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.57, new DateTime(2026, 12, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_41", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 49.810000000000002, new DateTime(2026, 12, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_41", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.25, new DateTime(2026, 12, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_41", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.690000000000001, new DateTime(2026, 12, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_41", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.5099999999999998, new DateTime(2026, 12, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_41", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 46.090000000000003, new DateTime(2026, 12, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_41", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.129999999999999, new DateTime(2026, 12, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_42", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.219999999999999, new DateTime(2026, 12, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_42", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.66, new DateTime(2026, 12, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_42", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.440000000000001, new DateTime(2026, 12, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_42", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.920000000000002, new DateTime(2026, 12, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_42", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.359999999999999, new DateTime(2026, 12, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_42", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.75, new DateTime(2026, 12, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_42", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.109999999999999, new DateTime(2026, 12, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_42", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 73.959999999999994, new DateTime(2026, 12, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_42", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.719999999999999, new DateTime(2026, 12, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_42", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.92, new DateTime(2026, 12, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_43", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.449999999999999, new DateTime(2026, 12, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_43", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.85, new DateTime(2026, 12, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_43", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.09, new DateTime(2026, 12, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_43", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.149999999999999, new DateTime(2026, 12, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_43", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.1399999999999997, new DateTime(2026, 12, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_43", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.5, new DateTime(2026, 12, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_43", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 48.420000000000002, new DateTime(2026, 12, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_43", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.300000000000001, new DateTime(2026, 12, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_43", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.2599999999999998, new DateTime(2026, 12, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_43", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.539999999999999, new DateTime(2026, 12, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_44", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.640000000000001, new DateTime(2026, 12, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_44", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.96, new DateTime(2026, 12, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_44", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.41, new DateTime(2026, 12, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_44", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.700000000000003, new DateTime(2026, 12, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_44", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.620000000000001, new DateTime(2026, 12, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_44", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.1, new DateTime(2026, 12, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_44", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.5099999999999998, new DateTime(2026, 12, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_44", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.020000000000003, new DateTime(2026, 12, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_44", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.969999999999999, new DateTime(2026, 12, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_44", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.0, new DateTime(2026, 12, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_45", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.4500000000000002, new DateTime(2026, 12, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_45", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.3600000000000003, new DateTime(2026, 12, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_45", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.140000000000001, new DateTime(2027, 1, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_45", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.140000000000001, new DateTime(2027, 1, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_45", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.670000000000002, new DateTime(2027, 1, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_45", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.0, new DateTime(2027, 1, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_45", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.870000000000001, new DateTime(2027, 1, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_45", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.83, new DateTime(2027, 1, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_45", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.3499999999999996, new DateTime(2027, 1, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_45", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.7799999999999994, new DateTime(2027, 1, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_46", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.09, new DateTime(2027, 1, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_46", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.07, new DateTime(2027, 1, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_46", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.219999999999999, new DateTime(2027, 1, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_46", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.449999999999999, new DateTime(2027, 1, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_46", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 89.819999999999993, new DateTime(2027, 1, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_46", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.329999999999998, new DateTime(2027, 1, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_46", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.879999999999999, new DateTime(2027, 1, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_46", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.370000000000001, new DateTime(2027, 1, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_46", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.18, new DateTime(2027, 1, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_46", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 35.140000000000001, new DateTime(2027, 1, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_47", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.7000000000000002, new DateTime(2027, 1, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_47", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.48, new DateTime(2027, 1, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_47", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.170000000000002, new DateTime(2027, 1, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_47", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.989999999999998, new DateTime(2027, 1, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_47", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.4, new DateTime(2027, 1, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_47", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.149999999999999, new DateTime(2027, 1, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_47", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.399999999999999, new DateTime(2027, 1, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_47", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.07, new DateTime(2027, 1, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_47", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.329999999999998, new DateTime(2027, 1, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_47", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.98, new DateTime(2027, 1, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_48", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.879999999999999, new DateTime(2027, 1, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_48", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.689999999999998, new DateTime(2027, 1, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_48", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.0800000000000001, new DateTime(2027, 1, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_48", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.030000000000001, new DateTime(2027, 1, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_48", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.109999999999999, new DateTime(2027, 1, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_48", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 63.100000000000001, new DateTime(2027, 1, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_48", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 42.210000000000001, new DateTime(2027, 1, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_48", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.1299999999999999, new DateTime(2027, 1, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_48", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.52, new DateTime(2027, 1, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_48", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.3800000000000008, new DateTime(2027, 1, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_49", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.5999999999999996, new DateTime(2027, 1, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_49", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.239999999999998, new DateTime(2027, 1, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_49", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.1699999999999999, new DateTime(2027, 1, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_49", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.259999999999998, new DateTime(2027, 1, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_49", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.870000000000001, new DateTime(2027, 1, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_49", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.5600000000000001, new DateTime(2027, 1, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_49", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.100000000000001, new DateTime(2027, 1, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_49", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.949999999999999, new DateTime(2027, 1, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_49", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.4399999999999995, new DateTime(2027, 1, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_49", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.4199999999999999, new DateTime(2027, 1, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_50", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.789999999999999, new DateTime(2027, 1, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_50", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.609999999999999, new DateTime(2027, 1, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_50", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.949999999999999, new DateTime(2027, 1, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_50", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.869999999999999, new DateTime(2027, 1, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_50", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 40.700000000000003, new DateTime(2027, 1, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_50", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.73, new DateTime(2027, 1, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_50", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.1299999999999999, new DateTime(2027, 1, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_50", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.68, new DateTime(2027, 1, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_50", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.760000000000002, new DateTime(2027, 1, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_50", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.630000000000001, new DateTime(2027, 1, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_51", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.2300000000000004, new DateTime(2027, 1, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_51", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.59, new DateTime(2027, 1, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_51", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.4299999999999997, new DateTime(2027, 2, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_51", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.34, new DateTime(2027, 2, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_51", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 40.689999999999998, new DateTime(2027, 2, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_51", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 45.520000000000003, new DateTime(2027, 2, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_51", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.93, new DateTime(2027, 2, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_51", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.050000000000001, new DateTime(2027, 2, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_51", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.67, new DateTime(2027, 2, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_51", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.68, new DateTime(2027, 2, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_52", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.0, new DateTime(2027, 2, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_52", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.73, new DateTime(2027, 2, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_52", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.75, new DateTime(2027, 2, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_52", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.780000000000001, new DateTime(2027, 2, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_52", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.8899999999999997, new DateTime(2027, 2, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_52", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.91, new DateTime(2027, 2, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_52", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.27, new DateTime(2027, 2, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_52", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.8600000000000003, new DateTime(2027, 2, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_52", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.129999999999999, new DateTime(2027, 2, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_52", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.190000000000001, new DateTime(2027, 2, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_53", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.93, new DateTime(2027, 2, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_53", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.67, new DateTime(2027, 2, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_53", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.359999999999999, new DateTime(2027, 2, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_53", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.27, new DateTime(2027, 2, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_53", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 65.810000000000002, new DateTime(2027, 2, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_53", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.3599999999999999, new DateTime(2027, 2, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_53", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.27, new DateTime(2027, 2, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_53", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 81.049999999999997, new DateTime(2027, 2, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_53", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.640000000000001, new DateTime(2027, 2, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_53", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.449999999999999, new DateTime(2027, 2, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_54", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.170000000000002, new DateTime(2027, 2, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_54", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.17, new DateTime(2027, 2, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_54", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.84, new DateTime(2027, 2, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_54", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.3400000000000001, new DateTime(2027, 2, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_54", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 94.150000000000006, new DateTime(2027, 2, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_54", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.91, new DateTime(2027, 2, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_54", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.0999999999999996, new DateTime(2027, 2, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_54", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.0499999999999998, new DateTime(2027, 2, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_54", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.200000000000003, new DateTime(2027, 2, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_54", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 40.399999999999999, new DateTime(2027, 2, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_55", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.859999999999999, new DateTime(2027, 2, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_55", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.93, new DateTime(2027, 2, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_55", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.0, new DateTime(2027, 2, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_55", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.119999999999999, new DateTime(2027, 2, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_55", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.420000000000002, new DateTime(2027, 3, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_55", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.119999999999997, new DateTime(2027, 3, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_55", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.539999999999999, new DateTime(2027, 3, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_55", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.04, new DateTime(2027, 3, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_55", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.9299999999999999, new DateTime(2027, 3, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_55", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.26, new DateTime(2027, 3, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_56", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.2300000000000004, new DateTime(2027, 3, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_56", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.510000000000002, new DateTime(2027, 3, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_56", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.130000000000001, new DateTime(2027, 3, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_56", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.6600000000000001, new DateTime(2027, 3, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_56", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.15, new DateTime(2027, 3, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_56", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.31, new DateTime(2027, 3, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_56", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.640000000000001, new DateTime(2027, 3, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_56", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.9400000000000004, new DateTime(2027, 3, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_56", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.59, new DateTime(2027, 3, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_56", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.010000000000002, new DateTime(2027, 3, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_57", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.140000000000001, new DateTime(2027, 3, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_57", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.5099999999999998, new DateTime(2027, 3, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_57", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.6399999999999999, new DateTime(2027, 3, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_57", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.7599999999999998, new DateTime(2027, 3, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_57", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.32, new DateTime(2027, 3, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_57", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.04, new DateTime(2027, 3, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_57", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 35.420000000000002, new DateTime(2027, 3, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_57", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 46.359999999999999, new DateTime(2027, 3, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_57", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.5, new DateTime(2027, 3, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_57", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 50.880000000000003, new DateTime(2027, 3, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_58", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.170000000000002, new DateTime(2027, 3, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_58", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.100000000000001, new DateTime(2027, 3, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_58", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.470000000000001, new DateTime(2027, 3, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_58", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.1699999999999999, new DateTime(2027, 3, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_58", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.119999999999999, new DateTime(2027, 3, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_58", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.75, new DateTime(2027, 3, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_58", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.23, new DateTime(2027, 3, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_58", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.260000000000002, new DateTime(2027, 3, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_58", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 63.0, new DateTime(2027, 3, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_58", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 44.909999999999997, new DateTime(2027, 3, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_59", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.4199999999999999, new DateTime(2027, 3, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_59", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Date", "Name", "SupplierId" },
                values: new object[] { new DateTime(2027, 3, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_59", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.24, new DateTime(2027, 3, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_59", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.0800000000000001, new DateTime(2027, 3, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_59", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.059999999999999, new DateTime(2027, 3, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_59", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.2000000000000002, new DateTime(2027, 3, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_59", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 59.670000000000002, new DateTime(2027, 3, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_59", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 61.299999999999997, new DateTime(2027, 3, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_59", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 45.609999999999999, new DateTime(2027, 3, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_59", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 71.959999999999994, new DateTime(2027, 3, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_60", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.29, new DateTime(2027, 3, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_60", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.690000000000001, new DateTime(2027, 3, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_60", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.1699999999999999, new DateTime(2027, 3, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_60", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.93, new DateTime(2027, 3, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_60", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.82, new DateTime(2027, 3, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_60", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.91, new DateTime(2027, 3, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_60", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.4199999999999999, new DateTime(2027, 3, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_60", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 69.769999999999996, new DateTime(2027, 3, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_60", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.4399999999999995, new DateTime(2027, 4, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_60", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.32, new DateTime(2027, 4, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_61", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.609999999999999, new DateTime(2027, 4, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_61", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.220000000000001, new DateTime(2027, 4, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_61", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.24, new DateTime(2027, 4, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_61", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.710000000000001, new DateTime(2027, 4, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_61", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.859999999999999, new DateTime(2027, 4, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_61", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.300000000000001, new DateTime(2027, 4, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_61", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.420000000000002, new DateTime(2027, 4, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_61", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.810000000000002, new DateTime(2027, 4, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_61", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 62.710000000000001, new DateTime(2027, 4, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_61", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 76.959999999999994, new DateTime(2027, 4, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_62", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 47.909999999999997, new DateTime(2027, 4, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_62", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.279999999999999, new DateTime(2027, 4, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_62", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.370000000000001, new DateTime(2027, 4, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_62", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.0, new DateTime(2027, 4, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_62", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.5, new DateTime(2027, 4, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_62", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.0, new DateTime(2027, 4, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_62", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.5899999999999999, new DateTime(2027, 4, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_62", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.690000000000001, new DateTime(2027, 4, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_62", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.859999999999999, new DateTime(2027, 4, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_62", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 34.280000000000001, new DateTime(2027, 4, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_63", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.07, new DateTime(2027, 4, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_63", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.600000000000001, new DateTime(2027, 4, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_63", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.809999999999999, new DateTime(2027, 4, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_63", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.850000000000001, new DateTime(2027, 4, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_63", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.949999999999999, new DateTime(2027, 4, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_63", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.82, new DateTime(2027, 4, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_63", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.620000000000001, new DateTime(2027, 4, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_63", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.789999999999999, new DateTime(2027, 4, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_63", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.220000000000001, new DateTime(2027, 4, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_63", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.8900000000000001, new DateTime(2027, 4, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_64", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.779999999999999, new DateTime(2027, 4, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_64", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.8399999999999999, new DateTime(2027, 4, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_64", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 40.590000000000003, new DateTime(2027, 4, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_64", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.83, new DateTime(2027, 4, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_64", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 73.829999999999998, new DateTime(2027, 4, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_64", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.079999999999998, new DateTime(2027, 4, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_64", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.09, new DateTime(2027, 4, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_64", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.719999999999999, new DateTime(2027, 4, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_64", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.189999999999998, new DateTime(2027, 4, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_64", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.0899999999999999, new DateTime(2027, 4, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_65", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.83, new DateTime(2027, 4, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_65", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.25, new DateTime(2027, 4, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_65", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.199999999999999, new DateTime(2027, 4, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_65", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.84, new DateTime(2027, 4, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_65", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 48.619999999999997, new DateTime(2027, 4, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_65", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.75, new DateTime(2027, 4, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_65", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.93, new DateTime(2027, 4, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_65", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 53.850000000000001, new DateTime(2027, 4, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_65", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.190000000000001, new DateTime(2027, 4, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_65", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 46.329999999999998, new DateTime(2027, 4, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_66", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.120000000000001, new DateTime(2027, 4, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_66", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.779999999999999, new DateTime(2027, 4, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_66", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.9399999999999995, new DateTime(2027, 4, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_66", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 47.509999999999998, new DateTime(2027, 4, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_66", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.9100000000000001, new DateTime(2027, 4, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_66", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 52.43, new DateTime(2027, 4, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_66", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.920000000000002, new DateTime(2027, 4, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_66", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.289999999999999, new DateTime(2027, 5, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_66", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.4900000000000002, new DateTime(2027, 5, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_66", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.1, new DateTime(2027, 5, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_67", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 49.259999999999998, new DateTime(2027, 5, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_67", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.77, new DateTime(2027, 5, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_67", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.699999999999999, new DateTime(2027, 5, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_67", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.9900000000000002, new DateTime(2027, 5, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_67", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.880000000000001, new DateTime(2027, 5, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_67", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.0800000000000001, new DateTime(2027, 5, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_67", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.109999999999999, new DateTime(2027, 5, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_67", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.579999999999998, new DateTime(2027, 5, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_67", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.7599999999999998, new DateTime(2027, 5, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_67", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.2999999999999998, new DateTime(2027, 5, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_68", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.4100000000000001, new DateTime(2027, 5, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_68", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.789999999999999, new DateTime(2027, 5, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_68", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.920000000000002, new DateTime(2027, 5, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_68", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.050000000000001, new DateTime(2027, 5, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_68", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.699999999999999, new DateTime(2027, 5, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_68", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.789999999999999, new DateTime(2027, 5, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_68", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.3800000000000008, new DateTime(2027, 5, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_68", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.18, new DateTime(2027, 5, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_68", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.8499999999999996, new DateTime(2027, 5, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_68", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.56, new DateTime(2027, 5, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_69", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.2999999999999998, new DateTime(2027, 5, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_69", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 48.530000000000001, new DateTime(2027, 5, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_69", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.309999999999999, new DateTime(2027, 5, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_69", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.16, new DateTime(2027, 5, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_69", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.98, new DateTime(2027, 5, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_69", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.920000000000002, new DateTime(2027, 5, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_69", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.1, new DateTime(2027, 5, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_69", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.1299999999999999, new DateTime(2027, 5, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_69", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.1399999999999999, new DateTime(2027, 5, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_69", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.66, new DateTime(2027, 5, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_70", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.19, new DateTime(2027, 5, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_70", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.880000000000001, new DateTime(2027, 5, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_70", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.039999999999999, new DateTime(2027, 5, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_70", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.81, new DateTime(2027, 5, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_70", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.82, new DateTime(2027, 5, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_70", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.199999999999999, new DateTime(2027, 5, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_70", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.940000000000001, new DateTime(2027, 5, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_70", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.27, new DateTime(2027, 5, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_70", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.539999999999999, new DateTime(2027, 5, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_70", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.149999999999999, new DateTime(2027, 5, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_71", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.620000000000001, new DateTime(2027, 5, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_71", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.4500000000000002, new DateTime(2027, 5, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_71", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.0, new DateTime(2027, 5, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_71", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.380000000000001, new DateTime(2027, 5, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_71", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.059999999999999, new DateTime(2027, 5, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_71", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.3899999999999997, new DateTime(2027, 5, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_71", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.2300000000000004, new DateTime(2027, 5, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_71", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 58.460000000000001, new DateTime(2027, 5, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_71", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.199999999999999, new DateTime(2027, 5, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_71", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.620000000000001, new DateTime(2027, 5, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_72", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.25, new DateTime(2027, 5, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_72", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.33, new DateTime(2027, 5, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_72", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.879999999999999, new DateTime(2027, 5, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_72", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.529999999999999, new DateTime(2027, 5, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_72", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.4099999999999999, new DateTime(2027, 5, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_72", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.800000000000001, new DateTime(2027, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_72", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.94, new DateTime(2027, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_72", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.1600000000000001, new DateTime(2027, 5, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_72", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.210000000000001, new DateTime(2027, 6, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_72", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.390000000000001, new DateTime(2027, 6, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_73", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.010000000000002, new DateTime(2027, 6, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_73", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.93, new DateTime(2027, 6, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_73", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.6400000000000001, new DateTime(2027, 6, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_73", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.890000000000001, new DateTime(2027, 6, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_73", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.66, new DateTime(2027, 6, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_73", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.23, new DateTime(2027, 6, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_73", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.460000000000001, new DateTime(2027, 6, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_73", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.710000000000001, new DateTime(2027, 6, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_73", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.079999999999998, new DateTime(2027, 6, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_73", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.289999999999999, new DateTime(2027, 6, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_74", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.3700000000000001, new DateTime(2027, 6, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_74", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.620000000000001, new DateTime(2027, 6, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_74", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.470000000000001, new DateTime(2027, 6, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_74", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.0800000000000001, new DateTime(2027, 6, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_74", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.57, new DateTime(2027, 6, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_74", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.77, new DateTime(2027, 6, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_74", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.170000000000002, new DateTime(2027, 6, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_74", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 57.039999999999999, new DateTime(2027, 6, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_74", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.530000000000001, new DateTime(2027, 6, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_74", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.1600000000000001, new DateTime(2027, 6, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_75", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 56.219999999999999, new DateTime(2027, 6, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_75", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.619999999999997, new DateTime(2027, 6, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_75", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.59, new DateTime(2027, 6, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_75", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.25, new DateTime(2027, 6, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_75", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.829999999999998, new DateTime(2027, 6, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_75", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.460000000000001, new DateTime(2027, 6, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_75", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.029999999999999, new DateTime(2027, 6, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_75", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.04, new DateTime(2027, 6, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_75", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.399999999999999, new DateTime(2027, 6, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_75", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.6, new DateTime(2027, 6, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_76", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.469999999999999, new DateTime(2027, 6, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_76", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.67, new DateTime(2027, 6, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_76", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.6200000000000001, new DateTime(2027, 6, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_76", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.6200000000000001, new DateTime(2027, 6, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_76", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.280000000000001, new DateTime(2027, 6, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_76", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.700000000000003, new DateTime(2027, 6, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_76", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 41.43, new DateTime(2027, 6, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_76", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.530000000000001, new DateTime(2027, 6, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_76", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.5899999999999999, new DateTime(2027, 6, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_76", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.559999999999999, new DateTime(2027, 6, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_77", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.289999999999999, new DateTime(2027, 6, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_77", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.420000000000002, new DateTime(2027, 6, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_77", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.1899999999999999, new DateTime(2027, 6, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_77", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.219999999999999, new DateTime(2027, 6, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_77", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.01, new DateTime(2027, 6, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_77", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.7200000000000002, new DateTime(2027, 6, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_77", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.300000000000001, new DateTime(2027, 6, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_77", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.01, new DateTime(2027, 6, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_77", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 49.439999999999998, new DateTime(2027, 6, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_77", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.770000000000003, new DateTime(2027, 6, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_78", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.41, new DateTime(2027, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_78", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.41, new DateTime(2027, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_78", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.8100000000000001, new DateTime(2027, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_78", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.059999999999999, new DateTime(2027, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_78", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.0800000000000001, new DateTime(2027, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_78", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.81, new DateTime(2027, 6, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_78", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.850000000000001, new DateTime(2027, 6, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_78", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.539999999999999, new DateTime(2027, 6, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_78", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.02, new DateTime(2027, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_78", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.6500000000000004, new DateTime(2027, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_79", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.390000000000001, new DateTime(2027, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_79", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 74.310000000000002, new DateTime(2027, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_79", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.289999999999999, new DateTime(2027, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_79", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.870000000000001, new DateTime(2027, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_79", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 21.219999999999999, new DateTime(2027, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_79", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.5999999999999996, new DateTime(2027, 6, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_79", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.8300000000000001, new DateTime(2027, 6, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_79", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.43, new DateTime(2027, 6, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_79", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.34, new DateTime(2027, 6, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_79", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.300000000000001, new DateTime(2027, 7, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_80", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 46.0, new DateTime(2027, 7, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_80", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.52, new DateTime(2027, 7, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_80", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 34.590000000000003, new DateTime(2027, 7, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_80", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.449999999999999, new DateTime(2027, 7, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_80", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.120000000000001, new DateTime(2027, 7, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_80", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.83, new DateTime(2027, 7, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_80", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.329999999999998, new DateTime(2027, 7, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_80", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.18, new DateTime(2027, 7, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_80", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.789999999999999, new DateTime(2027, 7, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_80", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.260000000000002, new DateTime(2027, 7, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_81", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.3200000000000003, new DateTime(2027, 7, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_81", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.8799999999999999, new DateTime(2027, 7, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_81", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.239999999999998, new DateTime(2027, 7, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_81", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.3899999999999999, new DateTime(2027, 7, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_81", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 62.43, new DateTime(2027, 7, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_81", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.470000000000001, new DateTime(2027, 7, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_81", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.07, new DateTime(2027, 7, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_81", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.029999999999999, new DateTime(2027, 7, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_81", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.98, new DateTime(2027, 7, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_81", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.57, new DateTime(2027, 7, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_82", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.190000000000001, new DateTime(2027, 7, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_82", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.800000000000001, new DateTime(2027, 7, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_82", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 30.370000000000001, new DateTime(2027, 7, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_82", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.1199999999999992, new DateTime(2027, 7, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_82", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 80.680000000000007, new DateTime(2027, 7, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_82", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.16, new DateTime(2027, 7, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_82", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.41, new DateTime(2027, 7, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_82", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.0500000000000007, new DateTime(2027, 7, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_82", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.18, new DateTime(2027, 7, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_82", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.359999999999999, new DateTime(2027, 7, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_83", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.149999999999999, new DateTime(2027, 7, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_83", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 35.219999999999999, new DateTime(2027, 7, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_83", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.0, new DateTime(2027, 7, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_83", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.510000000000002, new DateTime(2027, 7, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_83", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.82, new DateTime(2027, 7, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_83", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 28.149999999999999, new DateTime(2027, 7, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_83", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.710000000000001, new DateTime(2027, 7, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_83", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.75, new DateTime(2027, 7, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_83", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.33, new DateTime(2027, 7, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_83", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 52.259999999999998, new DateTime(2027, 7, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_84", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 44.939999999999998, new DateTime(2027, 7, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_84", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.4, new DateTime(2027, 7, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_84", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.200000000000003, new DateTime(2027, 7, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_84", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.76, new DateTime(2027, 7, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_84", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.969999999999999, new DateTime(2027, 7, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_84", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.890000000000001, new DateTime(2027, 7, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_84", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.7599999999999998, new DateTime(2027, 7, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_84", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.84, new DateTime(2027, 7, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_84", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.68, new DateTime(2027, 7, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_84", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 72.760000000000005, new DateTime(2027, 7, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_85", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.870000000000001, new DateTime(2027, 7, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_85", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 39.759999999999998, new DateTime(2027, 7, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_85", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.600000000000001, new DateTime(2027, 7, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_85", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.880000000000001, new DateTime(2027, 8, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_85", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.0499999999999998, new DateTime(2027, 8, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_85", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.329999999999998, new DateTime(2027, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_85", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.18, new DateTime(2027, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_85", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.510000000000002, new DateTime(2027, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_85", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.27, new DateTime(2027, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_85", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.859999999999999, new DateTime(2027, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_86", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.739999999999998, new DateTime(2027, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_86", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.760000000000002, new DateTime(2027, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_86", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.350000000000001, new DateTime(2027, 8, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_86", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.9300000000000002, new DateTime(2027, 8, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_86", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.960000000000001, new DateTime(2027, 8, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_86", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 44.969999999999999, new DateTime(2027, 8, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_86", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.07, new DateTime(2027, 8, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_86", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.380000000000003, new DateTime(2027, 8, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_86", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.48, new DateTime(2027, 8, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_86", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.600000000000001, new DateTime(2027, 8, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_87", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.09, new DateTime(2027, 8, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_87", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.7599999999999998, new DateTime(2027, 8, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_87", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.010000000000002, new DateTime(2027, 8, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_87", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.9399999999999999, new DateTime(2027, 8, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_87", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.98, new DateTime(2027, 8, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_87", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.24, new DateTime(2027, 8, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_87", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.02, new DateTime(2027, 8, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_87", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.609999999999999, new DateTime(2027, 8, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_87", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.3499999999999996, new DateTime(2027, 8, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_87", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.140000000000001, new DateTime(2027, 8, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_88", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.1900000000000004, new DateTime(2027, 8, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_88", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.010000000000002, new DateTime(2027, 8, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_88", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.539999999999999, new DateTime(2027, 8, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_88", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.3099999999999996, new DateTime(2027, 8, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_88", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.02, new DateTime(2027, 8, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_88", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.32, new DateTime(2027, 8, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_88", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.9900000000000002, new DateTime(2027, 8, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_88", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.350000000000001, new DateTime(2027, 8, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_88", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.58, new DateTime(2027, 8, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_88", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 34.479999999999997, new DateTime(2027, 8, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_89", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.120000000000001, new DateTime(2027, 8, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_89", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.17, new DateTime(2027, 8, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_89", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.3800000000000008, new DateTime(2027, 8, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_89", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.5, new DateTime(2027, 8, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_89", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 94.140000000000001, new DateTime(2027, 8, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_89", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.359999999999999, new DateTime(2027, 8, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_89", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.620000000000001, new DateTime(2027, 8, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_89", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 48.259999999999998, new DateTime(2027, 8, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_89", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 59.0, new DateTime(2027, 8, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_89", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 45.460000000000001, new DateTime(2027, 8, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_90", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.8499999999999996, new DateTime(2027, 8, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_90", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.4099999999999999, new DateTime(2027, 8, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_90", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.85, new DateTime(2027, 8, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_90", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 62.229999999999997, new DateTime(2027, 8, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_90", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 43.979999999999997, new DateTime(2027, 8, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_90", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.71, new DateTime(2027, 8, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_90", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.329999999999998, new DateTime(2027, 8, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_90", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.85, new DateTime(2027, 8, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_90", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.030000000000001, new DateTime(2027, 8, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_90", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.460000000000001, new DateTime(2027, 8, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_91", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.6, new DateTime(2027, 8, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_91", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.26, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_91", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.369999999999999, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_91", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 26.350000000000001, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_91", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.27, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_91", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.550000000000001, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_91", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 64.890000000000001, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_91", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.3399999999999999, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_91", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.120000000000001, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_91", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.5499999999999998, new DateTime(2027, 8, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_92", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.399999999999999, new DateTime(2027, 8, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_92", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.0700000000000003, new DateTime(2027, 8, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_92", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.9900000000000002, new DateTime(2027, 8, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_92", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.5899999999999999, new DateTime(2027, 8, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_92", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.880000000000001, new DateTime(2027, 8, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_92", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.68, new DateTime(2027, 8, 31, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_92", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 10.26, new DateTime(2027, 9, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_92", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 60.960000000000001, new DateTime(2027, 9, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_92", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 29.16, new DateTime(2027, 9, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_92", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.75, new DateTime(2027, 9, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_93", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 18.25, new DateTime(2027, 9, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_93", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.4400000000000004, new DateTime(2027, 9, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_93", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.969999999999999, new DateTime(2027, 9, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_93", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.239999999999998, new DateTime(2027, 9, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_93", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 25.949999999999999, new DateTime(2027, 9, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_93", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.219999999999999, new DateTime(2027, 9, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_93", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.890000000000001, new DateTime(2027, 9, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_93", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.489999999999998, new DateTime(2027, 9, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_93", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 16.969999999999999, new DateTime(2027, 9, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_93", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 37.189999999999998, new DateTime(2027, 9, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_94", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 19.859999999999999, new DateTime(2027, 9, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_94", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 17.16, new DateTime(2027, 9, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_94", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 32.509999999999998, new DateTime(2027, 9, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_94", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.79, new DateTime(2027, 9, 12, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_94", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.899999999999999, new DateTime(2027, 9, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_94", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.6500000000000004, new DateTime(2027, 9, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_94", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.9600000000000009, new DateTime(2027, 9, 13, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_94", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 33.0, new DateTime(2027, 9, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_94", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.5, new DateTime(2027, 9, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_94", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 53.25, new DateTime(2027, 9, 14, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_95", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.119999999999999, new DateTime(2027, 9, 15, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_95", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.920000000000002, new DateTime(2027, 9, 16, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_95", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.75, new DateTime(2027, 9, 17, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_95", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.0800000000000001, new DateTime(2027, 9, 18, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_95", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 14.720000000000001, new DateTime(2027, 9, 19, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_95", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.960000000000001, new DateTime(2027, 9, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_95", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.0999999999999996, new DateTime(2027, 9, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_95", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 39.409999999999997, new DateTime(2027, 9, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_95", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.42, new DateTime(2027, 9, 20, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_95", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.2400000000000002, new DateTime(2027, 9, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_96", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 3.2999999999999998, new DateTime(2027, 9, 21, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_96", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.5, new DateTime(2027, 9, 22, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_96", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.7699999999999996, new DateTime(2027, 9, 23, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_96", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.220000000000001, new DateTime(2027, 9, 24, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_96", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.8700000000000001, new DateTime(2027, 9, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_96", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 35.240000000000002, new DateTime(2027, 9, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_96", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.04, new DateTime(2027, 9, 25, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_96", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 20.190000000000001, new DateTime(2027, 9, 26, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_96", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.1500000000000004, new DateTime(2027, 9, 27, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_96", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.039999999999999, new DateTime(2027, 9, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_97", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.140000000000001, new DateTime(2027, 9, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_97", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 11.609999999999999, new DateTime(2027, 9, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_97", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.2599999999999998, new DateTime(2027, 9, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_97", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 8.6999999999999993, new DateTime(2027, 9, 28, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_97", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 45.25, new DateTime(2027, 9, 29, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_97", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 22.609999999999999, new DateTime(2027, 9, 30, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_97", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.49, new DateTime(2027, 10, 1, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_97", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.199999999999999, new DateTime(2027, 10, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_97", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 38.25, new DateTime(2027, 10, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_97", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 24.420000000000002, new DateTime(2027, 10, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_98", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 31.07, new DateTime(2027, 10, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_98", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.85, new DateTime(2027, 10, 2, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_98", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 4.8799999999999999, new DateTime(2027, 10, 3, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_98", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.4900000000000002, new DateTime(2027, 10, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_98", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 13.48, new DateTime(2027, 10, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_98", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.2800000000000002, new DateTime(2027, 10, 4, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_98", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 12.73, new DateTime(2027, 10, 5, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_98", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 5.8300000000000001, new DateTime(2027, 10, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_98", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 1.8, new DateTime(2027, 10, 6, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_98", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 2.6000000000000001, new DateTime(2027, 10, 7, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_99", 3 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 36.770000000000003, new DateTime(2027, 10, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Aluminium_99", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 9.1099999999999994, new DateTime(2027, 10, 8, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Iron_99", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 34.93, new DateTime(2027, 10, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Stainless Steel_99", 1 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 27.82, new DateTime(2027, 10, 9, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Screws_99", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 68.0, new DateTime(2027, 10, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood Tools_99", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 23.84, new DateTime(2027, 10, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Door Accessories_99", 5 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 7.4699999999999998, new DateTime(2027, 10, 10, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass_99", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 6.6200000000000001, new DateTime(2027, 10, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Metal Tools_99", 2 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 44.969999999999999, new DateTime(2027, 10, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Glass Accessories_99", 4 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Amount", "Date", "Name", "SupplierId" },
                values: new object[] { 15.25, new DateTime(2027, 10, 11, 9, 52, 22, 97, DateTimeKind.Local).AddTicks(2351), "Wood_100", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SupplierId",
                table: "Transactions",
                column: "SupplierId");

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
                name: "FK_Transactions_Suppliers_SupplierId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_SupplierId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Food", 1983.24 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Cat Food", 2101.8899999999999 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Cigarettes", 1975.5799999999999 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Coffee", 1984.8900000000001 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Tea", 2044.4300000000001 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Economies", 2232.8800000000001 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Phone bills", 2027.0699999999999 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Restaurant", 2257.48 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Presents", 1800.48 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "TotalAmount" },
                values: new object[] { "Eletricity and gaz", 1994.9300000000001 });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.1699999999999999, new DateTime(2026, 5, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.470000000000001, new DateTime(2026, 5, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.100000000000001, new DateTime(2026, 5, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.0, new DateTime(2026, 5, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.9900000000000002, new DateTime(2026, 5, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.530000000000001, new DateTime(2026, 5, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.550000000000001, new DateTime(2026, 5, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.239999999999998, new DateTime(2026, 5, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.51, new DateTime(2026, 5, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_0" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.390000000000001, new DateTime(2026, 5, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.09, new DateTime(2026, 5, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.270000000000003, new DateTime(2026, 5, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.01, new DateTime(2026, 5, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.6699999999999999, new DateTime(2026, 5, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.69, new DateTime(2026, 5, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.239999999999998, new DateTime(2026, 5, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.07, new DateTime(2026, 5, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.710000000000001, new DateTime(2026, 5, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.5599999999999996, new DateTime(2026, 5, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_1" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.350000000000001, new DateTime(2026, 5, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 70.780000000000001, new DateTime(2026, 5, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.120000000000001, new DateTime(2026, 5, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.6900000000000004, new DateTime(2026, 5, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.050000000000001, new DateTime(2026, 5, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.4099999999999999, new DateTime(2026, 6, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.79, new DateTime(2026, 6, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.970000000000001, new DateTime(2026, 6, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.5499999999999998, new DateTime(2026, 6, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.039999999999999, new DateTime(2026, 6, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_2" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.92, new DateTime(2026, 6, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.149999999999999, new DateTime(2026, 6, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.8199999999999998, new DateTime(2026, 6, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.280000000000001, new DateTime(2026, 6, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.059999999999999, new DateTime(2026, 6, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.0999999999999996, new DateTime(2026, 6, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.92, new DateTime(2026, 6, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.530000000000001, new DateTime(2026, 6, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.7699999999999996, new DateTime(2026, 6, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.9900000000000002, new DateTime(2026, 6, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_3" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.1600000000000001, new DateTime(2026, 6, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.75, new DateTime(2026, 6, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.23, new DateTime(2026, 6, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 40.5, new DateTime(2026, 6, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.3399999999999999, new DateTime(2026, 6, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.0800000000000001, new DateTime(2026, 6, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.510000000000002, new DateTime(2026, 6, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.510000000000002, new DateTime(2026, 6, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.789999999999999, new DateTime(2026, 6, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.6699999999999999, new DateTime(2026, 6, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_4" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.390000000000001, new DateTime(2026, 6, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.0800000000000001, new DateTime(2026, 6, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.35, new DateTime(2026, 6, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 79.219999999999999, new DateTime(2026, 6, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.870000000000001, new DateTime(2026, 6, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.899999999999999, new DateTime(2026, 6, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.41, new DateTime(2026, 6, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.309999999999999, new DateTime(2026, 6, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.0800000000000001, new DateTime(2026, 6, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.4199999999999999, new DateTime(2026, 6, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_5" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.300000000000001, new DateTime(2026, 6, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.6699999999999999, new DateTime(2026, 6, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.170000000000002, new DateTime(2026, 6, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.27, new DateTime(2026, 6, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 51.850000000000001, new DateTime(2026, 6, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.5099999999999998, new DateTime(2026, 6, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.239999999999998, new DateTime(2026, 6, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.739999999999998, new DateTime(2026, 6, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.75, new DateTime(2026, 6, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 40.020000000000003, new DateTime(2026, 6, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_6" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.33, new DateTime(2026, 6, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 55.789999999999999, new DateTime(2026, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.9900000000000002, new DateTime(2026, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.57, new DateTime(2026, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.2699999999999996, new DateTime(2026, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.31, new DateTime(2026, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.609999999999999, new DateTime(2026, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.5899999999999999, new DateTime(2026, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.629999999999999, new DateTime(2026, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.369999999999999, new DateTime(2026, 6, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_7" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.059999999999999, new DateTime(2026, 6, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.219999999999999, new DateTime(2026, 6, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.100000000000001, new DateTime(2026, 6, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.8399999999999999, new DateTime(2026, 6, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.82, new DateTime(2026, 6, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 61.240000000000002, new DateTime(2026, 6, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 52.700000000000003, new DateTime(2026, 6, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.079999999999998, new DateTime(2026, 6, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.3399999999999999, new DateTime(2026, 6, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.21, new DateTime(2026, 6, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_8" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.970000000000001, new DateTime(2026, 6, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 58.869999999999997, new DateTime(2026, 6, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.199999999999999, new DateTime(2026, 6, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.550000000000001, new DateTime(2026, 6, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.07, new DateTime(2026, 6, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.379999999999999, new DateTime(2026, 6, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.789999999999999, new DateTime(2026, 6, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.350000000000001, new DateTime(2026, 7, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.940000000000001, new DateTime(2026, 7, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.100000000000001, new DateTime(2026, 7, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_9" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.5, new DateTime(2026, 7, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 50.890000000000001, new DateTime(2026, 7, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.57, new DateTime(2026, 7, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.5899999999999999, new DateTime(2026, 7, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.34, new DateTime(2026, 7, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.25, new DateTime(2026, 7, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.0, new DateTime(2026, 7, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.670000000000002, new DateTime(2026, 7, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.289999999999999, new DateTime(2026, 7, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.1399999999999997, new DateTime(2026, 7, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_10" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.879999999999999, new DateTime(2026, 7, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.239999999999998, new DateTime(2026, 7, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.920000000000002, new DateTime(2026, 7, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.98, new DateTime(2026, 7, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.0999999999999996, new DateTime(2026, 7, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.490000000000002, new DateTime(2026, 7, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.869999999999997, new DateTime(2026, 7, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.7699999999999996, new DateTime(2026, 7, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.0, new DateTime(2026, 7, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.9900000000000002, new DateTime(2026, 7, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_11" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.68, new DateTime(2026, 7, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.3200000000000003, new DateTime(2026, 7, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.07, new DateTime(2026, 7, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.31, new DateTime(2026, 7, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 57.329999999999998, new DateTime(2026, 7, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.32, new DateTime(2026, 7, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.609999999999999, new DateTime(2026, 7, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.6200000000000001, new DateTime(2026, 7, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.6799999999999997, new DateTime(2026, 7, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.42, new DateTime(2026, 7, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_12" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.0899999999999999, new DateTime(2026, 7, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.71, new DateTime(2026, 7, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.240000000000002, new DateTime(2026, 7, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.48, new DateTime(2026, 7, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.140000000000001, new DateTime(2026, 7, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 62.439999999999998, new DateTime(2026, 7, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.27, new DateTime(2026, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.969999999999999, new DateTime(2026, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.6399999999999997, new DateTime(2026, 7, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.130000000000001, new DateTime(2026, 7, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_13" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.68, new DateTime(2026, 7, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.32, new DateTime(2026, 7, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.75, new DateTime(2026, 7, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.7699999999999996, new DateTime(2026, 7, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.450000000000003, new DateTime(2026, 7, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 78.849999999999994, new DateTime(2026, 7, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.119999999999999, new DateTime(2026, 7, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.77, new DateTime(2026, 7, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.939999999999998, new DateTime(2026, 7, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.970000000000001, new DateTime(2026, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_14" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.3500000000000001, new DateTime(2026, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.3700000000000001, new DateTime(2026, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.09, new DateTime(2026, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.4100000000000001, new DateTime(2026, 7, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.050000000000001, new DateTime(2026, 8, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.879999999999999, new DateTime(2026, 8, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 42.420000000000002, new DateTime(2026, 8, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.07, new DateTime(2026, 8, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 40.5, new DateTime(2026, 8, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.32, new DateTime(2026, 8, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_15" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.010000000000002, new DateTime(2026, 8, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 71.390000000000001, new DateTime(2026, 8, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 54.789999999999999, new DateTime(2026, 8, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 33.689999999999998, new DateTime(2026, 8, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.2300000000000004, new DateTime(2026, 8, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.25, new DateTime(2026, 8, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.06, new DateTime(2026, 8, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.52, new DateTime(2026, 8, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.6500000000000004, new DateTime(2026, 8, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.0, new DateTime(2026, 8, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_16" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.550000000000001, new DateTime(2026, 8, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.7300000000000004, new DateTime(2026, 8, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.239999999999998, new DateTime(2026, 8, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.2999999999999998, new DateTime(2026, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.84, new DateTime(2026, 8, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.539999999999999, new DateTime(2026, 8, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.9000000000000004, new DateTime(2026, 8, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.43, new DateTime(2026, 8, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.7599999999999998, new DateTime(2026, 8, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 55.049999999999997, new DateTime(2026, 8, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_17" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 66.269999999999996, new DateTime(2026, 8, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.300000000000001, new DateTime(2026, 8, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.4300000000000002, new DateTime(2026, 8, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.1, new DateTime(2026, 8, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 50.619999999999997, new DateTime(2026, 8, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.140000000000001, new DateTime(2026, 8, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.859999999999999, new DateTime(2026, 8, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.76, new DateTime(2026, 8, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.4299999999999997, new DateTime(2026, 8, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.19, new DateTime(2026, 8, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_18" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.850000000000001, new DateTime(2026, 8, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 80.670000000000002, new DateTime(2026, 8, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.109999999999999, new DateTime(2026, 8, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.27, new DateTime(2026, 8, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.149999999999999, new DateTime(2026, 8, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.0600000000000005, new DateTime(2026, 8, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.07, new DateTime(2026, 8, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.1500000000000004, new DateTime(2026, 8, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.1199999999999992, new DateTime(2026, 8, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.550000000000001, new DateTime(2026, 8, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_19" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 36.689999999999998, new DateTime(2026, 8, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.0, new DateTime(2026, 8, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 41.420000000000002, new DateTime(2026, 8, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.289999999999999, new DateTime(2026, 8, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.18, new DateTime(2026, 8, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.3799999999999999, new DateTime(2026, 8, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.829999999999998, new DateTime(2026, 8, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.44, new DateTime(2026, 8, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.8500000000000001, new DateTime(2026, 8, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.0800000000000001, new DateTime(2026, 9, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_20" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.8899999999999997, new DateTime(2026, 9, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.4299999999999997, new DateTime(2026, 9, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.2799999999999994, new DateTime(2026, 9, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.260000000000002, new DateTime(2026, 9, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.57, new DateTime(2026, 9, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.7999999999999998, new DateTime(2026, 9, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.059999999999999, new DateTime(2026, 9, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.5, new DateTime(2026, 9, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.3399999999999999, new DateTime(2026, 9, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 70.909999999999997, new DateTime(2026, 9, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_21" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.039999999999999, new DateTime(2026, 9, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.079999999999998, new DateTime(2026, 9, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.3499999999999996, new DateTime(2026, 9, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 58.950000000000003, new DateTime(2026, 9, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 72.620000000000005, new DateTime(2026, 9, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.329999999999998, new DateTime(2026, 9, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.5800000000000001, new DateTime(2026, 9, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.449999999999999, new DateTime(2026, 9, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.5, new DateTime(2026, 9, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.75, new DateTime(2026, 9, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_22" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.539999999999999, new DateTime(2026, 9, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 46.030000000000001, new DateTime(2026, 9, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.23, new DateTime(2026, 9, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.880000000000003, new DateTime(2026, 9, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.960000000000001, new DateTime(2026, 9, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.48, new DateTime(2026, 9, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.98, new DateTime(2026, 9, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.93, new DateTime(2026, 9, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.81, new DateTime(2026, 9, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.31, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_23" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.289999999999999, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.879999999999999, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.74, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.95, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 53.159999999999997, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.25, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.7400000000000002, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.789999999999999, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.34, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 41.710000000000001, new DateTime(2026, 9, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_24" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.7400000000000002, new DateTime(2026, 9, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.1699999999999999, new DateTime(2026, 9, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.0, new DateTime(2026, 9, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.43, new DateTime(2026, 9, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.52, new DateTime(2026, 9, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.030000000000001, new DateTime(2026, 9, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.21, new DateTime(2026, 9, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.609999999999999, new DateTime(2026, 9, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.049999999999997, new DateTime(2026, 9, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.33, new DateTime(2026, 9, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_25" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.0800000000000001, new DateTime(2026, 9, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.5, new DateTime(2026, 9, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.379999999999999, new DateTime(2026, 9, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.4300000000000002, new DateTime(2026, 9, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 36.93, new DateTime(2026, 9, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.0499999999999998, new DateTime(2026, 9, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.7800000000000002, new DateTime(2026, 9, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 63.350000000000001, new DateTime(2026, 9, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.119999999999997, new DateTime(2026, 9, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.2999999999999998, new DateTime(2026, 9, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_26" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.9000000000000004, new DateTime(2026, 9, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.07, new DateTime(2026, 9, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.73, new DateTime(2026, 9, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.7100000000000009, new DateTime(2026, 9, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.809999999999999, new DateTime(2026, 9, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.52, new DateTime(2026, 9, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 46.520000000000003, new DateTime(2026, 9, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.6499999999999999, new DateTime(2026, 9, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.870000000000001, new DateTime(2026, 9, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.9400000000000004, new DateTime(2026, 9, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_27" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.5099999999999998, new DateTime(2026, 9, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.25, new DateTime(2026, 9, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.710000000000001, new DateTime(2026, 9, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.170000000000002, new DateTime(2026, 9, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.3300000000000001, new DateTime(2026, 9, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.93, new DateTime(2026, 9, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.1799999999999997, new DateTime(2026, 9, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.5700000000000003, new DateTime(2026, 9, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.34, new DateTime(2026, 10, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.52, new DateTime(2026, 10, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_28" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.4299999999999997, new DateTime(2026, 10, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.32, new DateTime(2026, 10, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 41.810000000000002, new DateTime(2026, 10, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.960000000000001, new DateTime(2026, 10, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.0800000000000001, new DateTime(2026, 10, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.6699999999999999, new DateTime(2026, 10, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.800000000000001, new DateTime(2026, 10, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.0899999999999999, new DateTime(2026, 10, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.2699999999999996, new DateTime(2026, 10, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.91, new DateTime(2026, 10, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_29" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.81, new DateTime(2026, 10, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.7999999999999998, new DateTime(2026, 10, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 71.099999999999994, new DateTime(2026, 10, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.58, new DateTime(2026, 10, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.71, new DateTime(2026, 10, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.9499999999999993, new DateTime(2026, 10, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.210000000000001, new DateTime(2026, 10, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.9699999999999998, new DateTime(2026, 10, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.859999999999999, new DateTime(2026, 10, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.18, new DateTime(2026, 10, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_30" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.210000000000001, new DateTime(2026, 10, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.740000000000002, new DateTime(2026, 10, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.24, new DateTime(2026, 10, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.640000000000001, new DateTime(2026, 10, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.57, new DateTime(2026, 10, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.4600000000000009, new DateTime(2026, 10, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.27, new DateTime(2026, 10, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.199999999999999, new DateTime(2026, 10, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.43, new DateTime(2026, 10, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.859999999999999, new DateTime(2026, 10, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_31" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 42.380000000000003, new DateTime(2026, 10, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.199999999999999, new DateTime(2026, 10, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.789999999999999, new DateTime(2026, 10, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.5099999999999998, new DateTime(2026, 10, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.369999999999999, new DateTime(2026, 10, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.309999999999999, new DateTime(2026, 10, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.409999999999997, new DateTime(2026, 10, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.640000000000001, new DateTime(2026, 10, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.1, new DateTime(2026, 10, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.0, new DateTime(2026, 10, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_32" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.3300000000000001, new DateTime(2026, 10, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 43.170000000000002, new DateTime(2026, 10, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 61.240000000000002, new DateTime(2026, 10, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.2800000000000002, new DateTime(2026, 10, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.75, new DateTime(2026, 10, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 66.099999999999994, new DateTime(2026, 10, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.25, new DateTime(2026, 10, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.359999999999999, new DateTime(2026, 10, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.33, new DateTime(2026, 10, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 54.469999999999999, new DateTime(2026, 10, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_33" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.0, new DateTime(2026, 10, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.2999999999999998, new DateTime(2026, 10, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.829999999999998, new DateTime(2026, 10, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.310000000000002, new DateTime(2026, 10, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.050000000000001, new DateTime(2026, 10, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.170000000000002, new DateTime(2026, 11, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.4700000000000006, new DateTime(2026, 11, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.469999999999999, new DateTime(2026, 11, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.2199999999999998, new DateTime(2026, 11, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.809999999999999, new DateTime(2026, 11, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_34" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.0300000000000002, new DateTime(2026, 11, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.48, new DateTime(2026, 11, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.960000000000001, new DateTime(2026, 11, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.91, new DateTime(2026, 11, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.420000000000002, new DateTime(2026, 11, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.0, new DateTime(2026, 11, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.510000000000002, new DateTime(2026, 11, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.3300000000000001, new DateTime(2026, 11, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.4100000000000001, new DateTime(2026, 11, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.640000000000001, new DateTime(2026, 11, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_35" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.8399999999999999, new DateTime(2026, 11, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.5699999999999998, new DateTime(2026, 11, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.0800000000000001, new DateTime(2026, 11, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.619999999999999, new DateTime(2026, 11, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.1200000000000001, new DateTime(2026, 11, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.33, new DateTime(2026, 11, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.4399999999999995, new DateTime(2026, 11, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.220000000000001, new DateTime(2026, 11, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.91, new DateTime(2026, 11, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.57, new DateTime(2026, 11, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_36" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.710000000000001, new DateTime(2026, 11, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.5, new DateTime(2026, 11, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.369999999999999, new DateTime(2026, 11, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 43.149999999999999, new DateTime(2026, 11, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.27, new DateTime(2026, 11, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.93, new DateTime(2026, 11, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.1300000000000008, new DateTime(2026, 11, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.4299999999999997, new DateTime(2026, 11, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.17, new DateTime(2026, 11, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.7999999999999998, new DateTime(2026, 11, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_37" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.94, new DateTime(2026, 11, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.73, new DateTime(2026, 11, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.870000000000001, new DateTime(2026, 11, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.43, new DateTime(2026, 11, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.1699999999999999, new DateTime(2026, 11, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.15, new DateTime(2026, 11, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.240000000000002, new DateTime(2026, 11, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 36.020000000000003, new DateTime(2026, 11, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.9400000000000004, new DateTime(2026, 11, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.0099999999999998, new DateTime(2026, 11, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_38" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.6899999999999995, new DateTime(2026, 11, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.93, new DateTime(2026, 11, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.8700000000000001, new DateTime(2026, 11, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.0999999999999996, new DateTime(2026, 11, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.550000000000001, new DateTime(2026, 11, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.9700000000000002, new DateTime(2026, 11, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 48.810000000000002, new DateTime(2026, 11, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.729999999999997, new DateTime(2026, 11, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.8499999999999996, new DateTime(2026, 11, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.52, new DateTime(2026, 11, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_39" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.7599999999999998, new DateTime(2026, 11, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.6000000000000001, new DateTime(2026, 11, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.949999999999999, new DateTime(2026, 12, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.670000000000002, new DateTime(2026, 12, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.029999999999999, new DateTime(2026, 12, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.48, new DateTime(2026, 12, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.54, new DateTime(2026, 12, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.449999999999999, new DateTime(2026, 12, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 42.219999999999999, new DateTime(2026, 12, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.369999999999999, new DateTime(2026, 12, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_40" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.699999999999999, new DateTime(2026, 12, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.67, new DateTime(2026, 12, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.510000000000002, new DateTime(2026, 12, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.84, new DateTime(2026, 12, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 70.359999999999999, new DateTime(2026, 12, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.52, new DateTime(2026, 12, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.92, new DateTime(2026, 12, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.94, new DateTime(2026, 12, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.739999999999998, new DateTime(2026, 12, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.699999999999999, new DateTime(2026, 12, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_41" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.68, new DateTime(2026, 12, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.890000000000001, new DateTime(2026, 12, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.43, new DateTime(2026, 12, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 36.619999999999997, new DateTime(2026, 12, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.690000000000001, new DateTime(2026, 12, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.440000000000001, new DateTime(2026, 12, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 46.090000000000003, new DateTime(2026, 12, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.6699999999999999, new DateTime(2026, 12, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.0800000000000001, new DateTime(2026, 12, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.039999999999999, new DateTime(2026, 12, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_42" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.300000000000001, new DateTime(2026, 12, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.8099999999999996, new DateTime(2026, 12, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.380000000000001, new DateTime(2026, 12, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.5, new DateTime(2026, 12, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.420000000000002, new DateTime(2026, 12, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.840000000000003, new DateTime(2026, 12, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.120000000000001, new DateTime(2026, 12, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.909999999999997, new DateTime(2026, 12, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.649999999999999, new DateTime(2026, 12, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.899999999999999, new DateTime(2026, 12, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_43" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.189999999999998, new DateTime(2026, 12, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.969999999999999, new DateTime(2026, 12, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.329999999999998, new DateTime(2026, 12, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 55.079999999999998, new DateTime(2026, 12, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.1599999999999999, new DateTime(2026, 12, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 33.719999999999999, new DateTime(2026, 12, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.760000000000002, new DateTime(2026, 12, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.4900000000000002, new DateTime(2026, 12, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.380000000000001, new DateTime(2026, 12, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.0599999999999996, new DateTime(2026, 12, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_44" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.199999999999999, new DateTime(2026, 12, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.359999999999999, new DateTime(2026, 12, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.2999999999999998, new DateTime(2026, 12, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.050000000000001, new DateTime(2026, 12, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.6899999999999999, new DateTime(2026, 12, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 52.649999999999999, new DateTime(2026, 12, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.23, new DateTime(2027, 1, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.6800000000000002, new DateTime(2027, 1, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 42.170000000000002, new DateTime(2027, 1, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.640000000000001, new DateTime(2027, 1, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_45" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.029999999999999, new DateTime(2027, 1, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.8399999999999999, new DateTime(2027, 1, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 40.789999999999999, new DateTime(2027, 1, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.83, new DateTime(2027, 1, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.0, new DateTime(2027, 1, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 41.590000000000003, new DateTime(2027, 1, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.949999999999999, new DateTime(2027, 1, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.170000000000002, new DateTime(2027, 1, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.1699999999999999, new DateTime(2027, 1, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.420000000000002, new DateTime(2027, 1, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_46" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.81, new DateTime(2027, 1, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.420000000000002, new DateTime(2027, 1, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 48.329999999999998, new DateTime(2027, 1, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.699999999999999, new DateTime(2027, 1, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.140000000000001, new DateTime(2027, 1, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.93, new DateTime(2027, 1, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.76, new DateTime(2027, 1, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.0700000000000003, new DateTime(2027, 1, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.190000000000001, new DateTime(2027, 1, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.91, new DateTime(2027, 1, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_47" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 42.509999999999998, new DateTime(2027, 1, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.560000000000002, new DateTime(2027, 1, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.719999999999999, new DateTime(2027, 1, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.039999999999999, new DateTime(2027, 1, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.140000000000001, new DateTime(2027, 1, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.960000000000001, new DateTime(2027, 1, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.81, new DateTime(2027, 1, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.9800000000000004, new DateTime(2027, 1, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.920000000000002, new DateTime(2027, 1, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.23, new DateTime(2027, 1, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_48" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.84, new DateTime(2027, 1, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 55.880000000000003, new DateTime(2027, 1, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.27, new DateTime(2027, 1, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.210000000000001, new DateTime(2027, 1, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.170000000000002, new DateTime(2027, 1, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.1, new DateTime(2027, 1, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.8900000000000001, new DateTime(2027, 1, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.23, new DateTime(2027, 1, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.510000000000002, new DateTime(2027, 1, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.16, new DateTime(2027, 1, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_49" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.6799999999999997, new DateTime(2027, 1, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.21, new DateTime(2027, 1, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 33.850000000000001, new DateTime(2027, 1, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.010000000000002, new DateTime(2027, 1, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.550000000000001, new DateTime(2027, 1, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.199999999999999, new DateTime(2027, 1, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.7800000000000002, new DateTime(2027, 1, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 64.849999999999994, new DateTime(2027, 1, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.66, new DateTime(2027, 1, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.34, new DateTime(2027, 1, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_50" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.859999999999999, new DateTime(2027, 1, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.66, new DateTime(2027, 1, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.02, new DateTime(2027, 1, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.469999999999999, new DateTime(2027, 1, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.06, new DateTime(2027, 1, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.42, new DateTime(2027, 1, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.789999999999999, new DateTime(2027, 1, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 58.200000000000003, new DateTime(2027, 2, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.7000000000000002, new DateTime(2027, 2, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.5, new DateTime(2027, 2, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_51" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.25, new DateTime(2027, 2, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.2000000000000002, new DateTime(2027, 2, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.19, new DateTime(2027, 2, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.4900000000000002, new DateTime(2027, 2, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.1399999999999997, new DateTime(2027, 2, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.210000000000001, new DateTime(2027, 2, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 45.07, new DateTime(2027, 2, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 70.959999999999994, new DateTime(2027, 2, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.56, new DateTime(2027, 2, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.920000000000002, new DateTime(2027, 2, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_52" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.0, new DateTime(2027, 2, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.3800000000000008, new DateTime(2027, 2, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.15, new DateTime(2027, 2, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.6000000000000001, new DateTime(2027, 2, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.06, new DateTime(2027, 2, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.260000000000002, new DateTime(2027, 2, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 36.259999999999998, new DateTime(2027, 2, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.670000000000002, new DateTime(2027, 2, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.039999999999999, new DateTime(2027, 2, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.25, new DateTime(2027, 2, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_53" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.5299999999999998, new DateTime(2027, 2, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 50.310000000000002, new DateTime(2027, 2, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.3500000000000001, new DateTime(2027, 2, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.380000000000001, new DateTime(2027, 2, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.41, new DateTime(2027, 2, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.75, new DateTime(2027, 2, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.390000000000001, new DateTime(2027, 2, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.5300000000000002, new DateTime(2027, 2, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.1699999999999999, new DateTime(2027, 2, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.16, new DateTime(2027, 2, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_54" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.840000000000003, new DateTime(2027, 2, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.890000000000001, new DateTime(2027, 2, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.1900000000000004, new DateTime(2027, 2, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.850000000000001, new DateTime(2027, 2, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.359999999999999, new DateTime(2027, 2, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.530000000000001, new DateTime(2027, 2, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.1500000000000004, new DateTime(2027, 2, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 48.149999999999999, new DateTime(2027, 2, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.850000000000001, new DateTime(2027, 2, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.030000000000001, new DateTime(2027, 2, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_55" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.25, new DateTime(2027, 2, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.6100000000000003, new DateTime(2027, 2, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.9900000000000002, new DateTime(2027, 2, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.3999999999999999, new DateTime(2027, 2, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 49.399999999999999, new DateTime(2027, 2, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.539999999999999, new DateTime(2027, 2, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.4, new DateTime(2027, 2, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.3700000000000001, new DateTime(2027, 2, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.289999999999999, new DateTime(2027, 2, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.850000000000001, new DateTime(2027, 2, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_56" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.120000000000001, new DateTime(2027, 2, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.75, new DateTime(2027, 2, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.030000000000001, new DateTime(2027, 2, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.9100000000000001, new DateTime(2027, 2, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.93, new DateTime(2027, 2, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.0899999999999999, new DateTime(2027, 3, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.4, new DateTime(2027, 3, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.8600000000000003, new DateTime(2027, 3, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.8999999999999999, new DateTime(2027, 3, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.850000000000001, new DateTime(2027, 3, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_57" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.579999999999998, new DateTime(2027, 3, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.23, new DateTime(2027, 3, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.77, new DateTime(2027, 3, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.989999999999998, new DateTime(2027, 3, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.710000000000001, new DateTime(2027, 3, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.789999999999999, new DateTime(2027, 3, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.789999999999999, new DateTime(2027, 3, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.309999999999999, new DateTime(2027, 3, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.1199999999999992, new DateTime(2027, 3, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.520000000000003, new DateTime(2027, 3, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_58" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 69.549999999999997, new DateTime(2027, 3, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.04, new DateTime(2027, 3, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "Date", "Name" },
                values: new object[] { new DateTime(2027, 3, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.8400000000000001, new DateTime(2027, 3, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.039999999999999, new DateTime(2027, 3, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.68, new DateTime(2027, 3, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.6300000000000008, new DateTime(2027, 3, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.350000000000001, new DateTime(2027, 3, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.16, new DateTime(2027, 3, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.79, new DateTime(2027, 3, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_59" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.619999999999999, new DateTime(2027, 3, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.550000000000001, new DateTime(2027, 3, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.7400000000000002, new DateTime(2027, 3, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.840000000000003, new DateTime(2027, 3, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.3700000000000001, new DateTime(2027, 3, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 43.93, new DateTime(2027, 3, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.829999999999998, new DateTime(2027, 3, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.66, new DateTime(2027, 3, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 63.030000000000001, new DateTime(2027, 3, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.670000000000002, new DateTime(2027, 3, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_60" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.02, new DateTime(2027, 3, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.27, new DateTime(2027, 3, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.2599999999999998, new DateTime(2027, 3, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.8700000000000001, new DateTime(2027, 3, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.08, new DateTime(2027, 3, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.399999999999999, new DateTime(2027, 3, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.789999999999999, new DateTime(2027, 3, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.71, new DateTime(2027, 3, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 53.590000000000003, new DateTime(2027, 3, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.1499999999999999, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_61" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.489999999999998, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.310000000000002, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.76, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 62.359999999999999, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.440000000000001, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 48.960000000000001, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.58, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.149999999999999, new DateTime(2027, 3, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.079999999999998, new DateTime(2027, 3, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 45.880000000000003, new DateTime(2027, 3, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_62" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.0, new DateTime(2027, 3, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.1699999999999999, new DateTime(2027, 3, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.85, new DateTime(2027, 3, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.329999999999998, new DateTime(2027, 3, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.7000000000000002, new DateTime(2027, 3, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.34, new DateTime(2027, 3, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 41.810000000000002, new DateTime(2027, 4, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.51, new DateTime(2027, 4, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.440000000000001, new DateTime(2027, 4, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.5, new DateTime(2027, 4, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_63" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.239999999999998, new DateTime(2027, 4, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.640000000000001, new DateTime(2027, 4, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.6, new DateTime(2027, 4, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.800000000000001, new DateTime(2027, 4, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.359999999999999, new DateTime(2027, 4, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.1199999999999992, new DateTime(2027, 4, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.199999999999999, new DateTime(2027, 4, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.949999999999999, new DateTime(2027, 4, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.100000000000001, new DateTime(2027, 4, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.4400000000000004, new DateTime(2027, 4, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_64" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.25, new DateTime(2027, 4, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.300000000000001, new DateTime(2027, 4, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.039999999999999, new DateTime(2027, 4, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 33.340000000000003, new DateTime(2027, 4, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.960000000000001, new DateTime(2027, 4, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.72, new DateTime(2027, 4, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.710000000000001, new DateTime(2027, 4, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.780000000000001, new DateTime(2027, 4, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.73, new DateTime(2027, 4, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.9800000000000004, new DateTime(2027, 4, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_65" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.4100000000000001, new DateTime(2027, 4, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.3600000000000003, new DateTime(2027, 4, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.9299999999999997, new DateTime(2027, 4, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.42, new DateTime(2027, 4, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.989999999999998, new DateTime(2027, 4, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.739999999999998, new DateTime(2027, 4, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.8800000000000008, new DateTime(2027, 4, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.260000000000002, new DateTime(2027, 4, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.31, new DateTime(2027, 4, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.18, new DateTime(2027, 4, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_66" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.25, new DateTime(2027, 4, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.3700000000000001, new DateTime(2027, 4, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.0, new DateTime(2027, 4, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.9900000000000002, new DateTime(2027, 4, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.280000000000001, new DateTime(2027, 4, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.5, new DateTime(2027, 4, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.859999999999999, new DateTime(2027, 4, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.010000000000002, new DateTime(2027, 4, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.32, new DateTime(2027, 4, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.380000000000001, new DateTime(2027, 4, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_67" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 71.670000000000002, new DateTime(2027, 4, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.5199999999999996, new DateTime(2027, 4, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.5099999999999998, new DateTime(2027, 4, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.5199999999999996, new DateTime(2027, 4, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.579999999999998, new DateTime(2027, 4, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.870000000000001, new DateTime(2027, 4, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.7400000000000002, new DateTime(2027, 4, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.899999999999999, new DateTime(2027, 4, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.859999999999999, new DateTime(2027, 4, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.6200000000000001, new DateTime(2027, 4, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_68" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.59, new DateTime(2027, 4, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.690000000000001, new DateTime(2027, 4, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.479999999999997, new DateTime(2027, 4, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.0999999999999996, new DateTime(2027, 4, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.3799999999999999, new DateTime(2027, 4, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.1400000000000006, new DateTime(2027, 4, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.350000000000001, new DateTime(2027, 4, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.760000000000002, new DateTime(2027, 4, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.0800000000000001, new DateTime(2027, 4, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.06, new DateTime(2027, 4, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_69" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.1699999999999999, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.98, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.67, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.2799999999999994, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.2999999999999998, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.69, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.75, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.300000000000001, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 57.0, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.43, new DateTime(2027, 5, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_70" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.300000000000001, new DateTime(2027, 5, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.1899999999999995, new DateTime(2027, 5, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.059999999999999, new DateTime(2027, 5, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.550000000000001, new DateTime(2027, 5, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.79, new DateTime(2027, 5, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 40.170000000000002, new DateTime(2027, 5, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.5, new DateTime(2027, 5, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.0, new DateTime(2027, 5, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.940000000000001, new DateTime(2027, 5, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.219999999999999, new DateTime(2027, 5, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_71" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.3499999999999996, new DateTime(2027, 5, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.300000000000001, new DateTime(2027, 5, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.229999999999997, new DateTime(2027, 5, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.450000000000003, new DateTime(2027, 5, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.170000000000002, new DateTime(2027, 5, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 74.799999999999997, new DateTime(2027, 5, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.75, new DateTime(2027, 5, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 56.229999999999997, new DateTime(2027, 5, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.359999999999999, new DateTime(2027, 5, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.0899999999999999, new DateTime(2027, 5, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_72" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.0, new DateTime(2027, 5, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.210000000000001, new DateTime(2027, 5, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.880000000000001, new DateTime(2027, 5, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.7000000000000002, new DateTime(2027, 5, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.5199999999999996, new DateTime(2027, 5, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.1499999999999999, new DateTime(2027, 5, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.920000000000002, new DateTime(2027, 5, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.18, new DateTime(2027, 5, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.629999999999999, new DateTime(2027, 5, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.120000000000001, new DateTime(2027, 5, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_73" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.469999999999999, new DateTime(2027, 5, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.489999999999998, new DateTime(2027, 5, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.7300000000000004, new DateTime(2027, 5, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.25, new DateTime(2027, 5, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 41.82, new DateTime(2027, 5, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.85, new DateTime(2027, 5, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.77, new DateTime(2027, 5, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.3700000000000001, new DateTime(2027, 5, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.6399999999999997, new DateTime(2027, 5, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 76.840000000000003, new DateTime(2027, 5, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_74" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.890000000000001, new DateTime(2027, 5, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.32, new DateTime(2027, 5, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.579999999999998, new DateTime(2027, 5, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.649999999999999, new DateTime(2027, 5, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.720000000000001, new DateTime(2027, 5, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.9699999999999998, new DateTime(2027, 5, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 50.390000000000001, new DateTime(2027, 5, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.02, new DateTime(2027, 5, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 66.450000000000003, new DateTime(2027, 5, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.0599999999999996, new DateTime(2027, 5, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_75" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 41.57, new DateTime(2027, 5, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.8700000000000001, new DateTime(2027, 5, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.260000000000002, new DateTime(2027, 5, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.670000000000002, new DateTime(2027, 5, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.93, new DateTime(2027, 5, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.149999999999999, new DateTime(2027, 5, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.719999999999999, new DateTime(2027, 5, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 42.5, new DateTime(2027, 5, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.3700000000000001, new DateTime(2027, 5, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.1400000000000006, new DateTime(2027, 5, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_76" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.640000000000001, new DateTime(2027, 5, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.710000000000001, new DateTime(2027, 5, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.49, new DateTime(2027, 5, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.93, new DateTime(2027, 5, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.57, new DateTime(2027, 5, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.960000000000001, new DateTime(2027, 5, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.720000000000001, new DateTime(2027, 6, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 76.920000000000002, new DateTime(2027, 6, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.93, new DateTime(2027, 6, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.65, new DateTime(2027, 6, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_77" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.120000000000001, new DateTime(2027, 6, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.52, new DateTime(2027, 6, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.129999999999999, new DateTime(2027, 6, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.219999999999999, new DateTime(2027, 6, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.739999999999998, new DateTime(2027, 6, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 38.799999999999997, new DateTime(2027, 6, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 44.539999999999999, new DateTime(2027, 6, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.219999999999999, new DateTime(2027, 6, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.75, new DateTime(2027, 6, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.1299999999999999, new DateTime(2027, 6, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_78" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.75, new DateTime(2027, 6, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.6, new DateTime(2027, 6, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.859999999999999, new DateTime(2027, 6, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.5, new DateTime(2027, 6, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 47.68, new DateTime(2027, 6, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 36.740000000000002, new DateTime(2027, 6, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.050000000000001, new DateTime(2027, 6, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.98, new DateTime(2027, 6, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.050000000000001, new DateTime(2027, 6, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.539999999999999, new DateTime(2027, 6, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_79" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.899999999999999, new DateTime(2027, 6, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.4199999999999999, new DateTime(2027, 6, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.91, new DateTime(2027, 6, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.42, new DateTime(2027, 6, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.619999999999999, new DateTime(2027, 6, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.050000000000001, new DateTime(2027, 6, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.94, new DateTime(2027, 6, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.8899999999999997, new DateTime(2027, 6, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.6299999999999999, new DateTime(2027, 6, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.68, new DateTime(2027, 6, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_80" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.780000000000001, new DateTime(2027, 6, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.26, new DateTime(2027, 6, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.02, new DateTime(2027, 6, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.1500000000000004, new DateTime(2027, 6, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.190000000000001, new DateTime(2027, 6, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.880000000000001, new DateTime(2027, 6, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.390000000000001, new DateTime(2027, 6, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.920000000000002, new DateTime(2027, 6, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.390000000000001, new DateTime(2027, 6, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.079999999999998, new DateTime(2027, 6, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_81" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.4500000000000002, new DateTime(2027, 6, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 54.25, new DateTime(2027, 6, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.390000000000001, new DateTime(2027, 6, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.210000000000001, new DateTime(2027, 6, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.9900000000000002, new DateTime(2027, 6, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.309999999999999, new DateTime(2027, 6, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.369999999999999, new DateTime(2027, 6, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 56.0, new DateTime(2027, 6, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.4199999999999999, new DateTime(2027, 6, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.1200000000000001, new DateTime(2027, 6, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_82" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.66, new DateTime(2027, 6, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.07, new DateTime(2027, 6, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.1, new DateTime(2027, 6, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.48, new DateTime(2027, 6, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.0999999999999996, new DateTime(2027, 6, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.829999999999998, new DateTime(2027, 6, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.81, new DateTime(2027, 6, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 56.07, new DateTime(2027, 6, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.949999999999999, new DateTime(2027, 6, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.9000000000000004, new DateTime(2027, 7, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_83" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.29, new DateTime(2027, 7, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.0999999999999996, new DateTime(2027, 7, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.879999999999999, new DateTime(2027, 7, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.46, new DateTime(2027, 7, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.629999999999999, new DateTime(2027, 7, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 65.430000000000007, new DateTime(2027, 7, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 12.359999999999999, new DateTime(2027, 7, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.8799999999999999, new DateTime(2027, 7, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.670000000000002, new DateTime(2027, 7, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 53.82, new DateTime(2027, 7, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_84" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.630000000000001, new DateTime(2027, 7, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.4, new DateTime(2027, 7, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.0899999999999999, new DateTime(2027, 7, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.32, new DateTime(2027, 7, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.140000000000001, new DateTime(2027, 7, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.560000000000002, new DateTime(2027, 7, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.21, new DateTime(2027, 7, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.8399999999999999, new DateTime(2027, 7, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.3100000000000001, new DateTime(2027, 7, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.9800000000000004, new DateTime(2027, 7, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_85" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 39.380000000000003, new DateTime(2027, 7, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.300000000000001, new DateTime(2027, 7, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.9299999999999997, new DateTime(2027, 7, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.7999999999999998, new DateTime(2027, 7, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.219999999999999, new DateTime(2027, 7, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.309999999999999, new DateTime(2027, 7, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.920000000000002, new DateTime(2027, 7, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.23, new DateTime(2027, 7, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 24.940000000000001, new DateTime(2027, 7, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.060000000000002, new DateTime(2027, 7, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_86" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.710000000000001, new DateTime(2027, 7, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.920000000000002, new DateTime(2027, 7, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.29, new DateTime(2027, 7, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.829999999999998, new DateTime(2027, 7, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.300000000000001, new DateTime(2027, 7, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 55.259999999999998, new DateTime(2027, 7, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.380000000000001, new DateTime(2027, 7, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 45.020000000000003, new DateTime(2027, 7, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.8199999999999998, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.16, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_87" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.7199999999999998, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.800000000000001, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.120000000000001, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.5, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.789999999999999, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.880000000000001, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.460000000000001, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.65, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.620000000000001, new DateTime(2027, 7, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.470000000000001, new DateTime(2027, 7, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_88" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 57.030000000000001, new DateTime(2027, 7, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.66, new DateTime(2027, 7, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.670000000000002, new DateTime(2027, 7, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 49.710000000000001, new DateTime(2027, 7, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.9400000000000004, new DateTime(2027, 7, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.43, new DateTime(2027, 7, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.1299999999999999, new DateTime(2027, 7, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.3600000000000003, new DateTime(2027, 7, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.690000000000001, new DateTime(2027, 7, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.370000000000001, new DateTime(2027, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_89" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.969999999999999, new DateTime(2027, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.57, new DateTime(2027, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.0800000000000001, new DateTime(2027, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 35.710000000000001, new DateTime(2027, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.050000000000001, new DateTime(2027, 7, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.07, new DateTime(2027, 7, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.300000000000001, new DateTime(2027, 7, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.469999999999999, new DateTime(2027, 7, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.699999999999999, new DateTime(2027, 8, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 45.590000000000003, new DateTime(2027, 8, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_90" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.91, new DateTime(2027, 8, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.890000000000001, new DateTime(2027, 8, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 41.149999999999999, new DateTime(2027, 8, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.719999999999999, new DateTime(2027, 8, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 61.109999999999999, new DateTime(2027, 8, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.0099999999999998, new DateTime(2027, 8, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.899999999999999, new DateTime(2027, 8, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.52, new DateTime(2027, 8, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.48, new DateTime(2027, 8, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.229999999999997, new DateTime(2027, 8, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_91" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.289999999999999, new DateTime(2027, 8, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.789999999999999, new DateTime(2027, 8, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.219999999999999, new DateTime(2027, 8, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.539999999999999, new DateTime(2027, 8, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.2699999999999996, new DateTime(2027, 8, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 2.52, new DateTime(2027, 8, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.84, new DateTime(2027, 8, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 42.520000000000003, new DateTime(2027, 8, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 20.039999999999999, new DateTime(2027, 8, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.42, new DateTime(2027, 8, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_92" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.25, new DateTime(2027, 8, 11, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.4900000000000002, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.529999999999999, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 50.530000000000001, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.52, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.27, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.6099999999999994, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 46.950000000000003, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.050000000000001, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.010000000000002, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_93" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.9900000000000002, new DateTime(2027, 8, 12, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.5700000000000001, new DateTime(2027, 8, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.779999999999999, new DateTime(2027, 8, 13, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.870000000000001, new DateTime(2027, 8, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.760000000000002, new DateTime(2027, 8, 14, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.56, new DateTime(2027, 8, 15, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.690000000000001, new DateTime(2027, 8, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 10.960000000000001, new DateTime(2027, 8, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.170000000000002, new DateTime(2027, 8, 16, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 34.289999999999999, new DateTime(2027, 8, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_94" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 61.0, new DateTime(2027, 8, 17, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 6.5899999999999999, new DateTime(2027, 8, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 47.030000000000001, new DateTime(2027, 8, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 25.25, new DateTime(2027, 8, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.789999999999999, new DateTime(2027, 8, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 22.23, new DateTime(2027, 8, 18, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 66.549999999999997, new DateTime(2027, 8, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.940000000000001, new DateTime(2027, 8, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.15, new DateTime(2027, 8, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 28.82, new DateTime(2027, 8, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_95" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.010000000000002, new DateTime(2027, 8, 19, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.43, new DateTime(2027, 8, 20, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 31.469999999999999, new DateTime(2027, 8, 21, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 3.9199999999999999, new DateTime(2027, 8, 22, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.0, new DateTime(2027, 8, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.949999999999999, new DateTime(2027, 8, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.1500000000000004, new DateTime(2027, 8, 23, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.8100000000000005, new DateTime(2027, 8, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.4299999999999997, new DateTime(2027, 8, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 32.219999999999999, new DateTime(2027, 8, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_96" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.039999999999999, new DateTime(2027, 8, 24, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 19.57, new DateTime(2027, 8, 25, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.0899999999999999, new DateTime(2027, 8, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.579999999999998, new DateTime(2027, 8, 26, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.489999999999998, new DateTime(2027, 8, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.460000000000001, new DateTime(2027, 8, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.800000000000001, new DateTime(2027, 8, 27, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.140000000000001, new DateTime(2027, 8, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 18.870000000000001, new DateTime(2027, 8, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 26.66, new DateTime(2027, 8, 28, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_97" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 7.4199999999999999, new DateTime(2027, 8, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 23.170000000000002, new DateTime(2027, 8, 29, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 13.710000000000001, new DateTime(2027, 8, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 21.670000000000002, new DateTime(2027, 8, 30, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 5.1200000000000001, new DateTime(2027, 8, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 11.77, new DateTime(2027, 8, 31, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 29.52, new DateTime(2027, 9, 1, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 37.840000000000003, new DateTime(2027, 9, 2, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 9.8200000000000003, new DateTime(2027, 9, 3, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 65.140000000000001, new DateTime(2027, 9, 4, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_98" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.050000000000001, new DateTime(2027, 9, 5, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 92.329999999999998, new DateTime(2027, 9, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cat Food_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 17.530000000000001, new DateTime(2027, 9, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Cigarettes_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 27.48, new DateTime(2027, 9, 6, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Coffee_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 14.17, new DateTime(2027, 9, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Tea_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 4.7599999999999998, new DateTime(2027, 9, 7, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Economies_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 1.8100000000000001, new DateTime(2027, 9, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Phone bills_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 30.039999999999999, new DateTime(2027, 9, 8, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Restaurant_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 15.67, new DateTime(2027, 9, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Presents_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 16.920000000000002, new DateTime(2027, 9, 9, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Eletricity and gaz_99" });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Amount", "Date", "Name" },
                values: new object[] { 8.5, new DateTime(2027, 9, 10, 7, 13, 5, 511, DateTimeKind.Local).AddTicks(4707), "Food_100" });
        }
    }
}
