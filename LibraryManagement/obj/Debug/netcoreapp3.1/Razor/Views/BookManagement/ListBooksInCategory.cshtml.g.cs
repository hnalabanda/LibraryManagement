#pragma checksum "C:\Training\LibraryManagement\LibraryManagement\Views\BookManagement\ListBooksInCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a339eac53cccde8c51596289afe54d015b0d7bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookManagement_ListBooksInCategory), @"mvc.1.0.view", @"/Views/BookManagement/ListBooksInCategory.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Training\LibraryManagement\LibraryManagement\Views\_ViewImports.cshtml"
using LibraryManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Training\LibraryManagement\LibraryManagement\Views\_ViewImports.cshtml"
using LibraryManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a339eac53cccde8c51596289afe54d015b0d7bc", @"/Views/BookManagement/ListBooksInCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03b079343b697176e720de9fa2d2a7e6e87ff5", @"/Views/_ViewImports.cshtml")]
    public class Views_BookManagement_ListBooksInCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryManagement.Models.View.BookDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Training\LibraryManagement\LibraryManagement\Views\BookManagement\ListBooksInCategory.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <table style=\"width:100%;border: #1c7430\">\r\n      <tr>\r\n        <th>ISBN Code</th>\r\n        <th>Title</th>\r\n          <th>Language</th>\r\n          <th>Publication</th>\r\n      </tr>\r\n");
#nullable restore
#line 15 "C:\Training\LibraryManagement\LibraryManagement\Views\BookManagement\ListBooksInCategory.cshtml"
         foreach (var book in Model.bookDetails)
        {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Training\LibraryManagement\LibraryManagement\Views\BookManagement\ListBooksInCategory.cshtml"
               Write(book.ISBN_Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Training\LibraryManagement\LibraryManagement\Views\BookManagement\ListBooksInCategory.cshtml"
               Write(book.Book_Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Training\LibraryManagement\LibraryManagement\Views\BookManagement\ListBooksInCategory.cshtml"
               Write(book.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 22 "C:\Training\LibraryManagement\LibraryManagement\Views\BookManagement\ListBooksInCategory.cshtml"
                Write(book.Publication_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Training\LibraryManagement\LibraryManagement\Views\BookManagement\ListBooksInCategory.cshtml"
          

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </table>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryManagement.Models.View.BookDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591