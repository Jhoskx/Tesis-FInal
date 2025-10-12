using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTableProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DevelopmentType",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ResponsiblePosition",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChargeId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DevelopmentTypeId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AreaId",
                table: "Projects",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ChargeId",
                table: "Projects",
                column: "ChargeId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DevelopmentTypeId",
                table: "Projects",
                column: "DevelopmentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Areas_AreaId",
                table: "Projects",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Charges_ChargeId",
                table: "Projects",
                column: "ChargeId",
                principalTable: "Charges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_DevelopmentTypes_DevelopmentTypeId",
                table: "Projects",
                column: "DevelopmentTypeId",
                principalTable: "DevelopmentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Areas_AreaId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Charges_ChargeId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_DevelopmentTypes_DevelopmentTypeId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_AreaId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ChargeId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_DevelopmentTypeId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ChargeId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DevelopmentTypeId",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DevelopmentType",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResponsiblePosition",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
