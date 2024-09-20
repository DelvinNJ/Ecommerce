using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class FixKeyIssues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActorName",
                table: "Actors");

            migrationBuilder.AddColumn<int>(
                name: "MovieCategoryId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieCategoryId",
                table: "Movies",
                column: "MovieCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieCategories_MovieCategoryId",
                table: "Movies",
                column: "MovieCategoryId",
                principalTable: "MovieCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieCategories_MovieCategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieCategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCategoryId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "ActorName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
