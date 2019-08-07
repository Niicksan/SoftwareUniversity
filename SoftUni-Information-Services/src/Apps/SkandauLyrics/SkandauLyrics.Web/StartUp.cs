using SIS.MvcFramework;
using SIS.MvcFramework.DependencyContainer;
using SIS.MvcFramework.Routing;
using SkandauLyrics.Data;
using SkandauLyrics.Services;
using System.Collections.Generic;
using System.Text;

namespace SkandauLyrics.Web
{
    public class Startup : IMvcApplication
    {
        public void Configure(IServerRoutingTable serverRoutingTable)
        {
            // Once on a start
            using (var db = new SkandauLyricsDbContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public void ConfigureServices(IServiceProvider serviceProvider)
        {
            serviceProvider.Add<ISongsService, SongsService>();
        }
    }
}