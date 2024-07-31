using HandsOnEFDB.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFDB.Controllers
{
    
    public class EmployeeController : Controller
    {
        private readonly SqlAssignmentContext sqlAssignmentContext;
        public EmployeeController()
        {
            sqlAssignmentContext = new SqlAssignmentContext();
        }
         public IActionResult Index()
        {
            var employee = sqlAssignmentContext.Employees;
            return View(employee);
        }
    }
}
