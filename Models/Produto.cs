using System.ComponentModel.DataAnnotations;

namespace Estoque.Models;

public class Produto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O nome deve ser informado")]
    public string? Nome { get; set; }
    public double Preco { get; set; }
}
