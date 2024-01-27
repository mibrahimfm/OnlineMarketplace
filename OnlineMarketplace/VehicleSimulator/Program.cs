// See https://aka.ms/new-console-template for more information
using OnlineMarketplace.Books;
using OnlineMarketplace.Factory;
using System.Text;

static IBooksFactory InstantiateFactoryByCountry(int country)
{
    switch (country)
    {
        case 1:            
           return new USBooksFactory();            
        case 2:
            return new FRBooksFactory();
        case 3:
            return new BRBooksFactory();
        default:
            throw new ArgumentException("Non existent country");
    }
}

static List<Book> CreateBooks(IBooksFactory factory)
{
    return new List<Book>()
    {
        factory.CreateLiteraryBook(),
        factory.CreateSelfHelpBook(),
        factory.CreateHorrorBook()
    };
}

static void printBooks(List<Book> books)
{
    foreach (Book book in books)
    {
        Console.WriteLine(book.ToString());
    }
}

static void printScaryBooks(List<Book> books)
{
    books.Select(b => b.IsScary()).ToList().ForEach(book => Console.WriteLine(book.ToString()));
}

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Select marketplace country to view: \n1 - United States\n2 - France\n3 - Brazil");
int country = int.Parse(Console.ReadLine());

IBooksFactory factory = InstantiateFactoryByCountry(country);
var books = CreateBooks(factory);
printBooks(books);
printScaryBooks(books);

