using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IDVNET5API.Migrations
{
    public partial class fuckit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Comment_CommentId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CommentId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Quality",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "sizeFile",
                table: "Movie");

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Download_link = table.Column<string>(nullable: true),
                    Edition = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Quality = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asso_movie_version",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MoviesId = table.Column<int>(nullable: false),
                    VersionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asso_movie_version", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asso_movie_version_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asso_movie_version_Version_VersionId",
                        column: x => x.VersionId,
                        principalTable: "Version",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<string>(
                name: "Actor_principal",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Movie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Realisator",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VersionId",
                table: "Comment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_VersionId",
                table: "Comment",
                column: "VersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Asso_movie_version_MoviesId",
                table: "Asso_movie_version",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_Asso_movie_version_VersionId",
                table: "Asso_movie_version",
                column: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Version_VersionId",
                table: "Comment",
                column: "VersionId",
                principalTable: "Version",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Version_VersionId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_VersionId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "Actor_principal",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Realisator",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "Comment");

            migrationBuilder.DropTable(
                name: "Asso_movie_version");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Quality",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "sizeFile",
                table: "Movie",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CommentId",
                table: "Movie",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Comment_CommentId",
                table: "Movie",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
