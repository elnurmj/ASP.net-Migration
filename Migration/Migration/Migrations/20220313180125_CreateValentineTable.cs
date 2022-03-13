﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace LessonMigration.Migrations
{
    public partial class CreateValentineTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValentineContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Header = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Footer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValentineContents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValentineContents");
        }
    }
}
