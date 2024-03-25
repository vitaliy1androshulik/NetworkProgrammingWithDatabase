using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarLetters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarLetters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CarLetters",
                columns: new[] { "Id", "Code", "Region" },
                values: new object[,]
                {
                    { 1, "AK", "Krym" },
                    { 2, "AB", "Vinnitska Oblast" },
                    { 3, "AC", "Volynska Oblast" },
                    { 4, "AE", "Dnipropetrovska Oblast" },
                    { 5, "AH", "Donetska Oblast" },
                    { 6, "AM", "Shitomerska Oblast" },
                    { 7, "AO", "Sakarpatska Oblast" },
                    { 8, "AP", "Saporishka Oblast" },
                    { 9, "AT", "Ivano-Frankivska Oblast" },
                    { 10, "AA", "Kyiv" },
                    { 11, "AI", "Kyivska Oblast" },
                    { 12, "BA", "Kirovogradska Oblast" },
                    { 13, "BB", "Lyganska Oblast" },
                    { 14, "BC", "Lvivska Oblast" },
                    { 15, "BE", "Mukolaivska Oblast" },
                    { 16, "BH", "Odeska Oblast" },
                    { 17, "BI", "Poltavska Oblast" },
                    { 18, "BK", "Rivnenska Oblast" },
                    { 19, "CH", "Sevastopol" },
                    { 20, "BM", "Sumska Oblast" },
                    { 21, "BO", "Ternopilska Oblast" },
                    { 22, "AX", "Harkivska Oblast" },
                    { 23, "BT", "Hersonska Oblast" },
                    { 24, "BX", "Hmelnytska Oblast" },
                    { 25, "CA", "Cherkaska Oblast" },
                    { 26, "CB", "Chernigivska Oblast" },
                    { 27, "CE", "Chernivetska Oblast" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarLetters");
        }
    }
}
