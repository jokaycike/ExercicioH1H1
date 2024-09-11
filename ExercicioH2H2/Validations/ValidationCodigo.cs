using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExercicioH2H2.Validations
{
    public class ValidationCodigo : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var codigoProduto = value as string;


            if (string.IsNullOrEmpty(codigoProduto))
                return false;

            return Regex.IsMatch(codigoProduto, @"^[A-Z]{3}-\d{4}$");
        }
    }
}
