using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class SPModelFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PHEquipBorroww",
                table: "SPModelEquipdb",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHEquipBorroww",
                table: "SPModelEquipdb");
        }
    }
}
