using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDTesteMeta.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Truks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckId = table.Column<int>(type: "int", nullable: false),
                    TrukModel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TrukModelYear = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 100, nullable: false),
                    TrukManufacturingYear = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 100, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Truks");
        }
    }
}
