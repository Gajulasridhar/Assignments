using HandsOnEFDB.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFDB.Controllers
{
    public class ProductController : Controller
    {
        private readonly SqlAssignmentContext sqlAssignmentContext;
        public ProductController()
        {
            sqlAssignmentContext = new SqlAssignmentContext();
        }
        public IActionResult Index()
        {
            var product = sqlAssignmentContext.Products;
            return View(product);
        }
    }
}
