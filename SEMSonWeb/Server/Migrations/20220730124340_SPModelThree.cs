using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class SPModelThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PHSporSta",
                table: "SPModelSportdb",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PHUserStatus",
                table: "SPClientUserdb",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHSporSta",
                table: "SPModelSportdb");

            migrationBuilder.DropColumn(
                name: "PHUserStatus",
                table: "SPClientUserdb");
        }
    }
}
