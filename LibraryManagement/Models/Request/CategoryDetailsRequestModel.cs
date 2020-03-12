using System.ComponentModel.DataAnnotations;
using LibraryManagement.Models.Database;
using Microsoft.Extensions.Configuration;

namespace LibraryManagement.Models.Request
{
   
    public class CategoryDetailsRequestModel
    {
        private readonly IConfiguration _configuration;
        public int Category_Id { get; set; }
        
        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string Category_Name{ get; set; }

        public CategoryDetailsRequestModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public bool IsPresent(string name)
        {
            var categoryDetailsService = new CategoryDetailsService(_configuration);
            return (categoryDetailsService.IsCategoryPresent(name));
        }
        
        
    }
}