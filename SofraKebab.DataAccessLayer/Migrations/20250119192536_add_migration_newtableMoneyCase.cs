﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SofraKebab.DataAccessLayer.Migrations
{
    public partial class add_migration_newtableMoneyCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoneyCase",
                columns: table => new
                {
                    MoneyCaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyCase", x => x.MoneyCaseID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoneyCase");
        }
    }
}
