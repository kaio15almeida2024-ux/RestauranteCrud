using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RestauranteCrud.Models
{
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }

        [Required]
        public string NomeFuncionario { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string Cargo { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        [Precision (10, 2)]
        public decimal Salario { get; set; }
    }
}