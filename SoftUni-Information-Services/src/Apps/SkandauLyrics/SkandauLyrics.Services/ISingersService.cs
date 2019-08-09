using System;
using System.Collections.Generic;
using System.Text;

namespace SkandauLyrics.Services
{
    public interface ISingersService
    {
        IEnumerable<string> GetSingerNames();
    }
}
