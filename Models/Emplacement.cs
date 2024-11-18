using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDesArchivesWebApp.Models
{
    public class Emplacement
    {
        public string CdeEmpl { get; set; }
        public string? DesEmpl { get; set; }
        public string? AbrEmpl { get; set; }
        public string? EqueEmpl { get; set; }
        public string? Capacite { get; set; }
        public string? CdeLieu { get; set; }

        [ForeignKey(nameof(CdeLieu))]
        public virtual Lieux? Lieux { get; set; } // Propriété de navigation
    }
}
