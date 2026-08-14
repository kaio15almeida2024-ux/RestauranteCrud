using System.ComponentModel.DataAnnotations;

namespace RestauranteCrud.Models
{
    public class Fornecedor
    {
        [Key]
        public int IdFornecedor { get; set; }

        [Required]
        public string NomeFornecedor { get; set; }

        [Required]
        public string CNPJ { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

        // Um fornecedor possui vários pratos
        public ICollection<Pratos> Pratos { get; set; }
            = new List<Pratos>();
    }
}