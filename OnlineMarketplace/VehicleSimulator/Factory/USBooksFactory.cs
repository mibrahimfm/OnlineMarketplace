using OnlineMarketplace.Books;
using OnlineMarketplace.Repository;

namespace OnlineMarketplace.Factory
{
    public class USBooksFactory : IBooksFactory
    {
        public Book CreateHorrorBook()
        {
            return BooksRepository.Get("US", "Horror");
        }

        public Book CreateLiteraryBook()
        {
            return BooksRepository.Get("US", "Literary");
        }

        public Book CreateSelfHelpBook()
        {
            return BooksRepository.Get("US", "SelfHelp");
        }
    }
}
