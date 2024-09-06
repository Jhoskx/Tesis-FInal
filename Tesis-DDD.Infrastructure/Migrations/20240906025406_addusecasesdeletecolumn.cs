using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tesis_DDD.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addusecasesdeletecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "UseCases");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UseCases",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
