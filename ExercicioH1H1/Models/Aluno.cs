using ExercicioH1H1.Validations;
using System.ComponentModel.DataAnnotations;

namespace ExercicioH1H1.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Insira Nome")]
        public string Nome {  get; set; }

        [Required(ErrorMessage = "O RA é obrigatorio")]
        [ValidationRa(ErrorMessage = "Deve começar com RA e depois 6 numeros")]
        public string RA {  get; set; }

        [Required(ErrorMessage = "Insira email")]
        [EmailAddress(ErrorMessage = "O email deve ser válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira CPF")]
        public string CPF { get; set; }

        public bool Ativo {  get; set; }
    }
}
