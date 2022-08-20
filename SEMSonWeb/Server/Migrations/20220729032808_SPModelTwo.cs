using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class SPModelTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PHEquipUnit",
                table: "SPModelEquipdb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PHEquipUnit",
                table: "SPModelEquipdb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
