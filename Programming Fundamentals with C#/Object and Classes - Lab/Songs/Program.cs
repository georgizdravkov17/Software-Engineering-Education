using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfSongs = int.Parse(Console.ReadLine());


            var songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                var currentSong = Console.ReadLine().Split('_').ToArray();
                var type = currentSong[0];
                var name = currentSong[1];
                var time = currentSong[2];

                Song song = new Song(type, name, time);
                songs.Add(song);

            }

            var command = Console.ReadLine();

            if (command == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine($"{song.Name}");
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine($"{song.Name}");

                    }
                }
            }
        }
    }
}
