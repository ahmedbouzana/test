using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TeleStock.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    produitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    codeProduit = table.Column<string>(nullable: true),
                    desProduit = table.Column<string>(nullable: true),
                    prixAchatHtProduit = table.Column<string>(nullable: true),
                    prixVenteHtProduit = table.Column<string>(nullable: true),
                    qteEnStockProduit = table.Column<decimal>(nullable: true),
                    qteRuptureProduit = table.Column<decimal>(nullable: true),
                    qteSurStockProduit = table.Column<decimal>(nullable: true),
                    refProduit = table.Column<string>(nullable: true),
                    remarqueProduit = table.Column<string>(nullable: true),
                    tvaProduit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.produitID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");
        }
    }
}
