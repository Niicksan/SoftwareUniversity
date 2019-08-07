using SkandauLyrics.Data;
using SkandauLyrics.Data.Models;
using System;
using System.Linq;

namespace SkandauLyrics.Services
{
    public class SongsService : ISongsService
    {
        private readonly SkandauLyricsDbContext db;
        private readonly ISongsService songsService;

        public SongsService(SkandauLyricsDbContext db, ISongsService songsService)
        {
            this.db = db;
            this.songsService = songsService;
        }

        public void Create(string name, string url, DateTime dateAdded, string lyric, string singerName)
        {
            var singerId = this.db.Singers.Where(x => x.Name == singerName).Select(x => x.Id).FirstOrDefault();

            if (singerId == null)
            {
                //throw new Exception("The user ID is null or there is not a user with that username!");
                return;
            }

            var song = new Song
            {
                Name = name,
                Url = url,
                DateAdded = dateAdded,
                Lyric = lyric,
                SingerId = singerId
            };

            this.db.Songs.Add(song);
            this.db.SaveChanges();
        }
    }
}