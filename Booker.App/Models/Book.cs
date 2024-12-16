namespace Booker.App.Models
{
        public class Book
        {
            public int Id { get; set; } 
            public required string Title { get; set; } 
            public required string Author { get; set; } 
            public required int PublicationYear { get; set; } 
            public required string ISBN { get; set; } 
            public string? Genre { get; set; } 
            public string? Publisher { get; set; } 
            public int? PageCount { get; set; } 
            public string? Language { get; set; } 
            public string? Summary { get; set; } 
            public int? AvailableCopies { get; set; } 
        }
   
}
