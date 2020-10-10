using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            Random random = new Random();
            double firstNumber = random.Next(0, 10);
            double secondNumber = random.Next(0, 10);
            Dictionary<string, double> data = new Dictionary<string, double>();
            data.Add("firstNumber", firstNumber);
            data.Add("secondNumber", secondNumber);
            data.Add("sum", firstNumber + secondNumber);
            data.Add("sub", firstNumber - secondNumber);
            data.Add("mult", firstNumber * secondNumber);
            if (secondNumber != 0) data.Add("div", firstNumber / secondNumber);
            //else throw new DivideByZeroException();
            return View(data);
        }

        public IActionResult PassUsingViewData()
        {
            Random random = new Random();
            double firstNumber = random.Next(0, 10);
            double secondNumber = random.Next(0, 10);
            ViewData["firstNumber"] = firstNumber;
            ViewData["secondNumber"] = secondNumber;
            ViewData["sum"] = firstNumber + secondNumber;
            ViewData["sub"] = firstNumber - secondNumber;
            ViewData["mult"] = firstNumber * secondNumber;
            if (secondNumber != 0) ViewData["div"] = firstNumber / secondNumber;
            //else throw new DivideByZeroException();
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            Random random = new Random();
            double firstNumber = random.Next(0, 10);
            double secondNumber = random.Next(0, 10);
            ViewBag.firstNumber = firstNumber;
            ViewBag.secondNumber = secondNumber;
            ViewBag.sum = firstNumber + secondNumber;
            ViewBag.sub = firstNumber - secondNumber;
            ViewBag.mult = firstNumber * secondNumber;
            if (secondNumber != 0) ViewBag.div = firstNumber / secondNumber;
            //else throw new DivideByZeroException();
            return View();
        }

        public IActionResult AccessServiceDirectly()
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
