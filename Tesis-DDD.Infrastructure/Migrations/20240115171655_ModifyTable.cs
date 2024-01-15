using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropIndex(
               name: "IX_Projects_MethodologyId1",
               table: "Projects");

            migrationBuilder.DropForeignKey(
             name: "FK_Projects_Methodologies_MethodologyId1",
             table: "Projects");

            migrationBuilder.DropColumn(
                name: "MethodologyId1",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "MethodologyId",
                table: "Projects",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ProjectId",
                table: "Resources",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_MethodologyId",
                table: "Projects",
                column: "MethodologyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Methodologies_MethodologyId",
                table: "Projects",
                column: "MethodologyId",
                principalTable: "Methodologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);


            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Projects_ProjectId",
                table: "Resources",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Methodologies_MethodologyId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Projects_ProjectId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_ProjectId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Projects_MethodologyId",
                table: "Projects");
            
            migrationBuilder.DropIndex(
                name: "IX_Projects_MethodologyId1",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "MethodologyId",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
