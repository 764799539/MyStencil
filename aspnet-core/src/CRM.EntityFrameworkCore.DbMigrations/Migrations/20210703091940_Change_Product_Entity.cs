using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Migrations
{
    public partial class Change_Product_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Describe",
                table: "AppProduct",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Describe",
                table: "AppProduct");
        }
    }
}
