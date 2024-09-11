using ExercicioH2H2.Validations;
using System.ComponentModel.DataAnnotations;

namespace ExercicioH2H2.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Insira Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Insira Preço")]
        public string Preco { get; set; }

        [Required(ErrorMessage = "Insira Estoque")]
        public string Estoque { get; set; }

        [Required(ErrorMessage = "Insira Codigo Produto")]
        [ValidationCodigo(ErrorMessage = "Deve começar com 3 letras maiusculas logo seguido de hifen e 4 numeros")]
        public string CodigoProduto { get; set; }

    }
}
