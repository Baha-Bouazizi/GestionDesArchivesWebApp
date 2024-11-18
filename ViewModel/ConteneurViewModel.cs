using Microsoft.AspNetCore.Mvc.Rendering;
namespace GestionDesArchivesWebApp.ViewModel
{
    public class ConteneurViewModel
    {
        public string CdeCon { get; set; }
        public string DesCon { get; set; }
        public DateTime SutDeb { get; set; }
        public DateTime SutFin { get; set; }
        public string DurVieCon { get; set; }
        public string NomPrePer { get; set; }
        // Ajoutez d'autres propriétés si nécessaire
    }

}