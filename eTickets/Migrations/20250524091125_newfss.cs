using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class newfss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actor_Movies_Actor_MovieActorId_Actor_MovieMovieId",
                table: "Actor_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actor_Movies_Actor_MovieActorId_Actor_MovieMovieId",
                table: "Actor_Movies");

            migrationBuilder.DropColumn(
                name: "Actor_MovieActorId",
                table: "Actor_Movies");

            migrationBuilder.DropColumn(
                name: "Actor_MovieMovieId",
                table: "Actor_Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Actor_MovieActorId",
                table: "Actor_Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Actor_MovieMovieId",
                table: "Actor_Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actor_Movies_Actor_MovieActorId_Actor_MovieMovieId",
                table: "Actor_Movies",
                columns: new[] { "Actor_MovieActorId", "Actor_MovieMovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actor_Movies_Actor_MovieActorId_Actor_MovieMovieId",
                table: "Actor_Movies",
                columns: new[] { "Actor_MovieActorId", "Actor_MovieMovieId" },
                principalTable: "Actor_Movies",
                principalColumns: new[] { "ActorId", "MovieId" });
        }
    }
}
