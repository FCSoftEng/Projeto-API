using ChapterFST1.Models;
using Microsoft.EntityFrameworkCore;
using Projeto_API.Models;
namespace ChapterFST1.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-IOBT0SP\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true;  TrustServerCertificate = True");

            }
        }
        public DbSet<Livro> Livros { get; set; }
    }
        
           
        
}