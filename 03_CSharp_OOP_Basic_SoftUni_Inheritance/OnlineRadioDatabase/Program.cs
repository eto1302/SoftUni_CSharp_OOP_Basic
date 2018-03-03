using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(';');
            try
            {
                songs.Add(new Song(tokens[0],tokens[1],tokens[2]));
                Console.WriteLine("Song added.");
            }
            catch(Exception ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
        Console.WriteLine($"Songs added: {songs.Count}");
        PrintPlaylistLength(songs);
    }

    public static void PrintPlaylistLength(List<Song> songs)
    {
        var result = 0;
        foreach (var song in songs)
        {
            string[] tokens = song.length.Split(':');
            int minutes = int.Parse(tokens[0]);
            int seconds = int.Parse(tokens[1]);
            result = result + minutes * 60 + seconds;
        }
        TimeSpan timeSpan = TimeSpan.FromSeconds(result);
        Console.WriteLine($"Playlist length: {timeSpan.Hours:D1}h {timeSpan.Minutes:D1}m {timeSpan.Seconds:D1}s");
    }
}
