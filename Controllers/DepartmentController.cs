using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstMVC.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext context = new ITIContext();

        // run --> http://localhost:5077/Department/Index
        public IActionResult Index()
        {
            // using lazy loading
            // List<Department> departmentList = context.Department.ToList(); // return Null = Ligh object = Navigation property

            List<Department> departmentList = context.Department.Include(d => d.Emps).ToList(); // cancel Lazy Loading 
            return View("Index", departmentList); //Model List<department>
        }
    }
}
