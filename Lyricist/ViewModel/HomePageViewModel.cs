using Lyricist.Model;
using Lyricist.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyricist.ViewModel
{
    internal class HomePageViewModel: BaseViewModel
    {
        
        public ObservableCollection<Music> MusicList { get; set; } = new ObservableCollection<Music>();
        public ObservableCollection<string> ListOfGenre { get; set; } = new ObservableCollection<string>();
        public Music selectedMusic;

        


        async public Task  GetDataAsync()
        {
           await DataStore.GetMusicListAsync();
            MusicList = DataStore.MusicList;
        }

        async public void GetGenreListAsync()
        {
            ListOfGenre = DataStore.GenreList;
        }
        
        
    }
}
