using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntregaModulo6.Migrations
{
    /// <inheritdoc />
    public partial class testMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "pacote",
                columns: new[] { "id", "duracao", "nome", "preco" },
                values: new object[] { 1, "2 dias / 1 noite", "RJTRIP STANDARD", 2500f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pacote",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
