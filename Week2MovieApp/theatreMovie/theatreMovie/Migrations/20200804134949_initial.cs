using Microsoft.EntityFrameworkCore.Migrations;

namespace theatreMovie.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catagory_Movie_MovieId",
                table: "Catagory");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Catagory",
                newName: "CatagoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Catagory_MovieId",
                table: "Catagory",
                newName: "IX_Catagory_CatagoryId");

            migrationBuilder.AddColumn<int>(
                name: "CatagoryId",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Movie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CatagoryId",
                table: "Movie",
                column: "CatagoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catagory_Catagory_CatagoryId",
                table: "Catagory",
                column: "CatagoryId",
                principalTable: "Catagory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Catagory_CatagoryId",
                table: "Movie",
                column: "CatagoryId",
                principalTable: "Catagory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catagory_Catagory_CatagoryId",
                table: "Catagory");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Catagory_CatagoryId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CatagoryId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "CatagoryId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "CatagoryId",
                table: "Catagory",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Catagory_CatagoryId",
                table: "Catagory",
                newName: "IX_Catagory_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catagory_Movie_MovieId",
                table: "Catagory",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
