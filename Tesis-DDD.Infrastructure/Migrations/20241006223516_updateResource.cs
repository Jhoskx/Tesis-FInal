using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateResource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UseCases_Projects_ProjectId",
                table: "UseCases");

            migrationBuilder.DropIndex(
                name: "IX_UseCases_ProjectId",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "UseCases");

            migrationBuilder.AddColumn<int>(
                name: "AvailableHoursPerWeek",
                table: "Resources",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableHoursPerWeek",
                table: "Resources");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UseCases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "UseCases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UseCases_ProjectId",
                table: "UseCases",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_UseCases_Projects_ProjectId",
                table: "UseCases",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
