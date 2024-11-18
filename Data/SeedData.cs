using GestionDesArchivesWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GestionDesArchivesWebApp.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            try
            {
                // Ensure that the database is created
                context.Database.EnsureCreated();

                // Seed data only if there is no data in the database
                if (context.Personnels.Any() ||
                    context.Emplacements.Any() ||
                    context.TypeClassements.Any() ||
                    context.Supports.Any() ||
                    context.StadeClassements.Any() ||
                    context.Societes.Any() ||
                    context.Lieux.Any() ||
                    context.Conteneurs.Any() ||
                    context.Contenus.Any())
                {
                    return; // The database is already seeded
                }

                // Seed Societe
                var societes = new List<Societe>
                {
                    new Societe { CdeSoc = "SOC001", DesSoc = "Societe A" },
                    new Societe { CdeSoc = "SOC002", DesSoc = "Societe B" }
                };

                // Seed Service
                var services = new List<Service>
                {
                    new Service { CdeSer = "SER001", DesSer = "Service A", RqueServ = "Remarque A" },
                    new Service { CdeSer = "SER002", DesSer = "Service B", RqueServ = "Remarque B" }
                };

                // Seed Lieux
                var lieux = new List<Lieux>
                {
                    new Lieux { CdeLieu = "LIEU001", DesLieu = "Lieu A", AbrLieu = "LA", RqueLieu = "Remarque A" },
                    new Lieux { CdeLieu = "LIEU002", DesLieu = "Lieu B", AbrLieu = "LB", RqueLieu = "Remarque B" }
                };

                // Seed TypeClassement
                var typeClassements = new List<TypeClassement>
                {
                    new TypeClassement { CdeTypClass = "TYP001", DesTypClass = "Classement A", RqueTypClass = "Remarque A" },
                    new TypeClassement { CdeTypClass = "TYP002", DesTypClass = "Classement B", RqueTypClass = "Remarque B" }
                };

                // Seed StadeClassement
                var stades = new List<StadeClassement>
                {
                    new StadeClassement { CdeStd = "STD001", DesStd = "Stade A", RqueStd = "Remarque A" },
                    new StadeClassement { CdeStd = "STD002", DesStd = "Stade B", RqueStd = "Remarque B" }
                };

                // Seed Support
                var supports = new List<Support>
                {
                    new Support { CdeSup = "SUP001", DesSupp = "Support A", RqueSupp = "Remarque A" },
                    new Support { CdeSup = "SUP002", DesSupp = "Support B", RqueSupp = "Remarque B" }
                };

                // Seed TypDoc
                var typDocs = new List<TypDoc>
                {
                    new TypDoc { CdeTypDoc = "DOC001", DesTypDoc = "Document A" },
                    new TypDoc { CdeTypDoc = "DOC002", DesTypDoc = "Document B" }
                };

                // Add to context
                context.Societes.AddRange(societes);
                context.Services.AddRange(services);
                context.Lieux.AddRange(lieux);
                context.TypeClassements.AddRange(typeClassements);
                context.StadeClassements.AddRange(stades);
                context.Supports.AddRange(supports);
                context.TypDocs.AddRange(typDocs);
                context.SaveChanges();

                // Seed Personnel
                var personnels = new List<Personnel>
                {
                    new Personnel { CdePer = "PER001", NomPrePer = "Nom A", CdeSer = "SER001", CdeChefHer = null, CdeSoc = "SOC001", CdeLieu = "LIEU001" },
                    new Personnel { CdePer = "PER002", NomPrePer = "Nom B", CdeSer = "SER002", CdeChefHer = "PER001", CdeSoc = "SOC002", CdeLieu = "LIEU002" }
                };

                // Seed Emplacement
                var emplacements = new List<Emplacement>
                {
                    new Emplacement { CdeEmpl = "EMPL001", DesEmpl = "Emplacement A", AbrEmpl = "EA", EqueEmpl = "E1", Capacite = "10", CdeLieu = "LIEU001" },
                    new Emplacement { CdeEmpl = "EMPL002", DesEmpl = "Emplacement B", AbrEmpl = "EB", EqueEmpl = "E2", Capacite = "20", CdeLieu = "LIEU002" }
                };

                // Seed Conteneur
                var conteneurs = new List<Conteneur>
                {
                  new Conteneur
{
    CdeCon = "CON001",
    DesCon = "Conteneur one one",
    SutDeb = new DateTime(2002, 6, 15), // Correct date format
    SutFin = new DateTime(2003, 6, 15), // Correct date format
    DurVieCon = "1 year",
    CdePer = "PER001",
    CdeEmpl = "EMPL001",
    CdeTypClass = "TYP001",
    CdeSup = "SUP001",
    CdeStd = "STD001",
    CdeSoc = "SOC001",
    Archiver = false,
    DispoAdx = "Disponible",
    suiteD="1",
    suiteF="20"
},
new Conteneur
{
    CdeCon = "CON002",
    DesCon = "Conteneur two two",
    SutDeb = new DateTime(2002, 6, 15), // Correct date format
    SutFin = new DateTime(2003, 6, 15), // Correct date format
    DurVieCon = "2 years",
    CdePer = "PER002",
    CdeEmpl = "EMPL002",
    CdeTypClass = "TYP002",
    CdeSup = "SUP002",
    CdeStd = "STD002",
    CdeSoc = "SOC002",
    Archiver = true,
    DispoAdx = "Indisponible",
    suiteD="1",
    suiteF="20"
}

                };

             

                // Seed LogArch
               

                // Seed LogExploitation
                
                // Add to context
                context.Personnels.AddRange(personnels);
                context.Emplacements.AddRange(emplacements);
                context.Conteneurs.AddRange(conteneurs);

                // Save all changes to the database
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log the error (e.g., using a logging framework or Console)
                Console.WriteLine($"An error occurred while seeding the database: {ex.Message}");
            }
        }
    }
}

