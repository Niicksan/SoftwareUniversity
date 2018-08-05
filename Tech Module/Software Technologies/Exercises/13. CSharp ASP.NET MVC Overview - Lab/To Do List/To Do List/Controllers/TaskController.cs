using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using To_Do_List.Models;

namespace To_Do_List.Controllers
{
    public class TasskController : Controller
    {
        [HttpPost]
        public IActionResult Create( Tassk task)
        {
            if (task == null)
            {
                return RedirectToAction("Index", "Home");
            }

            using (var db = new TasskDbContext())
            {
                db.Tassk.Add(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            using (var db = new TasskDbContext())
            {
                var task = db.Tassk.Find(id);

                if (task == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                db.Tassk.Remove(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}