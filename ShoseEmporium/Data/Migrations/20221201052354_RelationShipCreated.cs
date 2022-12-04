using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoseEmporium.Data.Migrations
{
    public partial class RelationShipCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Vendor_Id",
                table: "Shose",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Vendor_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vendor_name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Vendor_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shose_Vendor_Id",
                table: "Shose",
                column: "Vendor_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shose_Vendors_Vendor_Id",
                table: "Shose",
                column: "Vendor_Id",
                principalTable: "Vendors",
                principalColumn: "Vendor_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shose_Vendors_Vendor_Id",
                table: "Shose");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Shose_Vendor_Id",
                table: "Shose");

            migrationBuilder.DropColumn(
                name: "Vendor_Id",
                table: "Shose");
        }
    }
}
