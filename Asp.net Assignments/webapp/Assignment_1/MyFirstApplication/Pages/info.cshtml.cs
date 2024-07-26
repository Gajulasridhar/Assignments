using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstApplication.Pages
{
    public class infoModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Good Morning users!!";
        }
        public void OnPost()
        {
            Message = "Good Evening users!!";
        }
    }
}
