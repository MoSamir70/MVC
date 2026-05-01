using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class StudentController : Controller
    {
      

        //  /Student/ShowAll
        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> StudentListModel = studentBL.GetAll();
          //  return View("ShowAll"); // empty Model  
            return View("ShowAll", StudentListModel); // Model List<student> Using Overload View + Model
        }

        //  /Student/DEtails?id=1
        public IActionResult DEtails(int id)
        {
            StudentBL studentBL = new StudentBL();

            Student studentModel = studentBL.GetById(id);
           // return View("ShowDEtails") // model = null --> exception
            return View("ShowDEtails", studentModel);//View ShowDetails --> Model = Student
        }
    }
}
