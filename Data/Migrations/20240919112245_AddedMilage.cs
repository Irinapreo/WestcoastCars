using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WestCoast_Cars.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedMilage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Milage",
                table: "Vehicles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Milage",
                table: "Vehicles");
        }
    }
}
