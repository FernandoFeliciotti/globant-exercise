using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PresidentsExcercise.Migrations
{
    public partial class _20180812 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Exercise");

            migrationBuilder.CreateTable(
                name: "Presidents",
                schema: "Exercise",
                columns: table => new
                {
                    PresidentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Birthplace = table.Column<string>(maxLength: 100, nullable: true),
                    Deathday = table.Column<DateTime>(nullable: false),
                    Deathplace = table.Column<string>(maxLength: 100, nullable: true),
                    President = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presidents", x => x.PresidentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presidents",
                schema: "Exercise");
        }
    }
}
