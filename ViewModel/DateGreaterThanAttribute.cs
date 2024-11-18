
namespace GestionDesArchivesWebApp.ViewModel
{
    internal class DateGreaterThanAttribute : Attribute
    {
        private string v;
        private string errorMessage;

        public DateGreaterThanAttribute(string v, string ErrorMessage)
        {
            this.v = v;
            errorMessage = ErrorMessage;
        }
    }
}