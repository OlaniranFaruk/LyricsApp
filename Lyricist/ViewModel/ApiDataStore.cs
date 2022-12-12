using Lyricist.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyricist.ViewModel
{
    internal class ApiDataStore : IDataStore
    {   
        Music Mock1 = new Music("team", "j. cole", "rap", "Lyrics1");
        Music Mock2 = new Music("im still", "juice wrld", "rap", "lyrics2");
        Music Mock3 = new Music("Mrs. Davies", "Gucci mane", "pop", "Lyrics3"); 
        public ObservableCollection<Music> MusicList { get; set; }
        public ObservableCollection<String> GenreList { get; set; }

        private readonly String URL = "http://10.0.2.2:8080/api/lyrics";

        public ApiDataStore() {
            MusicList = new ObservableCollection<Music>();
            GenreList= new ObservableCollection<string>();
        }

     

        public async Task AddMusicAsync(Music music)
        {
            MusicList.Add(music);
        }

        public async Task DeleteMusicAsync(Music music)
        {
            MusicList.Remove(music);
        }

        public async Task GetMusicListAsync()
        {
            /*
           MusicList.Add(Mock2);
           MusicList.Add(Mock1);
           MusicList.Add(Mock3); 
           */  

            
           HttpClient client = new HttpClient();
           var response = await client.GetStringAsync(URL);
            //List<Music> list = new List<Music>();

          var list = JsonConvert.DeserializeObject<List<Music>>(response);

            MusicList.Clear();
            foreach (Music music in list)
            {
                MusicList.Add(music);
            } 
          
        }

        public int GetAmntOfMusicAvailableAsync()
        {
            
            return MusicList.Count;
        }

        public async Task GetAllUniqueGenre()
        {
            GenreList.Add("All");
            foreach (var music in MusicList)
            {
                if(!GenreList.Contains(music.Genre))
                {
                    GenreList.Add(music.Genre);
                }
            }
        }
    }
}
