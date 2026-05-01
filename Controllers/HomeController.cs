using System.Diagnostics;
using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {



        // Methods Constrains => Public + not static + no oveload

        // First step
        // Home/showMsg -> return text

        //public string showMsg()
        //{
        //    return "hello world";
        //}


        //------------Second step---------------- Let's return view 


        //   /Home/ShowMsg
        public ContentResult ShowMsg()
        {
            
            ContentResult result = new ContentResult(); // declare
            result.Content = "Hello World";  // initial  +  // C is Capital
            return result;
        }

        //    /Home/ShowView
        // Search in Views Folder -> Home then Shared 
        // if not found -> URL Problem
        public ViewResult ShowView()
        {

            ViewResult result = new ViewResult(); // declare
            result.ViewName = "View1";  // initial   // Must creat View1 in Views
            return result;
        }


        //------------------------ Third Step -- IActionResult ----------------

        // /Home/ShowMix?id=2&name=mohamed

        public IActionResult ShowMix(int id , string name)
        {
            if(id %2 == 0)
            {
                ViewResult result = new ViewResult(); // declare
                result.ViewName = "View1";  // initial   // Must creat View1 in Views
                return result;
           
            }
            else
            {
                ContentResult result = new ContentResult(); // declare
                result.Content = "Hello World";  // initial  +  // C is Capital
                return result;
            }
        }


        //------------ Reduce Redundent Code

        // /Home/ShowMix2?id=2&name=mohamed
        // built in Funcs inherets from controller
        // Return Result based on type
        public IActionResult ShowMix2(int id, string name)
        {
            if (id % 2 == 0)
            {
                return View("View1");
            }
            else
            {         
                return Content("Hello World");
            }
        }

        //------------------------------------- end of controller session 1




        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
