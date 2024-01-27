﻿using OnlineMarketplace.Enums;

namespace OnlineMarketplace.Books
{
    public class HorrorBook : Book
    {
        public HorrorBook(string author, string title, DateTime LaunchDate, CoverType coverType, double price, double tax, string currency)
            : base(author, title, LaunchDate, coverType, price, tax, currency) { }
        public override bool IsFiction()
        {
            return true;
        }

        public override bool IsScary()
        {
            return true;
        }
    }
}
