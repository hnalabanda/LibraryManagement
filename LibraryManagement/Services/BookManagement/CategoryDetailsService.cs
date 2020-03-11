using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
namespace LibraryManagement.Models.BookManagement
{
    public class CategoryDetailsService
    {
        private CategoryDetails _categoryDetails;
        
        public  List<CategoryDetails> ListCategories()
        {
            ;
            string sqlCategoryDetails = "SELECT  * FROM Category_Details;";
    

            using (var connection = new   MySqlConnection("Server=localhost;Uid=HemNal;pwd=Breathe52;database=library;"))
            { connection.Open();
                var orderDetails = (connection.Query<CategoryDetails>(sqlCategoryDetails)).ToList();
                return orderDetails;
            }

            
        }
    }
}