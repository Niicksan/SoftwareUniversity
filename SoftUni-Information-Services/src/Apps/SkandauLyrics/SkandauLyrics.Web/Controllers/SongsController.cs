using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Attributes.Security;
using SIS.MvcFramework.Result;
using SkandauLyrics.Services;
using SkandauLyrics.Web.ViewModels.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkandauLyrics.Web.Controllers
{
    public class SongsController : Controller
    {
        public readonly ISongsService songsService;
        private readonly ISingersService singersService;

        public SongsController(ISongsService songsService, ISingersService singersService)
        {
            this.songsService = songsService;
            this.singersService = singersService;
        }

        [Authorize]
        public IActionResult Create()
        {
            var list = this.singersService.GetSingerNames();
            return this.View(list);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(CreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Songs/Create");
            }

            this.songsService.Create(input.Name, input.Url, input.DateAdded, input.Lyric, input.SingerName);
            return this.Redirect("/Home/Index");
        }
    }
}