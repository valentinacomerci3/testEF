using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week6EFTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    CF = table.Column<int>(type: "int", maxLength: 16, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.CF);
                });

            migrationBuilder.CreateTable(
                name: "Policy",
                columns: table => new
                {
                    NUM = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    MonthlyFee = table.Column<double>(type: "float", nullable: false),
                    ClientCode = table.Column<int>(type: "int", nullable: true),
                    prodotto_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Displacement = table.Column<int>(type: "int", nullable: true),
                    Coverage = table.Column<int>(type: "int", nullable: true),
                    Years = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policy", x => x.NUM);
                    table.ForeignKey(
                        name: "FK_Policy_Client_ClientCode",
                        column: x => x.ClientCode,
                        principalTable: "Client",
                        principalColumn: "CF",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Policy_ClientCode",
                table: "Policy",
                column: "ClientCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policy");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
