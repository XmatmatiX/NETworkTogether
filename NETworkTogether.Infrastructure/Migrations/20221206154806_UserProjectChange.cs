using Microsoft.EntityFrameworkCore.Migrations;

namespace NETworkTogether.Infrastructure.Migrations
{
    public partial class UserProjectChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanEdit",
                table: "UserProject",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanEdit",
                table: "UserProject");
        }
    }
}
