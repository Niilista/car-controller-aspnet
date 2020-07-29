using Microsoft.EntityFrameworkCore;
using TesteValidacaoSoftware.Models;

namespace TesteValidacaoSoftware.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {


            //modelBuilder.Entity<Supervision>().Ignore(x=>x.Supervisor); 
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Documento> Documentos { get; set; }
    }
}