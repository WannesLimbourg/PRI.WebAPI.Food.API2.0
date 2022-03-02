using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PRI.WebAPI.Food.API2._0.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "LastEditedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7481), new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7752), "Pizza" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7994), new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7996), "Pasta" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7999), new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(7999), "Groenten" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(8002), new DateTime(2022, 3, 2, 15, 0, 10, 799, DateTimeKind.Utc).AddTicks(8003), "Fruit" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "LastEditedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7378), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7383), "Peperoni" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7391), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7392), "Hawai" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7395), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7396), "Macaroni" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7400), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7400), "Spaghetti" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7403), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7404), "Komkommer" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7406), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7407), "Tomaat" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7410), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7411), "Appel" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7414), new DateTime(2022, 3, 2, 15, 0, 10, 800, DateTimeKind.Utc).AddTicks(7414), "Peer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
