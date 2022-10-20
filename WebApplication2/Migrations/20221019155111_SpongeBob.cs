using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    public partial class SpongeBob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "home",
                columns: table => new
                {
                    HomeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HomeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNeighbour = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_home", x => x.HomeId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkinCollor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "home",
                        principalColumn: "HomeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_HomeId",
                table: "users",
                column: "HomeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "home");
        }
    }
}
