using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class addIndustry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company",
                table: "Stocks",
                newName: "Industry");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Stocks");

            migrationBuilder.RenameColumn(
                name: "Industry",
                table: "Stocks",
                newName: "Company");
        }
    }
}
