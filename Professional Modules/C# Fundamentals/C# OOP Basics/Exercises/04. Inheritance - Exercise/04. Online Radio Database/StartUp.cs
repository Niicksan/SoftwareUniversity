using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRadioDatabase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Song> playList = GetPlayList();

            PrintPlaylistInfo(playList);

        }

        private static void PrintPlaylistInfo(List<Song> playlist)
        {
            int[] playlistLenght = CalculatePlaylistLength(playlist);

            Console.WriteLine($"Songs added: {playlist.Count}");
            Console.WriteLine($"Playlist length: {playlistLenght[0]}h {playlistLenght[1]}m {playlistLenght[2]}s");
        }

        private static int[] CalculatePlaylistLength(List<Song> playlist)
        {
            long totalLengthSecs = playlist.Sum(s => s.CalculateSongLength());

            int[] playlistLength = new int[3]; // h : mm: ss
            int index = playlistLength.Length - 1;

            while (totalLengthSecs > 0 && index >= 0)
            {
                playlistLength[index--] = (int)(totalLengthSecs % 60);
                totalLengthSecs /= 60;
            }

            return playlistLength;
        }

        private static List<Song> GetPlayList()
        {
            List<Song> playList = new List<Song>();

            int songNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < songNumbers; i++)
            {
                string[] songInfo = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    // <artist name>;<song name>;<minutes:seconds>
                    string artistName = songInfo[0];
                    string songName = songInfo[1];
                    string[] time = songInfo[2].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                    int minutes;
                    int seconds;

                    try
                    {
                        minutes = int.Parse(time[0]);
                        seconds = int.Parse(time[1]);
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("Invalid song length."); // NB!
                    }

                    Song song = new Song(artistName, songName, minutes, seconds);
                    playList.Add(song);
                    Console.WriteLine("Song added.");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return playList;
        }
    }
}
