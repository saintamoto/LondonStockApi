using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockApi.Migrations
{
    /// <inheritdoc />
    public partial class Stockdataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Share", "StockName", "Ticker", "Value" },
                values: new object[,]
                {
                    { 1, 33, "Apple Inc.", "AAPL", "£197.11" },
                    { 2, 82, "Apple Inc.", "TSLA", "£307.70" },
                    { 3, 12, "Microsoft Corp.", "MSFT", "£309.37" },
                    { 4, 41, "Nvidia Corp.", "NVDA", "£135.51" },
                    { 5, 166, "Rush Street Interactive.", "RSI", "£12.90" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
