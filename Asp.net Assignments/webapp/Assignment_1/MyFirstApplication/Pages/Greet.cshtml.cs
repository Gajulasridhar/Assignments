using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstApplication.Pages
{
    public class GreetModel : PageModel
    {

        [BindProperty]
        public string Name { get; set; }
       
        public string Message { get; set; }
            public void OnPost()
            {
                Message = "Hello";
            }
        
    }
}
