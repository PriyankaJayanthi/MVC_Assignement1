using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignement1.Models;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_Assignement1.Controllers
{
    public class GuessgameController : Controller
    {
        // GET: /<controller>/
        public IActionResult GuessView()
        {
            int rand_num = GameModel.GetGuessNumber();
            HttpContext.Session.SetInt32("rndvalue", rand_num);
            return View();
        }
        [HttpPost]
        public IActionResult Guessview(int input_num)
        {
            int game_num = (int)HttpContext.Session.GetInt32("rndvalue");
            ViewBag.Message = GameModel.CheckGuess(input_num, game_num);
            return View("GuessView");

        }

        public IActionResult Reset()
        {
            GameModel.store_num.Clear();
            int rand_num = GameModel.GetGuessNumber();
            HttpContext.Session.SetInt32("randval", rand_num);
            return View("GuessView");
        }
        
    }
}

