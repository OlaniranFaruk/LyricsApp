namespace LyricsAPI.Models
{
    
    public class Music
    {
        public int id {get; set;}
        public String Title { get; set; }
        public String Artist { get; set; }
        public String Genre { get; set; }
        public String Lyrics { get; set; }

        
        public Music(String title, String artist, String genre, String lyrics)
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