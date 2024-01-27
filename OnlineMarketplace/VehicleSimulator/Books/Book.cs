using OnlineMarketplace.Enums;

namespace OnlineMarketplace.Books
{
    public abstract class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime LaunchDate { get; set; }
        public CoverType CoverType { get; set; }
        public double Price { get; }
        public string Currency { get; set; }

        public Book(string author, string title, DateTime launchDate, CoverType cover, double price, double tax, string currency)
        {
            Author = author;
            Title = title;
            LaunchDate = launchDate;
            CoverType = cover;
            Price = price * (1+tax);
            Currency = currency;
        }

        public abstract bool IsFiction();
        public abstract bool IsScary();
        public virtual bool IsPhysicalBook()
        {
            return CoverType != CoverType.EBook;
        }
        public override string ToString()
        {
            return $"{Title}, written by {Author}, with a {CoverType} cover, released on {LaunchDate:d}, costing {Currency}{Price:F2}";
        }
    }
}
