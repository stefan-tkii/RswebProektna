using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RSWEBProekt_v1.Migrations
{
    public partial class MM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarCarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<string>(nullable: true),
                    carId = table.Column<int>(nullable: false),
                    RequestPrice = table.Column<float>(nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    MeetDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarCarts_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCarts_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCarts_carId",
                table: "CarCarts",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_CarCarts_userId",
                table: "CarCarts",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCarts");
        }
    }
}
