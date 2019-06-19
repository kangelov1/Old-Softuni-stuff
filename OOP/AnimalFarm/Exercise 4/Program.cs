using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var songs = GetSongs();
        PrintPlayListSummary(songs);
    }
    private static Stack<Song> GetSongs()
    {
        var numberOfSongs = int.Parse(Console.ReadLine());
        var songs = new Stack<Song>(numberOfSongs);

        while(numberOfSongs > 0)
        {
            var songDetails = Console.ReadLine().Split(';');

            try
            {
                var indexOfMinuteSecondSeparation = songDetails[2].IndexOf(':');

                if(songDetails.Length < 3 || indexOfMinuteSecondSeparation < 1 || indexOfMinuteSecondSeparation > songDetails[2].Length - 2)
                {
                    throw new InvalidSongException();
                }

                var artist = songDetails[0];
                var songName = songDetails[1];
                var minutes = int.Parse(songDetails[2].Substring(0, indexOfMinuteSecondSeparation));
                var seconds = int.Parse(songDetails[2].Substring(indexOfMinuteSecondSeparation + 1));

                songs.Push(new Song(artist, songName, minutes, seconds));
                Console.WriteLine("Song added");
            }
            catch(InvalidSongException ise)
            {
                Console.WriteLine(ise.Message);
            }
            catch(FormatException fme)
            {
                Console.WriteLine("Invalid song length");
            }
            numberOfSongs--;
        }
        return songs;
    }
    private static void PrintPlayListSummary(Stack<Song> playlist)
    {
        Console.WriteLine("Songs added {0}",playlist.Count);

        var totalSeconds = playlist.Select(x => x.Seconds).Sum();
        var secondsToMinutes = totalSeconds / 60;
        var seconds = totalSeconds % 60;


        var totalMinutes = playlist.Select(x => x.Minutes).Sum() + secondsToMinutes;
        var minutesToHours = totalMinutes / 60;
        var minutes = totalMinutes % 60;

        var hours = minutesToHours;

        Console.WriteLine("Playlist length: {0}h {1}m {2}s",hours,minutes,seconds);
    }
}

