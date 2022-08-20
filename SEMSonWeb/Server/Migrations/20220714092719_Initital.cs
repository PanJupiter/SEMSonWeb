using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class Initital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SPClientClassdb",
                columns: table => new
                {
                    PHClassCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHClassName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPClientClassdb", x => x.PHClassCode);
                });

            migrationBuilder.CreateTable(
                name: "SPClientDepdb",
                columns: table => new
                {
                    PHDepCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHDepName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPClientDepdb", x => x.PHDepCode);
                });

            migrationBuilder.CreateTable(
                name: "SPClientPosdb",
                columns: table => new
                {
                    PHPosCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHPosName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPClientPosdb", x => x.PHPosCode);
                });

            migrationBuilder.CreateTable(
                name: "SPClientPredb",
                columns: table => new
                {
                    PHPreCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHPreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPClientPredb", x => x.PHPreCode);
                });

            migrationBuilder.CreateTable(
                name: "SPHisActiondb",
                columns: table => new
                {
                    PHHisActionCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHIDuser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHIDequip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHequipBorrow = table.Column<int>(type: "int", nullable: false),
                    PHequipReturn = table.Column<int>(type: "int", nullable: false),
                    PHborrow = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PHreturn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPHisActiondb", x => x.PHHisActionCode);
                });

            migrationBuilder.CreateTable(
                name: "SPModelSportdb",
                columns: table => new
                {
                    PHSportCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHSportName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPModelSportdb", x => x.PHSportCode);
                });

            migrationBuilder.CreateTable(
                name: "SPModelEquipdb",
                columns: table => new
                {
                    PHEquipCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHEquipName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHEquipImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHEquipStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHEquipAmount = table.Column<int>(type: "int", nullable: false),
                    PHEquipTotal = table.Column<int>(type: "int", nullable: false),
                    PHEquipUnit = table.Column<int>(type: "int", nullable: false),
                    PHEquipwhenCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PHEquipwhenEdit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PHEquipWhoCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHEquipWhoEdit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LSPModelSportPHSportCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPModelEquipdb", x => x.PHEquipCode);
                    table.ForeignKey(
                        name: "FK_SPModelEquipdb_SPModelSportdb_LSPModelSportPHSportCode",
                        column: x => x.LSPModelSportPHSportCode,
                        principalTable: "SPModelSportdb",
                        principalColumn: "PHSportCode");
                });

            migrationBuilder.CreateTable(
                name: "SPClientProfiledb",
                columns: table => new
                {
                    PHClassCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHDepCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHPosCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHPreCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHProfileCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHProfilefName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHProfilelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHProfileEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHProfileImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHProfilePhone = table.Column<int>(type: "int", nullable: false),
                    PHProfileClassroom = table.Column<int>(type: "int", nullable: false),
                    PHProfileIDcard = table.Column<int>(type: "int", nullable: false),
                    PHProfileIDstudent = table.Column<int>(type: "int", nullable: false),
                    PHwhenCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PHwhenEdit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PHWhoCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHWhoEdit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPClientUserPHUserCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPClientProfiledb", x => new { x.PHClassCode, x.PHDepCode, x.PHPosCode, x.PHPreCode });
                    table.ForeignKey(
                        name: "FK_SPClientProfiledb_SPClientClassdb_PHClassCode",
                        column: x => x.PHClassCode,
                        principalTable: "SPClientClassdb",
                        principalColumn: "PHClassCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SPClientProfiledb_SPClientDepdb_PHDepCode",
                        column: x => x.PHDepCode,
                        principalTable: "SPClientDepdb",
                        principalColumn: "PHDepCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SPClientProfiledb_SPClientPosdb_PHPosCode",
                        column: x => x.PHPosCode,
                        principalTable: "SPClientPosdb",
                        principalColumn: "PHPosCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SPClientProfiledb_SPClientPredb_PHPreCode",
                        column: x => x.PHPreCode,
                        principalTable: "SPClientPredb",
                        principalColumn: "PHPreCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SPClientUserdb",
                columns: table => new
                {
                    PHUserCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PHUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHUserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHUserState = table.Column<bool>(type: "bit", nullable: false),
                    PHUserwhenCreate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PHUserwhenEdit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PHUserWhoCreate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHUserWhoEdit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHProfileCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LSPClientProfilePHClassCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LSPClientProfilePHDepCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LSPClientProfilePHPosCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LSPClientProfilePHPreCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPClientUserdb", x => x.PHUserCode);
                    table.ForeignKey(
                        name: "FK_SPClientUserdb_SPClientProfiledb_LSPClientProfilePHClassCode_LSPClientProfilePHDepCode_LSPClientProfilePHPosCode_LSPClientPr~",
                        columns: x => new { x.LSPClientProfilePHClassCode, x.LSPClientProfilePHDepCode, x.LSPClientProfilePHPosCode, x.LSPClientProfilePHPreCode },
                        principalTable: "SPClientProfiledb",
                        principalColumns: new[] { "PHClassCode", "PHDepCode", "PHPosCode", "PHPreCode" });
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SPClientProfiledb_SPClientUserPHUserCode",
                table: "SPClientProfiledb",
                column: "SPClientUserPHUserCode");

            migrationBuilder.CreateIndex(
                name: "IX_SPClientUserdb_LSPClientProfilePHClassCode_LSPClientProfilePHDepCode_LSPClientProfilePHPosCode_LSPClientProfilePHPreCode",
                table: "SPClientUserdb",
                columns: new[] { "LSPClientProfilePHClassCode", "LSPClientProfilePHDepCode", "LSPClientProfilePHPosCode", "LSPClientProfilePHPreCode" });

            migrationBuilder.CreateIndex(
                name: "IX_SPModelEquipdb_LSPModelSportPHSportCode",
                table: "SPModelEquipdb",
                column: "LSPModelSportPHSportCode");

            migrationBuilder.AddForeignKey(
                name: "FK_SPClientProfiledb_SPClientUserdb_SPClientUserPHUserCode",
                table: "SPClientProfiledb",
                column: "SPClientUserPHUserCode",
                principalTable: "SPClientUserdb",
                principalColumn: "PHUserCode");
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
                name: "FK_SPClientProfiledb_SPClientUserdb_SPClientUserPHUserCode",
                table: "SPClientProfiledb");

            migrationBuilder.DropTable(
                name: "SPHisActiondb");

            migrationBuilder.DropTable(
                name: "SPModelEquipdb");

            migrationBuilder.DropTable(
                name: "SPModelSportdb");

            migrationBuilder.DropTable(
                name: "SPClientClassdb");

            migrationBuilder.DropTable(
                name: "SPClientDepdb");

            migrationBuilder.DropTable(
                name: "SPClientPosdb");

            migrationBuilder.DropTable(
                name: "SPClientPredb");

            migrationBuilder.DropTable(
                name: "SPClientUserdb");

            migrationBuilder.DropTable(
                name: "SPClientProfiledb");
        }
    }
}
