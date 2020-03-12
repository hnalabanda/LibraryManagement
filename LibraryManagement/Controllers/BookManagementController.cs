using LibraryManagement.Models.Database;
using LibraryManagement.Models.View;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;


namespace LibraryManagement.Controllers
{
    public class BookManagement : Controller
    {
        private readonly IConfiguration _configuration;

        public BookManagement(IConfiguration configuration)
        {
            _configuration = configuration;
        }

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
            CategoryDetailsService categoryDetailsService = new CategoryDetailsService(_configuration);
            List<CategoryDetails> listCategories = categoryDetailsService.ListCategories();
            // then we make a Model based on that list
            CategoryDetailsViewModel categoryDetailsModel = new CategoryDetailsViewModel(listCategories);

            // finally return the view using that model.
            return View(categoryDetailsModel);
        }

        public IActionResult ListBooksInCategory(int id)
        {
            // Call our CategoryDetailsService
            // THAT gives us a list of category details
            var bookDetailService = new BookDetailService();
            var listBooks = bookDetailService.ListBooksForCategory(id);
            // then we make a Model based on that list
        
            var bookDetailsModel = new BookDetailsViewModel(listBooks);

            // finally return the view using that model.
            return View(bookDetailsModel);
        }

        public IActionResult AddCategoryForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategoryForm(CategoryDetailsViewModel categoryDetailsModel)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                // Call our CategoryDetailsService
                // THAT gives us a list of category details
                var categoryDetailsService = new CategoryDetailsService(_configuration);
                int affectedRows = categoryDetailsService.AddCategory(categoryDetailsModel);
                if (affectedRows > 0)
                {
                    message +=
                        $"The category {categoryDetailsModel._Category.Category_Name} has been successfully created";
                }
            }
            else
            {
                return View(categoryDetailsModel);
            }

            return Content(message);
        }
    }
}