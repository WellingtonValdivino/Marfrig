﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Marfrig.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Preco = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pecuaristas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pecuaristas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompraGados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataEntrega = table.Column<DateTime>(nullable: false),
                    PecuaristaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraGados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompraGados_Pecuaristas_PecuaristaId",
                        column: x => x.PecuaristaId,
                        principalTable: "Pecuaristas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompraGadoitens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    CompraGadoId = table.Column<int>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompraGadoitens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompraGadoitens_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompraGadoitens_CompraGados_CompraGadoId",
                        column: x => x.CompraGadoId,
                        principalTable: "CompraGados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompraGadoitens_AnimalId",
                table: "CompraGadoitens",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_CompraGadoitens_CompraGadoId",
                table: "CompraGadoitens",
                column: "CompraGadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CompraGados_PecuaristaId",
                table: "CompraGados",
                column: "PecuaristaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompraGadoitens");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "CompraGados");

            migrationBuilder.DropTable(
                name: "Pecuaristas");
        }
    }
}