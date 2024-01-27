using OnlineMarketplace.Books;
using OnlineMarketplace.Repository;

namespace OnlineMarketplace.Factory
{
    public class BRBooksFactory : IBooksFactory
    {
        public Book CreateHorrorBook()
        {
            return BooksRepository.Get("BR", "Horror");
        }

        public Book CreateLiteraryBook()
        {
            return BooksRepository.Get("BR", "Literary");
        }

        public Book CreateSelfHelpBook()
        {
            return BooksRepository.Get("BR", "SelfHelp");
        }
    }
}
