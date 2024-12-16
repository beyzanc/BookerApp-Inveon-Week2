using Booker.App.Models;
using Microsoft.EntityFrameworkCore;

namespace Booker.App.Context
{
    public static class BookSeedData
    {
        public static void SeedBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "1984",
                    Author = "George Orwell",
                    PublicationYear = 1949,
                    ISBN = "9780451524935",
                    Genre = "Dystopian",
                    Publisher = "Secker & Warburg",
                    PageCount = 328,
                    Language = "English",
                    Summary = "A dystopian novel about totalitarian regime.",
                    AvailableCopies = 5
                },
                new Book
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    PublicationYear = 1960,
                    ISBN = "9780060935467",
                    Genre = "Fiction",
                    Publisher = "J.B. Lippincott & Co.",
                    PageCount = 281,
                    Language = "English",
                    Summary = "Story about racial injustice and childhood innocence.",
                    AvailableCopies = 3
                },
                new Book
                {
                    Id = 3,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    PublicationYear = 1937,
                    ISBN = "9780345339683",
                    Genre = "Fantasy",
                    Publisher = "George Allen & Unwin",
                    PageCount = 310,
                    Language = "English",
                    Summary = "A fantasy novel about Bilbo Baggins' adventure.",
                    AvailableCopies = 7
                },
                new Book
                {
                    Id = 4,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    PublicationYear = 1813,
                    ISBN = "9780141439518",
                    Genre = "Romance",
                    Publisher = "T. Egerton",
                    PageCount = 279,
                    Language = "English",
                    Summary = "A classic novel exploring manners and marriage in early 19th century England.",
                    AvailableCopies = 6
                },
                new Book
                {
                    Id = 5,
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    PublicationYear = 1951,
                    ISBN = "9780316769488",
                    Genre = "Fiction",
                    Publisher = "Little, Brown and Company",
                    PageCount = 214,
                    Language = "English",
                    Summary = "A novel about teenage rebellion and angst.",
                    AvailableCopies = 4
                },
                new Book
                {
                    Id = 6,
                    Title = "Moby Dick",
                    Author = "Herman Melville",
                    PublicationYear = 1851,
                    ISBN = "9781503280786",
                    Genre = "Adventure",
                    Publisher = "Harper & Brothers",
                    PageCount = 585,
                    Language = "English",
                    Summary = "The epic tale of a sea captain's obsession with a white whale.",
                    AvailableCopies = 2
                },
                new Book
                {
                    Id = 7,
                    Title = "War and Peace",
                    Author = "Leo Tolstoy",
                    PublicationYear = 1869,
                    ISBN = "9781400079988",
                    Genre = "Historical",
                    Publisher = "The Russian Messenger",
                    PageCount = 1225,
                    Language = "English",
                    Summary = "A novel chronicling the history of the French invasion of Russia.",
                    AvailableCopies = 3
                },
                new Book
                {
                    Id = 8,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    PublicationYear = 1925,
                    ISBN = "9780743273565",
                    Genre = "Fiction",
                    Publisher = "Charles Scribner's Sons",
                    PageCount = 180,
                    Language = "English",
                    Summary = "A novel about the American dream and social stratification in the 1920s.",
                    AvailableCopies = 5
                },
                new Book
                {
                    Id = 9,
                    Title = "Crime and Punishment",
                    Author = "Fyodor Dostoevsky",
                    PublicationYear = 1866,
                    ISBN = "9780140449136",
                    Genre = "Psychological",
                    Publisher = "The Russian Messenger",
                    PageCount = 671,
                    Language = "English",
                    Summary = "A story about guilt and redemption of a young man in St. Petersburg.",
                    AvailableCopies = 4
                },
                new Book
                {
                    Id = 10,
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    PublicationYear = 1932,
                    ISBN = "9780060850524",
                    Genre = "Dystopian",
                    Publisher = "Chatto & Windus",
                    PageCount = 268,
                    Language = "English",
                    Summary = "A novel depicting a technologically advanced but dehumanized society.",
                    AvailableCopies = 6
                }
            );
        }
    }
}
