namespace LibraryManagement.Models.Request
{
    public class BookDetailRequestModel
    {
    
            public int ISBN_Code { get; set; }
            public string Book_Title{ get; set; }
            public string Language{ get; set; }
            public string Binding_Id{ get; set; }
            public string No_Copies_Actual{ get; set; }
            public string No_Copies_Current{ get; set; }
            public string Category_id{ get; set; }
            public string Publication_year{ get; set; }
        
    }
}