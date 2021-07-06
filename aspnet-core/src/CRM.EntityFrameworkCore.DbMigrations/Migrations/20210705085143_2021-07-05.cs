using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Migrations
{
    public partial class _20210705 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CRMProductDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Long = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Wide = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    High = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRMProductDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CRMProductDetail_CRMProduct_ProductID",
                        column: x => x.ProductID,
                        principalTable: "CRMProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CRMProductDetail_ProductID",
                table: "CRMProductDetail",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CRMProductDetail");
        }
    }
}
