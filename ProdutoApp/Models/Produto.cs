using System.ComponentModel.DataAnnotations;

namespace ProdutoApp.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Range(0.01, 1000000)]
        public decimal Preco { get; set; }

        [Range(0, 10000)]
        public int Quantidade { get; set; }
    }
}


