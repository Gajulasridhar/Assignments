using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class GetBookModel : PageModel
    {
        static List<Book> books= new List<Book>() {

            new Book(){Book_id=1, Book_name="Complete study on Csharp", Book_price=543,language="English",Author="sridhar"},
            new Book(){Book_id=2, Book_name="kalki", Book_price=547,language="Telugu",Author="sai"},
            new Book(){Book_id=3, Book_name="spirit", Book_price=545,language="Hindi",Author="srivastav"},

            };
        [BindProperty]
        public Book Book { get; set; }
        public List<Book> Books { get { return books; } }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            books.Add(Book);
            return (RedirectToPage("GetBook"));
        }
    }
}
