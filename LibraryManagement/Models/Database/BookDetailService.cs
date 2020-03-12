using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
namespace LibraryManagement.Models.Database
{
    public class BookDetailService
    {
       
        public  List<BookDetail> ListBooksForCategory(int id)
        {
            ;
            string sqlListBooks = $"SELECT  * FROM book_details WHERE category_id={id};";
    

            using (var connection = new   MySqlConnection("Server=localhost;Uid=HemNal;pwd=Breathe52;database=library;"))
            { connection.Open();
                var listBooks = (connection.Query<BookDetail>(sqlListBooks)).ToList();
                connection.Close();
                return listBooks;
               
            }

            
        }
    }
}