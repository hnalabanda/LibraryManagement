using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Models.Request;
using LibraryManagement.Models.View;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using MySql.Data.MySqlClient;

namespace LibraryManagement.Models.Database
{
    public class CategoryDetailsService
    {
        private CategoryDetails _categoryDetails;
        private readonly IConfiguration _configuration;
       
      
        public CategoryDetailsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public  List<CategoryDetails> ListCategories()
        {
            ;
            string sqlCategoryDetails = "SELECT  * FROM Category_Details;";
    

          //  using (var connection = new   MySqlConnection("Server=localhost;Uid=HemNal;pwd=Breathe52;database=library;"))
          using (var connection = new   MySqlConnection(_configuration.GetConnectionString("LibraryDatabase")))
            { connection.Open();
                var orderDetails = (connection.Query<CategoryDetails>(sqlCategoryDetails)).ToList();
                connection.Close();
                return orderDetails;
               
            }

            
        }

        public int AddCategory(CategoryDetailsViewModel categoryDetails)
        {
            string sqlQuery= "INSERT INTO Category_Details(Category_Name) VALUES (@pCategoryName);";
            //connect to db
            using (var connection = new   MySqlConnection(_configuration.GetConnectionString("LibraryDatabase")))
            {
                var affectedRows = connection.Execute(sqlQuery, new {pCategoryName = categoryDetails._Category.Category_Name});
                
                return affectedRows;
               
            }
        }
        
        public bool IsCategoryPresent(string categoryName)
        {
            string sqlQuery= "SELECT * FROM  Category_Details WHERE Category_Name like (@pCategoryName);";
            //connect to db
            using (var connection = new   MySqlConnection(_configuration.GetConnectionString("LibraryDatabase")))
            {
             
                var orderDetails = (connection.Query<CategoryDetails>(sqlQuery));
               
                return false;
            }
        }
    }
}