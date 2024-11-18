using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDesArchivesWebApp.Models
{
    public class Conteneur
    {
        public string CdeCon { get; set; }
        public string DesCon { get; set; }
        public DateTime SutDeb { get; set; }
        public DateTime SutFin { get; set; }
        public string DurVieCon { get; set; }
        public string CdePer { get; set; }
        public string CdeEmpl { get; set; }
        public string CdeTypClass { get; set; }
        public string CdeSup { get; set; }
        public string CdeStd { get; set; }
        public string CdeSoc { get; set; }
        public bool Archiver { get; set; } // Utilisation du type booléen pour 'Archiver'
        public string DispoAdx { get; set; }
        public string suiteD { get; set; }
        public string suiteF { get; set; }

    }

}
