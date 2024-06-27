using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram.Migrations
{
    public partial class AggiuntaChiaveEsternaUtente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utente_Posts_PostId",
                table: "Utente");

            migrationBuilder.DropIndex(
                name: "IX_Utente_PostId",
                table: "Utente");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Utente");

            migrationBuilder.AddColumn<int>(
                name: "UtendteId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UtenteId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UtenteId",
                table: "Posts",
                column: "UtenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Utente_UtenteId",
                table: "Posts",
                column: "UtenteId",
                principalTable: "Utente",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Utente_UtenteId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UtenteId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UtendteId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UtenteId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Utente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utente_PostId",
                table: "Utente",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Utente_Posts_PostId",
                table: "Utente",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }
    }
}
