using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class LivroContext : DbContext 
    {
        public LivroContext(DbContextOptions<LivroContext> options)
            : base(options)
        {
        }
        
        // Adicionar dbsets
        public DbSet<LivroEntity> Livros { get; set; }
        public DbSet<DestaqueEntity> Destaque { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestaqueEntity>(entity =>
            {
                entity.ToTable("DESTAQUE");
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Livro).WithOne().HasForeignKey<DestaqueEntity>(x => x.IdLivro);
                
            });
            base.OnModelCreating(modelBuilder);

        }
    }
}