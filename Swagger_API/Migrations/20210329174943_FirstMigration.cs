using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Swagger_API.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BatchAclReadGroupsTables",
                columns: table => new
                {
                    SrNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AciID = table.Column<int>(type: "int", nullable: false),
                    Groupdetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchAclReadGroupsTables", x => x.SrNo);
                });

            migrationBuilder.CreateTable(
                name: "BatchAclReadUsersTables",
                columns: table => new
                {
                    SrNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AciID = table.Column<int>(type: "int", nullable: false),
                    Usersdetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchAclReadUsersTables", x => x.SrNo);
                });

            migrationBuilder.CreateTable(
                name: "BatchAclTables",
                columns: table => new
                {
                    SrNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchAclTables", x => x.SrNo);
                });

            migrationBuilder.CreateTable(
                name: "BatchAttributeTables",
                columns: table => new
                {
                    SrNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keydetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valuedetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchAttributeTables", x => x.SrNo);
                });

            migrationBuilder.CreateTable(
                name: "BatchTables",
                columns: table => new
                {
                    SrNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Publishdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchTables", x => x.SrNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatchAclReadGroupsTables");

            migrationBuilder.DropTable(
                name: "BatchAclReadUsersTables");

            migrationBuilder.DropTable(
                name: "BatchAclTables");

            migrationBuilder.DropTable(
                name: "BatchAttributeTables");

            migrationBuilder.DropTable(
                name: "BatchTables");
        }
    }
}
