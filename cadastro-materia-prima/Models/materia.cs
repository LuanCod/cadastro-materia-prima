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
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public string Tipo { get; set;}

        [Required(ErrorMessage = "Obrigatório informar o valor energético!")]
        [Display(Name = "Valor\nEnergético")]

        public double ValorEnergetico { get; set; }

        [Required(ErrorMessage = "Obrigatório informar os carboidratos!")]
        public double Carboidratos { get; set; }

        [Required(ErrorMessage = "Obrigatório informar os açucares totais!")]
        [Display(Name = "Açucares\nTotais")]
        public double AcucaresTotais { get; set; }

        [Required(ErrorMessage = "Obrigatório informar os açucares adicionados!")]
        [Display(Name = "Açucares\nAdicionados")]
        public double AcucaresAdicionados { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as proteínas!")]
        [Display(Name = "Proteínas")]
        public double Proteinas { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as gorduras totais!")]
        [Display(Name = "Gorduras\nTotais")]
        public double GordurasTotais { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as gorduras saturadas!")]
        [Display(Name = "Gorduras\nSaturadas")]
        public double GordurasSaturadas { get; set; }

        [Required(ErrorMessage = "Obrigatório informar as gorduras trans!")]
        [Display(Name = "Gorduras\nTrans")]
        public double GordurasTrans { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a fibra alimentar!")]
        [Display(Name = "Fibra\nAlimentar")]
        public double FibraAlimentar { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o sódio!")]
        [Display(Name = "Sódio")]
        public double Sodio { get; set; }
    }
}
