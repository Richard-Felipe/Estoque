using Microsoft.EntityFrameworkCore;

namespace Estoque.Database;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DINKZ;Database=Estoque;User Id=sa;Password=Dev$123;Encrypt=False;");
    }

}
