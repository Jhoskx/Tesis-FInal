using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateTableProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeploymentTime",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "TestingHours",
                table: "Projects",
                newName: "TypeEstimationId");

            migrationBuilder.CreateTable(
                name: "TypeEstimation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEstimation", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TypeEstimationId",
                table: "Projects",
                column: "TypeEstimationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_TypeEstimation_TypeEstimationId",
                table: "Projects",
                column: "TypeEstimationId",
                principalTable: "TypeEstimation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_TypeEstimation_TypeEstimationId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "TypeEstimation");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TypeEstimationId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "TypeEstimationId",
                table: "Projects",
                newName: "TestingHours");

            migrationBuilder.AddColumn<int>(
                name: "DeploymentTime",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
