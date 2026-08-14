using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RestauranteCrud.Models
{
    public class Pratos
    {
        [Key]
        public int IdPrato { get; set; }

        [Required]
        public string NomePrato { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [Precision(10, 2)]
        public decimal Preco { get; set; }

        public string Categoria { get; set; }

        // Chave estrangeira
        public int IdFornecedor { get; set; }

        // Fornecedor relacionado
        public Fornecedor Fornecedor { get; set; }

        // Data automática
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}