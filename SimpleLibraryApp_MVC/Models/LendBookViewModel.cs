using SimpleLibraryApp_DataAccess.Models;

namespace SimpleLibraryApp_MVC.Models
{
    public class LendBookViewModel
    {
        public Customer Customer { get; set; }
        public List<Book> Books { get; set; }
    }
}
