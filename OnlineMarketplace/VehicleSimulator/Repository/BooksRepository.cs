using OnlineMarketplace.Books;

namespace OnlineMarketplace.Repository
{
    public class BooksRepository
    {
        public static Dictionary<(string country, string genre), Book> AvailableBooks { get; set; } = new()
        {
            { ("US", "Horror"), new HorrorBook("Stephen King", "The Shining", new(1977, 01, 28), Enums.CoverType.PaperBack, 15.99, 0.06, "U$") },
            { ("US", "Literary"), new LiteraryBook("Antoine de Saint-Exupéry", "The Little Prince", new(1943, 11, 05), Enums.CoverType.HardCover, 23.99, 0.06, "U$") },
            { ("US", "SelfHelp"), new LiteraryBook("Dale Carnegie", "How to win friends and influence people", new(1936, 10, 05), Enums.CoverType.PaperBack, 13.99, 0.06, "U$") },
            { ("BR", "Horror"), new HorrorBook("Stephen King", "O Iluminado", new(1978, 03, 05), Enums.CoverType.HardCover, 79.90, 0.00, "R$") },
            { ("BR", "Literary"), new LiteraryBook("Antoine de Saint-Exupéry", "O Pequeno Príncipe", new(1948, 04, 12), Enums.CoverType.HardCover, 99.90, 0.00, "R$") },
            { ("BR", "SelfHelp"), new LiteraryBook("Dale Carnegie", "Como fazer amigos e influenciar pessoas", new(1936, 10, 05), Enums.CoverType.PaperBack, 49.90, 0.00, "R$") },
            { ("FR", "Horror"), new HorrorBook("Stephen King", "L'Enfant Lumière", new(1982, 01, 02), Enums.CoverType.PaperBack, 11.89, 0.08, "€") },
            { ("FR", "Literary"), new LiteraryBook("Antoine de Saint-Exupéry", "Le Petit Prince", new(1943, 05, 03), Enums.CoverType.PaperBack, 7.89, 0.08, "€") },
            { ("FR", "SelfHelp"), new LiteraryBook("Dale Carnegie", "Comment se faire des amis et influencer les autres", new(1936, 10, 05), Enums.CoverType.PaperBack, 9.89, 0.08, "€") }
        };

        public static Book Get(string country, string genre)
        {
            return AvailableBooks[(country, genre)];
        }
    }
}
