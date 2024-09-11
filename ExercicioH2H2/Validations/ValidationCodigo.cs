using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExercicioH2H2.Validations
{
    public class ValidationCodigo : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var codigoProduto = value as string;

            if(codigoProduto != null) return false;

            if(Regex.IsMatch(codigoProduto, @"^["))
        }
    }
}
