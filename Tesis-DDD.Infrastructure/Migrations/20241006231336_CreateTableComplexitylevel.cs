using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableComplexitylevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Complexity",
                table: "UseCases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ComplexityId",
                table: "UseCases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UseCases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "UseCases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId1",
                table: "UseCases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Transactions",
                table: "UseCases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UseCases_ProjectId1",
                table: "UseCases",
                column: "ProjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UseCases_Projects_ProjectId1",
                table: "UseCases",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UseCases_Projects_ProjectId1",
                table: "UseCases");

            migrationBuilder.DropIndex(
                name: "IX_UseCases_ProjectId1",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "Complexity",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "ComplexityId",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "UseCases");

            migrationBuilder.DropColumn(
                name: "Transactions",
                table: "UseCases");
        }
    }
}
