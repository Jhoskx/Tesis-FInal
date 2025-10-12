using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class createtableResourceLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ListresourceQuery",
                table: "ListresourceQuery");

            migrationBuilder.RenameTable(
                name: "ListresourceQuery",
                newName: "Listresources");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listresources",
                table: "Listresources",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Listresources",
                table: "Listresources");

            migrationBuilder.RenameTable(
                name: "Listresources",
                newName: "ListresourceQuery");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListresourceQuery",
                table: "ListresourceQuery",
                column: "Id");
        }
    }
}
