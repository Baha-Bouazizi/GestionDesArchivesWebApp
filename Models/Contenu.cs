using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDesArchivesWebApp.Models
{
    public class Contenu
    {
        public string CdePiece { get; set; }
        public string? NPiece { get; set; }
        public string? DesPiece { get; set; }
        public DateTime? DtePiece { get; set; }
        public string? MotCle { get; set; }
        public string? CdeCon { get; set; }
        public string? CdeTypDoc { get; set; }

        // Relations avec les autres entités
        [ForeignKey(nameof(CdeCon))]
        public virtual Conteneur Conteneur { get; set; }

        [ForeignKey(nameof(CdeTypDoc))]
        public virtual TypDoc TypDoc { get; set; }
    }
}
