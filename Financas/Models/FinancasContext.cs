
using Financas.Entidades;
using System.Data.Entity;


namespace Financas.Models
{
    public class FinancasContext :DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Movimentacao> Movimentacao { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movimentacao>().HasRequired(m => m.Usuario);
        }
    }
}