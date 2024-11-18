using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modifyusecase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Complexity",
                table: "UseCases");

            migrationBuilder.CreateIndex(
                name: "IX_UseCases_ComplexityId",
                table: "UseCases",
                column: "ComplexityId");

            migrationBuilder.AddForeignKey(
                name: "FK_UseCases_ComplexityLevels_ComplexityId",
                table: "UseCases",
                column: "ComplexityId",
                principalTable: "ComplexityLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UseCases_ComplexityLevels_ComplexityId",
                table: "UseCases");

            migrationBuilder.DropIndex(
                name: "IX_UseCases_ComplexityId",
                table: "UseCases");

            migrationBuilder.AddColumn<int>(
                name: "Complexity",
                table: "UseCases",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
