using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CUIT = table.Column<string>(type: "TEXT", nullable: true),
                    Concept1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Concept2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Concept3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Concept4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Concept5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Concept6 = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentBalance = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    LastSale = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Business");
        }
    }
}
