using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Model;

namespace ProjetoAPI.Infraestrutura
{
    public class Conexao : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;Database=API;" +
                "User Id=postgres;" +
                "Password=root;");
    }
}
