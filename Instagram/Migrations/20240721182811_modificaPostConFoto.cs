using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram.Migrations
{
    public partial class modificaPostConFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Foto_FotoId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Foto");

            migrationBuilder.DropIndex(
                name: "IX_Posts_FotoId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "FotoId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Titolo",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descrizione",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Imaggine",
                table: "Posts",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imaggine",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Titolo",
                table: "Posts",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descrizione",
                table: "Posts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FotoId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imaggine = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_FotoId",
                table: "Posts",
                column: "FotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Foto_FotoId",
                table: "Posts",
                column: "FotoId",
                principalTable: "Foto",
                principalColumn: "Id");
        }
    }
}
