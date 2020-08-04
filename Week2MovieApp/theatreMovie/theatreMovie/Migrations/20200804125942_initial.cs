using Microsoft.EntityFrameworkCore.Migrations;

namespace theatreMovie.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Catagory",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Catagory_MovieId",
                table: "Catagory",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catagory_Movie_MovieId",
                table: "Catagory",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catagory_Movie_MovieId",
                table: "Catagory");

            migrationBuilder.DropIndex(
                name: "IX_Catagory_MovieId",
                table: "Catagory");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Catagory");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Movie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Movie",
                nullable: true);
        }
    }
}
