using Microsoft.EntityFrameworkCore.Migrations;

namespace WebABC.Web.Migrations
{
    public partial class CreateDatabasev4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Bills_IdProduct",
                table: "BillDetails");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_IdBill",
                table: "BillDetails",
                column: "IdBill");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Bills_IdBill",
                table: "BillDetails",
                column: "IdBill",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Bills_IdBill",
                table: "BillDetails");

            migrationBuilder.DropIndex(
                name: "IX_BillDetails_IdBill",
                table: "BillDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Bills_IdProduct",
                table: "BillDetails",
                column: "IdProduct",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
