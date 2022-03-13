using Microsoft.EntityFrameworkCore.Migrations;

namespace JobListings.DAO.Migrations
{
    public partial class renameprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descroption",
                table: "JobListing");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "JobListing",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "JobListing");

            migrationBuilder.AddColumn<string>(
                name: "Descroption",
                table: "JobListing",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
