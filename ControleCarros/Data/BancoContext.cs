using ControleCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleCarros.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<CarroModel> Carros { get; set; }
    }
}
