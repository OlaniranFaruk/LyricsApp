using Lyricist.Model;
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
        public ObservableCollection<string> GenreList { get; set; }

        public ApiDataStore() {
            MusicList = new ObservableCollection<Music>();
            GenreList= new ObservableCollection<string>();
        }

        public async  Task<ObservableCollection<string>> GetAllUniqueGenre()
        {
            await GetMusicListAsync();

            for(int i=0; i < MusicList.Count; i++)
            {
                if (!GenreList.Contains(MusicList[i].Genre) )
                {
                    GenreList.Add(MusicList[i].Genre);  
                }
            }

            return GenreList;
        }

        public async Task AddMusicAsync(Music music)
        {
            MusicList.Add(music);
        }

        public async Task DeleteMusicAsync(Music music)
        {
            throw new NotImplementedException();
        }

        public async Task GetMusicListAsync()
        {
            MusicList.Add(Mock2);
            MusicList.Add(Mock1);
            MusicList.Add(Mock3);
        }
    }
}
