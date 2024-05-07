namespace LayeredArchitectureBookManagement;

class Program
{
    static void Main(string[] args)
    {
        var bookManagement = new LayeredArchitectureConfigurator().ConfigureSystem();
        bookManagement.DisplayAllBooks();
    }
}
