using ChapterProject1.Contexts;
using ChapterProject1.Models;

namespace ChapterProject1.Repositories
{
    public class LivroRepository
    {
        private readonly SqlContext _context;

        public LivroRepository(SqlContext context )
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }


    }
}
