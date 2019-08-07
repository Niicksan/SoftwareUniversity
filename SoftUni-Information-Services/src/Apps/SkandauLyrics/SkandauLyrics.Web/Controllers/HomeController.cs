using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkandauLyrics.Web.Controllers
{
    public class HomeController : Controller
    {
        // /
        [HttpGet(Url = "/")]
        public IActionResult IndexSlash()
        {
            return this.Index();
        }

        // Home/Index
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
