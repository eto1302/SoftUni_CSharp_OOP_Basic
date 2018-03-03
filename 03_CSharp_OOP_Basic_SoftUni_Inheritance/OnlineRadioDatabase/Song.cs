using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


class Song
{
    public string artist;
    public string title;
    public string length;

    public string Artist
    {
        get
        {
            return this.artist;
        }
        set
        {
            if (value.Length < 3 || value.Length > 20) throw new InvalidArtistNameException();
            else this.artist = value;
        }
    }
    public string Title
    {
        get
        {
            return this.title;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30) throw new InvalidSongNameException();
            else this.title = value;
        }
    }
    public string Length
    {
        get
        {
            return this.artist;
        }
        set
        {
            Regex regex = new Regex(@"^\d+:\d+");
            if (!regex.IsMatch(value))
            {
                throw new InvalidSongLengthException();
            }
            var minutes = int.Parse(value.Split(':')[0]);
            var seconds = int.Parse(value.Split(':')[1]);
            if (minutes < 0 || minutes > 14)
            {
                throw new InvalidSongMinuteException();
            }
            if (seconds < 0 || seconds > 59)
            {
                throw new InvalidSongSecondsException();
            }
            this.length = value;

        }
    }

    public Song(string artist, string title, string length)
    {
        this.Artist = artist;
        this.Title = title;
        this.Length = length;
    }
}
