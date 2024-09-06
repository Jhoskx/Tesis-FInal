using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addusecases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "UseCases");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Time",
                table: "UseCases",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
