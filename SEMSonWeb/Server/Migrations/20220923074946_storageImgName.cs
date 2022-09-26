using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class storageImgName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PHProfileImg",
                table: "SPClientProfiledb",
                newName: "PHProfileStorageImg");

            migrationBuilder.AddColumn<string>(
                name: "PHProfileNameImg",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHProfileNameImg",
                table: "SPClientProfiledb");

            migrationBuilder.RenameColumn(
                name: "PHProfileStorageImg",
                table: "SPClientProfiledb",
                newName: "PHProfileImg");
        }
    }
}
