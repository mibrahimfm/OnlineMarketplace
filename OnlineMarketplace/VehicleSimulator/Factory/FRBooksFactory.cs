using OnlineMarketplace.Books;
using OnlineMarketplace.Repository;

namespace OnlineMarketplace.Factory
{
    public class FRBooksFactory : IBooksFactory
    {
        public Book CreateHorrorBook()
        {
            return BooksRepository.Get("FR", "Horror");
        }

        public Book CreateLiteraryBook()
        {
            return BooksRepository.Get("FR", "Literary");
        }

        public Book CreateSelfHelpBook()
        {
            return BooksRepository.Get("FR", "SelfHelp");
        }
    }
}
