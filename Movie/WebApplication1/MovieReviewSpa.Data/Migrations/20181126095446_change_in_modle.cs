using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieReviewSpa.Data.Migrations
{
    public partial class change_in_modle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReviewerRating",
                table: "MovieReviews",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewerRating",
                table: "MovieReviews",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
