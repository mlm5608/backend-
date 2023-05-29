using Microsoft.EntityFrameworkCore;
using Projeto_Gamer.Models;

namespace Projeto_Gamer.Infra
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Souce = NOTE10-S14; initial catalog = gamer; Integrated Security = true; TrustServerCertificate = true");
            }
        }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
    }
}