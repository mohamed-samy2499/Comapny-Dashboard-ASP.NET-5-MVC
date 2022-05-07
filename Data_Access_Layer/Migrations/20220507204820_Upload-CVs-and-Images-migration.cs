using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access_Layer.Migrations
{
    public partial class UploadCVsandImagesmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CVName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "Employees");
        }
    }
}
