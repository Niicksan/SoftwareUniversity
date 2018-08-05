using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using To_Do_List.Models;

namespace To_Do_List.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new TasskDbContext())
            {
                var tasks = db.Tassk.ToList();

                return View(tasks);
            }          
        }
    }
}
