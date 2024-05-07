
public class CApplicationLayer : IApplicationLayer
{
    private IDataAccessLayer dataAccessLayer;

    public CApplicationLayer(IDataAccessLayer dataAccessLayer)
    {
        this.dataAccessLayer = dataAccessLayer;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return dataAccessLayer.GetAllBooks();
    }

    public Book GetBookById(int id)
    {
        return dataAccessLayer.GetBookById(id);
    }
}
