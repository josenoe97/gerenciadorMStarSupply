using System.ComponentModel.DataAnnotations;

namespace GerenciadorMStarSupply.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Digite o nome do Produto!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite a quantidade de Produto!")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Digite o valor do Preço!")]
        public double Price { get; set; }
    }
}
