using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class unitesss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHequipUnit",
                table: "SPHisActiondb");

            migrationBuilder.AddColumn<string>(
                name: "PHequipUnits",
                table: "SPHisActiondb",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHequipUnits",
                table: "SPHisActiondb");

            migrationBuilder.AddColumn<int>(
                name: "PHequipUnit",
                table: "SPHisActiondb",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
