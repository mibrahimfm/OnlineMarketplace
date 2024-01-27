using OnlineMarketplace.Books;

namespace OnlineMarketplace.Factory
{
    public interface IBooksFactory
    {
        public Book CreateHorrorBook();
        public Book CreateLiteraryBook();
        public Book CreateSelfHelpBook();
    }
}
