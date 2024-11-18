﻿// <auto-generated />
using System;
using GestionDesArchivesWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionDesArchivesWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240902101423_suiteDsuiteF")]
    partial class suiteDsuiteF
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Conteneur", b =>
                {
                    b.Property<string>("CdeCon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Archiver")
                        .HasColumnType("bit");

                    b.Property<string>("CdeEmpl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdePer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeSoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeStd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeSup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeTypClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesCon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DispoAdx")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DurVieCon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SutDeb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SutFin")
                        .HasColumnType("datetime2");

                    b.Property<string>("suiteD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("suiteF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeCon");

                    b.ToTable("Conteneurs");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Contenu", b =>
                {
                    b.Property<string>("CdePiece")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CdeCon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CdeTypDoc")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesPiece")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DtePiece")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotCle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NPiece")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdePiece");

                    b.HasIndex("CdeCon");

                    b.HasIndex("CdeTypDoc");

                    b.ToTable("Contenus");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Emplacement", b =>
                {
                    b.Property<string>("CdeEmpl")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AbrEmpl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Capacite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeLieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesEmpl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EqueEmpl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeEmpl");

                    b.HasIndex("CdeLieu");

                    b.ToTable("Emplacements");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.EnteteInventaire", b =>
                {
                    b.Property<string>("IdEntete")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Commentaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateEntete")
                        .HasColumnType("datetime2");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEntete");

                    b.ToTable("EnteteInventaires");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Inventaire", b =>
                {
                    b.Property<string>("IdInventaire")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdEntete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdProduit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("IdInventaire");

                    b.ToTable("Inventaires");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.InventaireRealisee", b =>
                {
                    b.Property<string>("IdInventaireRealisee")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateRealisation")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdEntete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdInventaireRealisee");

                    b.ToTable("InventaireRealisees");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Lieux", b =>
                {
                    b.Property<string>("CdeLieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AbrLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeEmpl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RqueLieu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeLieu");

                    b.ToTable("Lieux");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.LogArch", b =>
                {
                    b.Property<string>("CdeLogA")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CdeCon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CdePer")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DteDeb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DteLogA")
                        .HasColumnType("datetime2");

                    b.Property<string>("RqueLogA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeLogA");

                    b.HasIndex("CdeCon");

                    b.HasIndex("CdePer");

                    b.ToTable("LogArchs");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.LogExploitation", b =>
                {
                    b.Property<string>("CdeLogEx")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CdeCon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CdePer")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConLivrer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConRet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesLogEx")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DteDeb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DteDem")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DteLogEx")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DteLogExRetour")
                        .HasColumnType("datetime2");

                    b.Property<string>("RqueLogEx")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeLogEx");

                    b.HasIndex("CdeCon");

                    b.HasIndex("CdePer");

                    b.ToTable("LogExploitations");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.LogInfo", b =>
                {
                    b.Property<string>("CdeUtl")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("CdePer")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DerUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotPasse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeUtl");

                    b.HasIndex("CdePer");

                    b.ToTable("LogInfos");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Personnel", b =>
                {
                    b.Property<string>("CdePer")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CdeChefHer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeSer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CdeSoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomPrePer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdePer");

                    b.ToTable("Personnels");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Service", b =>
                {
                    b.Property<string>("CdeSer")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesSer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RqueServ")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeSer");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Societe", b =>
                {
                    b.Property<string>("CdeSoc")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesSoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeSoc");

                    b.ToTable("Societes");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.StadeClassement", b =>
                {
                    b.Property<string>("CdeStd")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesStd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RqueStd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeStd");

                    b.ToTable("StadeClassements");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.StatutDoc", b =>
                {
                    b.Property<string>("CdeStat")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesStat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RqueStat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeStat");

                    b.ToTable("StatutDocs");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Support", b =>
                {
                    b.Property<string>("CdeSup")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesSupp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RqueSupp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeSup");

                    b.ToTable("Supports");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.TypDoc", b =>
                {
                    b.Property<string>("CdeTypDoc")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesTypDoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeTypDoc");

                    b.ToTable("TypDocs");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.TypeClassement", b =>
                {
                    b.Property<string>("CdeTypClass")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesTypClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RqueTypClass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeTypClass");

                    b.ToTable("TypeClassements");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.TypeCon", b =>
                {
                    b.Property<string>("CdeTypCon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DesTypCon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RqueTypCon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CdeTypCon");

                    b.ToTable("TypeCons");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Contenu", b =>
                {
                    b.HasOne("GestionDesArchivesWebApp.Models.Conteneur", "Conteneur")
                        .WithMany()
                        .HasForeignKey("CdeCon");

                    b.HasOne("GestionDesArchivesWebApp.Models.TypDoc", "TypDoc")
                        .WithMany()
                        .HasForeignKey("CdeTypDoc");

                    b.Navigation("Conteneur");

                    b.Navigation("TypDoc");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.Emplacement", b =>
                {
                    b.HasOne("GestionDesArchivesWebApp.Models.Lieux", "Lieux")
                        .WithMany()
                        .HasForeignKey("CdeLieu");

                    b.Navigation("Lieux");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.LogArch", b =>
                {
                    b.HasOne("GestionDesArchivesWebApp.Models.Conteneur", "Conteneur")
                        .WithMany()
                        .HasForeignKey("CdeCon");

                    b.HasOne("GestionDesArchivesWebApp.Models.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("CdePer");

                    b.Navigation("Conteneur");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.LogExploitation", b =>
                {
                    b.HasOne("GestionDesArchivesWebApp.Models.Conteneur", "Conteneur")
                        .WithMany()
                        .HasForeignKey("CdeCon");

                    b.HasOne("GestionDesArchivesWebApp.Models.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("CdePer");

                    b.Navigation("Conteneur");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("GestionDesArchivesWebApp.Models.LogInfo", b =>
                {
                    b.HasOne("GestionDesArchivesWebApp.Models.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("CdePer");

                    b.Navigation("Personnel");
                });
#pragma warning restore 612, 618
        }
    }
}
