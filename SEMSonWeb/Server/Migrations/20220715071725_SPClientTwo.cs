using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class SPClientTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientClassdb_PHClassCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientDepdb_PHDepCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientPosdb_PHPosCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientPredb_PHPreCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_PHClassCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_PHDepCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_PHPosCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_PHPreCode",
                table: "SPClientProfiledb");

            migrationBuilder.AlterColumn<string>(
                name: "PHPreCode",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHPosCode",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHDepCode",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHClassCode",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LSPClientClassPHClassCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LSPClientDepPHDepCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LSPClientPosPHPosCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LSPClientPrePHPreCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_LSPClientClassPHClassCode",
                table: "SPClientProfiledb",
                column: "LSPClientClassPHClassCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_LSPClientDepPHDepCode",
                table: "SPClientProfiledb",
                column: "LSPClientDepPHDepCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_LSPClientPosPHPosCode",
                table: "SPClientProfiledb",
                column: "LSPClientPosPHPosCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_LSPClientPrePHPreCode",
                table: "SPClientProfiledb",
                column: "LSPClientPrePHPreCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientClassdb_LSPClientClassPHClassCode",
                table: "SPClientProfiledb",
                column: "LSPClientClassPHClassCode",
                principalTable: "SPClientClassdb",
                principalColumn: "PHClassCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientDepdb_LSPClientDepPHDepCode",
                table: "SPClientProfiledb",
                column: "LSPClientDepPHDepCode",
                principalTable: "SPClientDepdb",
                principalColumn: "PHDepCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientPosdb_LSPClientPosPHPosCode",
                table: "SPClientProfiledb",
                column: "LSPClientPosPHPosCode",
                principalTable: "SPClientPosdb",
                principalColumn: "PHPosCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientPredb_LSPClientPrePHPreCode",
                table: "SPClientProfiledb",
                column: "LSPClientPrePHPreCode",
                principalTable: "SPClientPredb",
                principalColumn: "PHPreCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientClassdb_LSPClientClassPHClassCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientDepdb_LSPClientDepPHDepCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientPosdb_LSPClientPosPHPosCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientPredb_LSPClientPrePHPreCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_LSPClientClassPHClassCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_LSPClientDepPHDepCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_LSPClientPosPHPosCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_LSPClientPrePHPreCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropColumn(
                name: "LSPClientClassPHClassCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropColumn(
                name: "LSPClientDepPHDepCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropColumn(
                name: "LSPClientPosPHPosCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropColumn(
                name: "LSPClientPrePHPreCode",
                table: "SPClientProfiledb");

            migrationBuilder.AlterColumn<string>(
                name: "PHPreCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHPosCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHDepCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHClassCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_PHClassCode",
                table: "SPClientProfiledb",
                column: "PHClassCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_PHDepCode",
                table: "SPClientProfiledb",
                column: "PHDepCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_PHPosCode",
                table: "SPClientProfiledb",
                column: "PHPosCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_PHPreCode",
                table: "SPClientProfiledb",
                column: "PHPreCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientClassdb_PHClassCode",
                table: "SPClientProfiledb",
                column: "PHClassCode",
                principalTable: "SPClientClassdb",
                principalColumn: "PHClassCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientDepdb_PHDepCode",
                table: "SPClientProfiledb",
                column: "PHDepCode",
                principalTable: "SPClientDepdb",
                principalColumn: "PHDepCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientPosdb_PHPosCode",
                table: "SPClientProfiledb",
                column: "PHPosCode",
                principalTable: "SPClientPosdb",
                principalColumn: "PHPosCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientPredb_PHPreCode",
                table: "SPClientProfiledb",
                column: "PHPreCode",
                principalTable: "SPClientPredb",
                principalColumn: "PHPreCode");
        }
    }
}
