

public class CDataAccessLayer : IDataAccessLayer {

    private List<Book> books;

    public CDataAccessLayer()
    {
        books = new List<Book> {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", Year = 2008 },
            new Book { Id = 2, Title = "Design Patterns", Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", Year = 1994 },
            new Book { Id = 3, Title = "Domain-Driven Design", Author = "Eric Evans", Year = 2003 }
        };
    }

    public IEnumerable<Book> GetAllBooks() {
        return books;
    }

    public Book GetBookById(int id) {
        return books.Find(book => book.Id == id);
    }
}