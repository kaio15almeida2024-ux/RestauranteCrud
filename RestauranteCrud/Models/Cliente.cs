using System.ComponentModel.DataAnnotations;

namespace RestauranteCrud.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public string NomeCliente { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string Telefone { get; set; }

        public string Endereco { get; set; }
        [Required]
        public string Email { get; set; }
    }
}