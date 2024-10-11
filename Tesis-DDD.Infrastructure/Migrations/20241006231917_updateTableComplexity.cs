using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateTableComplexity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ComplexityId",
                table: "UseCases",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ComplexityId",
                table: "UseCases",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
