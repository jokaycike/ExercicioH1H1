using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExercicioH1H1.Validations
{
    public class ValidationRa : ValidationAttribute
    {
        public override bool IsValid(string? ra)
        {
            if(ra == null) return false;
            
            if (Regex.IsMatch(ra, @"^[Rr][Aa]\d{6}$"))
            {
                string mensagem = $"Verificado correto {ra}"
                return ;
            }

        }
    }
}
