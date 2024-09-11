using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExercicioH1H1.Validations
{
    public class ValidationRa : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var ra = value as string;

            if(ra == null) return false;
            
            if (Regex.IsMatch(ra, @"^[Rr][Aa]\d{6}$"))
            {
                Console.WriteLine("Deu certo");
                return true;
            }
            return false;
        }
    }
}
