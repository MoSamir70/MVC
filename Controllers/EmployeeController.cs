using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


using FirstMVC.ViewModel;  // do not forget -> if not found make error in EmpDEptColorTempMSgBrchViewModel

namespace FirstMVC.Controllers
{

    // http://localhost:5077/Employee/Details?id=3
    // hint -> ids in db is only 3 and 4
    public class EmployeeController : Controller
    {
        ITIContext context = new ITIContext();
        public EmployeeController()
        {

        }
        public IActionResult Details(int id)
        {
            string msg = "Hello From Action";
            int temp = 50;
            List<string> bracnches = new List<string>();

            bracnches.Add("Assiut");
            bracnches.Add("Alex");
            bracnches.Add("Cario");
            //Aditional info send to View from Action
            ViewData["Msg"] = msg;
            ViewData["Temp"] = temp;
            ViewData["brch"] = bracnches;


            ViewData["Color"] = "Blue";
            ViewBag.Color = "REd"; // override on ViewData["Color"] = final will be  red = alwayes the last one

            //ViewData.Model=empMo
            Employee EmpMOdel = context.Employee.FirstOrDefault(e => e.Id == id);
            return View("Details", EmpMOdel);
        }


        // http://localhost:5077/Employee/DetailsVM?id=3  --> got exception ?!!
        public IActionResult DetailsVM(int id)
        {

            //Employee empMOdel = context.Employee
            //   .FirstOrDefault(e => e.Id == id);

            Employee empMOdel = context.Employee
                 .Include(e => e.Department)
                .FirstOrDefault(e => e.Id == id);

            List<string> bracnches = new List<string>();

            bracnches.Add("Assiut");
            bracnches.Add("Alex");
            bracnches.Add("Cario");

            //decalre viewmode
            EmpDEptColorTempMSgBrchViewModel EmpVM = new EmpDEptColorTempMSgBrchViewModel();

            //Mapping 
            EmpVM.EmpName = empMOdel.Name;
            EmpVM.DeptName = empMOdel.Department.Name;
            EmpVM.Color = "REd";
            EmpVM.Temp = 12;
            EmpVM.Msg = "Hello FRom VM";
            EmpVM.Branches = bracnches;
            return View("DetailsVM", EmpVM);//EmpDEptColorTempMSgBrchViewModel
        }
    }
}
