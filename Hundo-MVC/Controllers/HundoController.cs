using Hundo_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hundo_MVC.Controllers
{
    public class HundoController : Controller
    {
        [HttpPost]
        public IActionResult Index(HundoNumbers nums)
        {
            List<string> numItems = new List<string>();

            for (int i = nums.StartValue; i <= nums.EndValue; i++)
            {
                numItems.Add(i.ToString());
            }

            nums.Results = numItems;

            return View(nums);
        }
    


    
        public IActionResult Index()
        {
            HundoNumbers nums = new HundoNumbers();

            nums.StartValue = 1;
            nums.EndValue = 100;

            return View(nums);
        }
    }
}
