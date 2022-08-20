using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class SPClientFive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SPClientUserdb_SPClientProfiledb_PHProfileCode",
                table: "SPClientUserdb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SPClientUserdb",
                table: "SPClientUserdb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientUserdb_PHProfileCode",
                table: "SPClientUserdb");

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileCode",
                table: "SPClientUserdb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SPClientUserdb",
                table: "SPClientUserdb",
                column: "PHUserCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientUserdb_PHProfileCode",
                table: "SPClientUserdb",
                column: "PHProfileCode",
                unique: true,
                filter: "[PHProfileCode] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientUserdb_SPClientProfiledb_PHProfileCode",
                table: "SPClientUserdb",
                column: "PHProfileCode",
                principalTable: "SPClientProfiledb",
                principalColumn: "PHProfileCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SPClientUserdb_SPClientProfiledb_PHProfileCode",
                table: "SPClientUserdb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SPClientUserdb",
                table: "SPClientUserdb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientUserdb_PHProfileCode",
                table: "SPClientUserdb");

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileCode",
                table: "SPClientUserdb",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SPClientUserdb",
                table: "SPClientUserdb",
                columns: new[] { "PHUserCode", "PHProfileCode" });

            migrationBuilder.CreateIndex(
                name: "IX_SPClientUserdb_PHProfileCode",
                table: "SPClientUserdb",
                column: "PHProfileCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientUserdb_SPClientProfiledb_PHProfileCode",
                table: "SPClientUserdb",
                column: "PHProfileCode",
                principalTable: "SPClientProfiledb",
                principalColumn: "PHProfileCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
