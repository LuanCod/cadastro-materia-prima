using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cadastro_materia_prima.Models
{
    [Table("Materia")]
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public string? Tipo { get; set;}

        [Required(ErrorMessage = "Obrigatório informar o valor energético!")]
        public double ValorEnergetico { get; set; }

        [Required(ErrorMessage = "Obrigatório informar os carboidratos!")]
        public double Carboidratos { get; set; }

        [Required(ErrorMessage = "Obrigatório informar os açucares totais!")]
        public double AcucaresTotais { get; set; }

        [Required(ErrorMessage = "Obrigatório informar os açucares adicionados!")]
        public double AcucaresAdicionados { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as proteínas!")]
        public double Proteinas { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as gorduras totais!")]
        public double GordurasTotais { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as gorduras saturadas!")]
        public double GordurasSaturadas { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as gorduras trans!")]
        public double GordurasTrans { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a fibra alimentar!")]
        public double FibraAlimentar { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o sódio!")]
        public double Sodio { get; set; }
    }
}
