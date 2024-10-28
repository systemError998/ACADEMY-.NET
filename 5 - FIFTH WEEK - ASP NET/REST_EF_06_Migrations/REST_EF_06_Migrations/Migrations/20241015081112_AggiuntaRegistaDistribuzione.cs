using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REST_EF_06_Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntaRegistaDistribuzione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Distribuzione",
                table: "Film",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Regista",
                table: "Film",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distribuzione",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "Regista",
                table: "Film");
        }
    }
}
