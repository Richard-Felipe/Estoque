using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque.Models;

public class Armazenamento
{
    private List<Produto> _produtos = new();

    public int Id { get; set; }
    public List<Produto> Produtos { get; set; }
    public int QuantidadeEmEstoque { get; set; }
}
