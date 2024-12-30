using Estoque.Models;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Database;

public class DataContext : DbContext
{
    public DbSet<Armazenamento> Estoque { get; set; }
    public DbSet<Produto> Produto { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DINKZ;Database=Estoque;User Id=sa;Password=Dev$123;Encrypt=False;");
    }

}
