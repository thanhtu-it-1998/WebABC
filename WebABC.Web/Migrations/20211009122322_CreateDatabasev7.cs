using Microsoft.EntityFrameworkCore.Migrations;

namespace WebABC.Web.Migrations
{
    public partial class CreateDatabasev7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Bills_IdProduct",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Products_IdProduct",
                table: "BillDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillDetail",
                table: "BillDetail");

            migrationBuilder.RenameTable(
                name: "BillDetail",
                newName: "BillDetails");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetail_IdProduct",
                table: "BillDetails",
                newName: "IX_BillDetails_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Bills_IdProduct",
                table: "BillDetails",
                column: "IdProduct",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Products_IdProduct",
                table: "BillDetails",
                column: "IdProduct",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Bills_IdProduct",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Products_IdProduct",
                table: "BillDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails");

            migrationBuilder.RenameTable(
                name: "BillDetails",
                newName: "BillDetail");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetails_IdProduct",
                table: "BillDetail",
                newName: "IX_BillDetail_IdProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillDetail",
                table: "BillDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Bills_IdProduct",
                table: "BillDetail",
                column: "IdProduct",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Products_IdProduct",
                table: "BillDetail",
                column: "IdProduct",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
