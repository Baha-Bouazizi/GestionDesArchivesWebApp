using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDesArchivesWebApp.Models
{
    public class LogInfo
    {
        public string CdeUtl { get; set; }
        public string? NomUser { get; set; }
        public string? MotPasse { get; set; }
        public bool? Admin { get; set; }
        public DateTime? DerUser { get; set; }
        public string? CdePer { get; set; }

        [ForeignKey(nameof(CdePer))]
        public virtual Personnel? Personnel { get; set; } // Propriété de navigation
    }
}
