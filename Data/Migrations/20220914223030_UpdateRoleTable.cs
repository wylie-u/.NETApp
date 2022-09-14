using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewWebApp.Data.Migrations
{
    public partial class UpdateRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
            name: "Id",
            table: "AspNetRoles",
            oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoles");
        }
    }
}
