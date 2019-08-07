using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkandauLyrics.Services
{
    public interface ISongsService
    {
        void Create(string name, string url, DateTime dateAdded, string lyric, string singerName);
    }
}
