using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntregaModulo6.Migrations
{
    /// <inheritdoc />
    public partial class migrationquepreste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "pacote",
                columns: new[] { "id", "duracao", "nome", "preco" },
                values: new object[,]
                {
                    { 2, "3 dias / 2 noites", "RJTRIP PREMIUM", 2750f },
                    { 3, "7 dias / 6 noites", "RJTRIP SUPER PREMIUM", 4500f },
                    { 4, "2 dias / 1 noites", "RJTRIP IMPERIAL", 2900f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pacote",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pacote",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pacote",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
