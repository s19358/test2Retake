using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace test2retake.Migrations
{
    public partial class TablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    IdAction = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    NeedSpecialEquipment = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.IdAction);
                });

            migrationBuilder.CreateTable(
                name: "FireFighter",
                columns: table => new
                {
                    IdFireFighter = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireFighter", x => x.IdFireFighter);
                });

            migrationBuilder.CreateTable(
                name: "FireTruck",
                columns: table => new
                {
                    IdFireTruck = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationalNumber = table.Column<string>(maxLength: 10, nullable: false),
                    SpecialEquipment = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireTruck", x => x.IdFireTruck);
                });

            migrationBuilder.CreateTable(
                name: "FireFighter_Action",
                columns: table => new
                {
                    IdFireFighter = table.Column<int>(nullable: false),
                    IdAction = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireFighter_Action", x => new { x.IdFireFighter, x.IdAction });
                    table.ForeignKey(
                        name: "FK_FireFighter_Action_Action_IdAction",
                        column: x => x.IdAction,
                        principalTable: "Action",
                        principalColumn: "IdAction",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FireFighter_Action_FireFighter_IdFireFighter",
                        column: x => x.IdFireFighter,
                        principalTable: "FireFighter",
                        principalColumn: "IdFireFighter",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FireTruck_Action",
                columns: table => new
                {
                    IdFireTruckAction = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFireTruck = table.Column<int>(nullable: false),
                    IdAction = table.Column<int>(nullable: false),
                    AssignmentDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireTruck_Action", x => x.IdFireTruckAction);
                    table.ForeignKey(
                        name: "FK_FireTruck_Action_Action_IdAction",
                        column: x => x.IdAction,
                        principalTable: "Action",
                        principalColumn: "IdAction",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FireTruck_Action_FireTruck_IdFireTruck",
                        column: x => x.IdFireTruck,
                        principalTable: "FireTruck",
                        principalColumn: "IdFireTruck",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FireFighter_Action_IdAction",
                table: "FireFighter_Action",
                column: "IdAction");

            migrationBuilder.CreateIndex(
                name: "IX_FireTruck_Action_IdAction",
                table: "FireTruck_Action",
                column: "IdAction");

            migrationBuilder.CreateIndex(
                name: "IX_FireTruck_Action_IdFireTruck",
                table: "FireTruck_Action",
                column: "IdFireTruck");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FireFighter_Action");

            migrationBuilder.DropTable(
                name: "FireTruck_Action");

            migrationBuilder.DropTable(
                name: "FireFighter");

            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "FireTruck");
        }
    }
}
