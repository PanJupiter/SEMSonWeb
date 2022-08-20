using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class SPModelOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PHSportCode",
                table: "SPModelEquipdb",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PHUserState",
                table: "SPClientUserdb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHSportCode",
                table: "SPModelEquipdb");

            migrationBuilder.AlterColumn<bool>(
                name: "PHUserState",
                table: "SPClientUserdb",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
