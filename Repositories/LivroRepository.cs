using ChapterFST1.Contexts;
using ChapterFST1.Models;
namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
        
        private readonly ChapterContext _context;
        
        public LivroRepository(ChapterContext context)
        {
            _context = context;
	@@ -304,22 + 539,55 @@ namespace ChapterFST1.Repositories
    }
}