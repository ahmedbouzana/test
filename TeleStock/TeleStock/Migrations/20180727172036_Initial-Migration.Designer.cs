﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TeleStock.Models;

namespace TeleStock.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20180727172036_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeleStock.Models.Produit", b =>
                {
                    b.Property<int>("produitID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("codeProduit");

                    b.Property<string>("desProduit");

                    b.Property<string>("prixAchatHtProduit");

                    b.Property<string>("prixVenteHtProduit");

                    b.Property<decimal?>("qteEnStockProduit");

                    b.Property<decimal?>("qteRuptureProduit");

                    b.Property<decimal?>("qteSurStockProduit");

                    b.Property<string>("refProduit");

                    b.Property<string>("remarqueProduit");

                    b.Property<string>("tvaProduit");

                    b.HasKey("produitID");

                    b.ToTable("Produits");
                });
#pragma warning restore 612, 618
        }
    }
}