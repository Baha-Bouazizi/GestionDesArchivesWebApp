using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDesArchivesWebApp.Migrations
{
    /// <inheritdoc />
    public partial class guizeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conteneurs",
                columns: table => new
                {
                    CdeCon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesCon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SutDeb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SutFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurVieCon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CdePer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CdeEmpl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CdeTypClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CdeSup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CdeStd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CdeSoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Archiver = table.Column<bool>(type: "bit", nullable: false),
                    DispoAdx = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteneurs", x => x.CdeCon);
                });

            migrationBuilder.CreateTable(
                name: "EnteteInventaires",
                columns: table => new
                {
                    IdEntete = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateEntete = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commentaire = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnteteInventaires", x => x.IdEntete);
                });

            migrationBuilder.CreateTable(
                name: "InventaireRealisees",
                columns: table => new
                {
                    IdInventaireRealisee = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateRealisation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEntete = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventaireRealisees", x => x.IdInventaireRealisee);
                });

            migrationBuilder.CreateTable(
                name: "Inventaires",
                columns: table => new
                {
                    IdInventaire = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: true),
                    IdProduit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEntete = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventaires", x => x.IdInventaire);
                });

            migrationBuilder.CreateTable(
                name: "Lieux",
                columns: table => new
                {
                    CdeLieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbrLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RqueLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdeEmpl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieux", x => x.CdeLieu);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    CdePer = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NomPrePer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdeSer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdeChefHer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdeSoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdeLieu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.CdePer);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    CdeSer = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesSer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RqueServ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.CdeSer);
                });

            migrationBuilder.CreateTable(
                name: "Societes",
                columns: table => new
                {
                    CdeSoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesSoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societes", x => x.CdeSoc);
                });

            migrationBuilder.CreateTable(
                name: "StadeClassements",
                columns: table => new
                {
                    CdeStd = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesStd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RqueStd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StadeClassements", x => x.CdeStd);
                });

            migrationBuilder.CreateTable(
                name: "StatutDocs",
                columns: table => new
                {
                    CdeStat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesStat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RqueStat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatutDocs", x => x.CdeStat);
                });

            migrationBuilder.CreateTable(
                name: "Supports",
                columns: table => new
                {
                    CdeSup = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesSupp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RqueSupp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supports", x => x.CdeSup);
                });

            migrationBuilder.CreateTable(
                name: "TypDocs",
                columns: table => new
                {
                    CdeTypDoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesTypDoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypDocs", x => x.CdeTypDoc);
                });

            migrationBuilder.CreateTable(
                name: "TypeClassements",
                columns: table => new
                {
                    CdeTypClass = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesTypClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RqueTypClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeClassements", x => x.CdeTypClass);
                });

            migrationBuilder.CreateTable(
                name: "TypeCons",
                columns: table => new
                {
                    CdeTypCon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesTypCon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RqueTypCon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCons", x => x.CdeTypCon);
                });

            migrationBuilder.CreateTable(
                name: "Emplacements",
                columns: table => new
                {
                    CdeEmpl = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesEmpl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbrEmpl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EqueEmpl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdeLieu = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emplacements", x => x.CdeEmpl);
                    table.ForeignKey(
                        name: "FK_Emplacements_Lieux_CdeLieu",
                        column: x => x.CdeLieu,
                        principalTable: "Lieux",
                        principalColumn: "CdeLieu");
                });

            migrationBuilder.CreateTable(
                name: "LogArchs",
                columns: table => new
                {
                    CdeLogA = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DteLogA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RqueLogA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdePer = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DteDeb = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CdeCon = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogArchs", x => x.CdeLogA);
                    table.ForeignKey(
                        name: "FK_LogArchs_Conteneurs_CdeCon",
                        column: x => x.CdeCon,
                        principalTable: "Conteneurs",
                        principalColumn: "CdeCon");
                    table.ForeignKey(
                        name: "FK_LogArchs_Personnels_CdePer",
                        column: x => x.CdePer,
                        principalTable: "Personnels",
                        principalColumn: "CdePer");
                });

            migrationBuilder.CreateTable(
                name: "LogExploitations",
                columns: table => new
                {
                    CdeLogEx = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DesLogEx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DteDem = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DteLogEx = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConLivrer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DteLogExRetour = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConRet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RqueLogEx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdePer = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DteDeb = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CdeCon = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogExploitations", x => x.CdeLogEx);
                    table.ForeignKey(
                        name: "FK_LogExploitations_Conteneurs_CdeCon",
                        column: x => x.CdeCon,
                        principalTable: "Conteneurs",
                        principalColumn: "CdeCon");
                    table.ForeignKey(
                        name: "FK_LogExploitations_Personnels_CdePer",
                        column: x => x.CdePer,
                        principalTable: "Personnels",
                        principalColumn: "CdePer");
                });

            migrationBuilder.CreateTable(
                name: "LogInfos",
                columns: table => new
                {
                    CdeUtl = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NomUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotPasse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admin = table.Column<bool>(type: "bit", nullable: true),
                    DerUser = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CdePer = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogInfos", x => x.CdeUtl);
                    table.ForeignKey(
                        name: "FK_LogInfos_Personnels_CdePer",
                        column: x => x.CdePer,
                        principalTable: "Personnels",
                        principalColumn: "CdePer");
                });

            migrationBuilder.CreateTable(
                name: "Contenus",
                columns: table => new
                {
                    CdePiece = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NPiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesPiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtePiece = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MotCle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdeCon = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CdeTypDoc = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenus", x => x.CdePiece);
                    table.ForeignKey(
                        name: "FK_Contenus_Conteneurs_CdeCon",
                        column: x => x.CdeCon,
                        principalTable: "Conteneurs",
                        principalColumn: "CdeCon");
                    table.ForeignKey(
                        name: "FK_Contenus_TypDocs_CdeTypDoc",
                        column: x => x.CdeTypDoc,
                        principalTable: "TypDocs",
                        principalColumn: "CdeTypDoc");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contenus_CdeCon",
                table: "Contenus",
                column: "CdeCon");

            migrationBuilder.CreateIndex(
                name: "IX_Contenus_CdeTypDoc",
                table: "Contenus",
                column: "CdeTypDoc");

            migrationBuilder.CreateIndex(
                name: "IX_Emplacements_CdeLieu",
                table: "Emplacements",
                column: "CdeLieu");

            migrationBuilder.CreateIndex(
                name: "IX_LogArchs_CdeCon",
                table: "LogArchs",
                column: "CdeCon");

            migrationBuilder.CreateIndex(
                name: "IX_LogArchs_CdePer",
                table: "LogArchs",
                column: "CdePer");

            migrationBuilder.CreateIndex(
                name: "IX_LogExploitations_CdeCon",
                table: "LogExploitations",
                column: "CdeCon");

            migrationBuilder.CreateIndex(
                name: "IX_LogExploitations_CdePer",
                table: "LogExploitations",
                column: "CdePer");

            migrationBuilder.CreateIndex(
                name: "IX_LogInfos_CdePer",
                table: "LogInfos",
                column: "CdePer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contenus");

            migrationBuilder.DropTable(
                name: "Emplacements");

            migrationBuilder.DropTable(
                name: "EnteteInventaires");

            migrationBuilder.DropTable(
                name: "InventaireRealisees");

            migrationBuilder.DropTable(
                name: "Inventaires");

            migrationBuilder.DropTable(
                name: "LogArchs");

            migrationBuilder.DropTable(
                name: "LogExploitations");

            migrationBuilder.DropTable(
                name: "LogInfos");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Societes");

            migrationBuilder.DropTable(
                name: "StadeClassements");

            migrationBuilder.DropTable(
                name: "StatutDocs");

            migrationBuilder.DropTable(
                name: "Supports");

            migrationBuilder.DropTable(
                name: "TypeClassements");

            migrationBuilder.DropTable(
                name: "TypeCons");

            migrationBuilder.DropTable(
                name: "TypDocs");

            migrationBuilder.DropTable(
                name: "Lieux");

            migrationBuilder.DropTable(
                name: "Conteneurs");

            migrationBuilder.DropTable(
                name: "Personnels");
        }
    }
}
