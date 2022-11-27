﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyricist.Model
{
    internal class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }

        public string Lyrics { get; set; }

        public Music(string title, string artist, string genre, string lyrics)
        {
            Title = title;
            Artist = "Artist: " + artist;
            Genre = "Genre: "  + genre;
            Lyrics = lyrics;
        }   
        Music()
        { }
    }
}
