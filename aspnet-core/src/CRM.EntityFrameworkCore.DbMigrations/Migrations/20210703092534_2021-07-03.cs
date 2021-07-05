using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Migrations
{
    public partial class _20210703 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProduct",
                table: "AppProduct");

            migrationBuilder.RenameTable(
                name: "AppProduct",
                newName: "CRMProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CRMProduct",
                table: "CRMProduct",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CRMProduct",
                table: "CRMProduct");

            migrationBuilder.RenameTable(
                name: "CRMProduct",
                newName: "AppProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProduct",
                table: "AppProduct",
                column: "Id");
        }
    }
}
