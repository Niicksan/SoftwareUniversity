using SkandauLyrics.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkandauLyrics.Services
{
    public class SingersService : ISingersService
    {
        private readonly SkandauLyricsDbContext db;

        public SingersService(SkandauLyricsDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<string> GetSingerNames()
        {
            var singerNames = this.db.Singers.Select(x => x.Name).ToList();
            return singerNames;
        }
    }
}
