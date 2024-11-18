
using System.ComponentModel.DataAnnotations;

namespace GestionDesArchivesWebApp.ViewModels
{
    public class BooleanStringAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var stringValue = value as string;
            return stringValue == "true" || stringValue == "false";
        }
    }

}