public class CPresentationLayer {

    private IApplicationLayer applicationLayer;

    public CPresentationLayer(IApplicationLayer applicationLayer)
    {
        this.applicationLayer = applicationLayer;
    }

    public void DisplayAllBooks() {
        Console.WriteLine("All Books:");
        foreach (var book in applicationLayer.GetAllBooks())
        {
            Console.WriteLine($"{book.Id}: {book.Title} by {book.Author} ({book.Year})");
        }
    }

    public void DisplayBookDetails(int bookId)
    {
        Book book = applicationLayer.GetBookById(bookId);
        if (book != null)
        {
            Console.WriteLine($"Book Details for Book ID {bookId}:");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Year: {book.Year}");
        }
        else
        {
            Console.WriteLine($"Book with ID {bookId} not found.");
        }
    }
}

