using ChapterProject1.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterProject1.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(){}
        public SqlContext(DbContextOptions<SqlContext> options): base(options){}


        // vamos utilizar esse método para configurar o banco de dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = SHEY\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
                // optionsBuilder.UseSqlServer("Data Source = SHEY\\SQLEXPRESS; initial catalog = Chapter; User Id = Shey; Password = tvd4ever");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
