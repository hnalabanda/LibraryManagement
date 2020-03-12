using System.Collections.Generic;
using LibraryManagement.Models.Database;
namespace LibraryManagement.Models.View
{
    public class BookDetailsViewModel
    {
        public List<BookDetail> bookDetails { get; set; }
        
        public BookDetailsViewModel()
        {
            
        }
        public BookDetailsViewModel(List<BookDetail> bookDetails)
        {
            this.bookDetails = bookDetails;
        }
    }
}