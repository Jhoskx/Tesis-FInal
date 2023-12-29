using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Screens1");

            migrationBuilder.AddColumn<string>(
                name: "DevelopmentArea",
                table: "Screens1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DevelopmentArea",
                table: "Screens1");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Screens1",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
