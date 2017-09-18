using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LatinDictionaryNoAuth.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    StageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StageName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.StageId);
                });

            migrationBuilder.CreateTable(
                name: "WordType",
                columns: table => new
                {
                    WordTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordType", x => x.WordTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EnglishWord",
                columns: table => new
                {
                    EnglishWordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "strftime('%Y-%m-%d %H:%M:%S')"),
                    StageId = table.Column<int>(type: "INTEGER", nullable: false),
                    Word = table.Column<string>(type: "TEXT", nullable: false),
                    WordTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishWord", x => x.EnglishWordId);
                    table.ForeignKey(
                        name: "FK_EnglishWord_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "StageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnglishWord_WordType_WordTypeId",
                        column: x => x.WordTypeId,
                        principalTable: "WordType",
                        principalColumn: "WordTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LatinWord",
                columns: table => new
                {
                    LatinWordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "strftime('%Y-%m-%d %H:%M:%S')"),
                    StageId = table.Column<int>(type: "INTEGER", nullable: false),
                    Word = table.Column<string>(type: "TEXT", nullable: false),
                    WordTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatinWord", x => x.LatinWordId);
                    table.ForeignKey(
                        name: "FK_LatinWord_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "StageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LatinWord_WordType_WordTypeId",
                        column: x => x.WordTypeId,
                        principalTable: "WordType",
                        principalColumn: "WordTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnglishWord_StageId",
                table: "EnglishWord",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_EnglishWord_WordTypeId",
                table: "EnglishWord",
                column: "WordTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LatinWord_StageId",
                table: "LatinWord",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_LatinWord_WordTypeId",
                table: "LatinWord",
                column: "WordTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnglishWord");

            migrationBuilder.DropTable(
                name: "LatinWord");

            migrationBuilder.DropTable(
                name: "Stage");

            migrationBuilder.DropTable(
                name: "WordType");
        }
    }
}
