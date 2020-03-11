using LibraryManagement.Models.BookManagement;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace LibraryManagement.Controllers
{
    public class BookManagement : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("bookmanagement/browse-catalogue")]
        public IActionResult BrowseCatalogue()
        {
            // Call our CategoryDetailsService
            // THAT gives us a list of category details
            CategoryDetailsService categoryDetailsService=new CategoryDetailsService();
             List<CategoryDetails> listCategories=categoryDetailsService.ListCategories();
            // then we make a Model based on that list
            CategoryDetailsModel categoryDetailsModel=new CategoryDetailsModel(listCategories);
            
            // finally return the view using that model.
            return View(categoryDetailsModel);
        }
    }
}