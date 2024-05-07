public interface IApplicationLayer {
    public IEnumerable<Book> GetAllBooks();

    public Book GetBookById(int id);
}
