using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDesArchivesWebApp.Models
{
    public class LogArch
    {
        public string? CdeLogA { get; set; }
        public DateTime? DteLogA { get; set; }
        public string? RqueLogA { get; set; }
        public string? CdePer { get; set; }
        public DateTime? DteDeb { get; set; }
        public string? CdeCon { get; set; }

        [ForeignKey(nameof(CdePer))]
        public virtual Personnel? Personnel { get; set; } // Propriété de navigation

        [ForeignKey(nameof(CdeCon))]
        public virtual Conteneur? Conteneur { get; set; } // Propriété de navigation
    }
}
