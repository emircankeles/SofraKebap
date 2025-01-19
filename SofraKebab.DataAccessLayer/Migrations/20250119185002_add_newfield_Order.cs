using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SofraKebab.DataAccessLayer.Migrations
{
    public partial class add_newfield_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activate",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activate",
                table: "Orders");
        }
    }
}
