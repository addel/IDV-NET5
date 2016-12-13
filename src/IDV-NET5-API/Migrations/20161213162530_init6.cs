using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IDVNET5API.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfPost = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
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

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Comment_CommentId",
                table: "Movie",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Description",
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

            migrationBuilder.DropTable(
                name: "Comment");
        }
    }
}
