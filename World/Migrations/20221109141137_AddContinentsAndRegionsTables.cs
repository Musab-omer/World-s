﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace World.Migrations
{
    /// <inheritdoc />
    public partial class AddContinentsAndRegionsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Region_Contients_ContientId",
                        column: x => x.ContientId,
                        principalTable: "Contients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contients",
                columns: new[] { "Id", "ArabicName", "EnglishName" },
                values: new object[,]
                {
                    { new Guid("1065e50c-a58e-4754-8913-7bc597688f7b"), null, "Africa" },
                    { new Guid("14662d97-d646-4cbc-84d5-32af5fa4f546"), null, "Australia" },
                    { new Guid("1a6f2ced-1b4f-448f-bea6-f74e4cf8fe82"), null, "South America" },
                    { new Guid("39068c65-00b9-4da6-a907-522a2843974d"), null, "North " },
                    { new Guid("961a9641-ceb5-47c6-8a3f-2abfcfa40c8c"), null, "Asia" },
                    { new Guid("9859abe8-7101-4895-a9ec-9f0f8f6d4182"), null, "Antarctica" },
                    { new Guid("9ce69735-d0fe-4f50-8acd-667f4c63a004"), null, "Europe" },
                   
                    
                
                    
                });

            migrationBuilder.CreateIndex(
                name: "IX_Region_ContientId",
                table: "Region",
                column: "ContientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Contients");
        }
    }
}
