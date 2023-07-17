using SimpleLibraryApp_DataAccess.Models;

namespace SimpleLibraryApp_MVC.Models
{
    public class LentBooksViewModel
    {
        public Customer Customer { get; set; }
        public List<LentBook> LentBooks { get; set; }
    }
}
