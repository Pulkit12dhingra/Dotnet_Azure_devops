using Assignmnet2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignmnet2.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DisplayValue(int t1, int t2)
        {
            Values values = new Values();
            int a = t1;
            int b = t2;

            values.add = a + b;
            values.sub = a - b;
            values.mul = a * b;
            values.divQue = a / b;
            values.divRem = a % b;

            return View(values);
        }


        public IActionResult Index()
        {
            Values val = new Values();
            return View();
        }

        public int Add(int a, int b) {
            return a+ b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        


        public ActionResult Display(Values val)
        {
            
            return View();
        }
    }
}
