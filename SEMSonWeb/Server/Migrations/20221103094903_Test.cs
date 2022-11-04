using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHequipUnits",
                table: "SPHisActiondb");

            migrationBuilder.RenameColumn(
                name: "PHProfileImg",
                table: "SPClientProfiledb",
                newName: "PHProfileStorageImg");

            migrationBuilder.AddColumn<int>(
                name: "PHEquipBroken",
                table: "SPModelEquipdb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PHEquipLost",
                table: "SPModelEquipdb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PHProfileNameImg",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHEquipBroken",
                table: "SPModelEquipdb");

            migrationBuilder.DropColumn(
                name: "PHEquipLost",
                table: "SPModelEquipdb");

            migrationBuilder.DropColumn(
                name: "PHProfileNameImg",
                table: "SPClientProfiledb");

            migrationBuilder.RenameColumn(
                name: "PHProfileStorageImg",
                table: "SPClientProfiledb",
                newName: "PHProfileImg");

            migrationBuilder.AddColumn<string>(
                name: "PHequipUnits",
                table: "SPHisActiondb",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
