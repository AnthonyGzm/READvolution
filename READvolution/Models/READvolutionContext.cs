using Microsoft.EntityFrameworkCore;
using READvolution.Models.Entidades;

namespace READvolution.Models
{
    public class READvolutionContext : DbContext
    {
        public READvolutionContext(DbContextOptions<READvolutionContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categoria>().HasIndex(c => c.Nombre).IsUnique();
        }

    }
}
