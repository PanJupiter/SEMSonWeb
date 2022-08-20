using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class SPClientOne : Migration
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

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientProfiledb_SPClientUserdb_SPClientUserPHUserCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientUserdb_SPClientProfiledb_LSPClientProfilePHClassCode_LSPClientProfilePHDepCode_LSPClientProfilePHPosCode_LSPClientPr~",
                table: "SPClientUserdb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SPClientUserdb",
                table: "SPClientUserdb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientUserdb_LSPClientProfilePHClassCode_LSPClientProfilePHDepCode_LSPClientProfilePHPosCode_LSPClientProfilePHPreCode",
                table: "SPClientUserdb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SPClientProfiledb",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_SPClientUserPHUserCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropColumn(
                name: "LSPClientProfilePHClassCode",
                table: "SPClientUserdb");

            migrationBuilder.DropColumn(
                name: "LSPClientProfilePHDepCode",
                table: "SPClientUserdb");

            migrationBuilder.DropColumn(
                name: "LSPClientProfilePHPosCode",
                table: "SPClientUserdb");

            migrationBuilder.DropColumn(
                name: "LSPClientProfilePHPreCode",
                table: "SPClientUserdb");

            migrationBuilder.DropColumn(
                name: "SPClientUserPHUserCode",
                table: "SPClientProfiledb");

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileCode",
                table: "SPClientUserdb",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHPreCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PHPosCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PHDepCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PHClassCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SPClientUserdb",
                table: "SPClientUserdb",
                columns: new[] { "PHUserCode", "PHProfileCode" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SPClientProfiledb",
                table: "SPClientProfiledb",
                column: "PHProfileCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientUserdb_PHProfileCode",
                table: "SPClientUserdb",
                column: "PHProfileCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_PHClassCode",
                table: "SPClientProfiledb",
                column: "PHClassCode");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientUserdb_SPClientProfiledb_PHProfileCode",
                table: "SPClientUserdb",
                column: "PHProfileCode",
                principalTable: "SPClientProfiledb",
                principalColumn: "PHProfileCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_SPClientUserdb_SPClientProfiledb_PHProfileCode",
                table: "SPClientUserdb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SPClientUserdb",
                table: "SPClientUserdb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientUserdb_PHProfileCode",
                table: "SPClientUserdb");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SPClientProfiledb",
                table: "SPClientProfiledb");

            migrationBuilder.DropIndex(
                name: "IX_SPClientProfiledb_PHClassCode",
                table: "SPClientProfiledb");

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileCode",
                table: "SPClientUserdb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "LSPClientProfilePHClassCode",
                table: "SPClientUserdb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LSPClientProfilePHDepCode",
                table: "SPClientUserdb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LSPClientProfilePHPosCode",
                table: "SPClientUserdb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LSPClientProfilePHPreCode",
                table: "SPClientUserdb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHPreCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHPosCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHDepCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHClassCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileCode",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "SPClientUserPHUserCode",
                table: "SPClientProfiledb",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SPClientUserdb",
                table: "SPClientUserdb",
                column: "PHUserCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SPClientProfiledb",
                table: "SPClientProfiledb",
                columns: new[] { "PHClassCode", "PHDepCode", "PHPosCode", "PHPreCode" });

            migrationBuilder.CreateIndex(
                name: "IX_SPClientUserdb_LSPClientProfilePHClassCode_LSPClientProfilePHDepCode_LSPClientProfilePHPosCode_LSPClientProfilePHPreCode",
                table: "SPClientUserdb",
                columns: new[] { "LSPClientProfilePHClassCode", "LSPClientProfilePHDepCode", "LSPClientProfilePHPosCode", "LSPClientProfilePHPreCode" });

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_SPClientUserPHUserCode",
                table: "SPClientProfiledb",
                column: "SPClientUserPHUserCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientClassdb_PHClassCode",
                table: "SPClientProfiledb",
                column: "PHClassCode",
                principalTable: "SPClientClassdb",
                principalColumn: "PHClassCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientDepdb_PHDepCode",
                table: "SPClientProfiledb",
                column: "PHDepCode",
                principalTable: "SPClientDepdb",
                principalColumn: "PHDepCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientPosdb_PHPosCode",
                table: "SPClientProfiledb",
                column: "PHPosCode",
                principalTable: "SPClientPosdb",
                principalColumn: "PHPosCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientPredb_PHPreCode",
                table: "SPClientProfiledb",
                column: "PHPreCode",
                principalTable: "SPClientPredb",
                principalColumn: "PHPreCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientUserdb_SPClientUserPHUserCode",
                table: "SPClientProfiledb",
                column: "SPClientUserPHUserCode",
                principalTable: "SPClientUserdb",
                principalColumn: "PHUserCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientUserdb_SPClientProfiledb_LSPClientProfilePHClassCode_LSPClientProfilePHDepCode_LSPClientProfilePHPosCode_LSPClientPr~",
                table: "SPClientUserdb",
                columns: new[] { "LSPClientProfilePHClassCode", "LSPClientProfilePHDepCode", "LSPClientProfilePHPosCode", "LSPClientProfilePHPreCode" },
                principalTable: "SPClientProfiledb",
                principalColumns: new[] { "PHClassCode", "PHDepCode", "PHPosCode", "PHPreCode" });
        }
    }
}
