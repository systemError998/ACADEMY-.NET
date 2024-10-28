using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REST_EF_06_Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntaCodice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codice",
                table: "Film",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Codice",
                table: "Film",
                column: "Codice",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Film_Codice",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "Codice",
                table: "Film");
        }
    }
}
