using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstApplication.Pages
{
    public class LoginPageModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string Message { get; set; }
        public void OnPost()
        {
            if (Name == "Sridhar" && Password == "1234")
            {
                Message = "Login Succesfull";
            }
            else
            {
                
                    Message = "Login Failed";
                
            }
        }
    }
}
