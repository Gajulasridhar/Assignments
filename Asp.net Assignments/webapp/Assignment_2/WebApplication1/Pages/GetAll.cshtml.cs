using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class GetAllModel : PageModel
    {
       static List<Product> products = new List<Product>() {

            new Product(){id=1, name="Mouse", price=543,stock=10},
            new Product(){id=2, name="Keyboard", price=547,stock=10},
            new Product(){id=3, name="Joystick", price=545,stock=100},

            };
        [BindProperty]
        public Product Product { get; set; }
        public List<Product> Products { get { return products; } }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            products.Add(Product);
            return (RedirectToPage("GetAll"));
        }
    }
}
