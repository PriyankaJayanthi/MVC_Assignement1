using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Assignement1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_Assignement1.Controllers
{
    public class DoctorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(double input_temp, string Temperature)
        {
            ViewBag.temperature = input_temp;
            ViewBag.result = FevercheckModel.Fever_check(input_temp, Temperature);
            return View();

        }
    }
}

