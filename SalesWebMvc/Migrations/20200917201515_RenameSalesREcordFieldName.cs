using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class RenameSalesREcordFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amout",
                table: "SalesRecord");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "SalesRecord");

            migrationBuilder.AddColumn<double>(
                name: "Amout",
                table: "SalesRecord",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
