using System.Collections.Generic;
namespace LibraryManagement.Models.BookManagement
{
    public class CategoryDetailsModel
    {
        public List<CategoryDetails> categoryDetails { get; set; }
        
        public CategoryDetailsModel()
        {
            
        }
        public CategoryDetailsModel(List<CategoryDetails> catDetails)
        {
            this.categoryDetails = catDetails;
        }
    }
}