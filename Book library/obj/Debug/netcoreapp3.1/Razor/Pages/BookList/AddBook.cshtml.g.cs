#pragma checksum "C:\Users\Peter\Desktop\Programming\C#\Book library\Book library\Pages\BookList\AddBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f3923f1acbb6cfed7c42e20468cec16a2ecdc94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Book_library.Pages.BookList.Pages_BookList_AddBook), @"mvc.1.0.razor-page", @"/Pages/BookList/AddBook.cshtml")]
namespace Book_library.Pages.BookList
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
#line 1 "C:\Users\Peter\Desktop\Programming\C#\Book library\Book library\Pages\_ViewImports.cshtml"
using Book_library;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f3923f1acbb6cfed7c42e20468cec16a2ecdc94", @"/Pages/BookList/AddBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c516d1be5f06aa2cf625521428ccf89a5409c887", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BookList_AddBook : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Peter\Desktop\Programming\C#\Book library\Book library\Pages\BookList\AddBook.cshtml"
  
    ViewData["Title"] = "AddBook";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>AddBook</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book_library.AddBookModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Book_library.AddBookModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Book_library.AddBookModel>)PageContext?.ViewData;
        public Book_library.AddBookModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
