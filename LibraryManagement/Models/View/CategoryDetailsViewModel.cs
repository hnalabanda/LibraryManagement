using System.Collections.Generic;

using LibraryManagement.Models.Database;

namespace LibraryManagement.Models.View
{
    public class CategoryDetailsViewModel
    {
        public CategoryDetails _Category { get; set; }
        public List<CategoryDetails> categoryDetails { get; set; }
        
        public CategoryDetailsViewModel()
        {
            
        }
        public CategoryDetailsViewModel(List<CategoryDetails> catDetails)
        {
            this.categoryDetails = catDetails;
        }
    }
}