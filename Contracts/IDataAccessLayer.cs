
public interface IDataAccessLayer {
    public IEnumerable<Book> GetAllBooks();

    public Book GetBookById(int id);
}