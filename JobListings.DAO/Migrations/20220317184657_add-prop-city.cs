using Microsoft.EntityFrameworkCore.Migrations;

namespace JobListings.DAO.Migrations
{
    public partial class addpropcity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "JobListing",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "JobListing");
        }
    }
}
