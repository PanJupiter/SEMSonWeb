using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMSonWeb.Server.Migrations
{
    public partial class SPHisOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHSporSta",
                table: "SPModelSportdb");

            migrationBuilder.AddColumn<bool>(
                name: "PHHisStautus",
                table: "SPHisActiondb",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "PHProfilePhone",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileIDstudent",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileIDcard",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PHProfileClassroom",
                table: "SPClientProfiledb",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PHHisStautus",
                table: "SPHisActiondb");

            migrationBuilder.AddColumn<bool>(
                name: "PHSporSta",
                table: "SPModelSportdb",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "PHProfilePhone",
                table: "SPClientProfiledb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PHProfileIDstudent",
                table: "SPClientProfiledb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PHProfileIDcard",
                table: "SPClientProfiledb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PHProfileClassroom",
                table: "SPClientProfiledb",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
