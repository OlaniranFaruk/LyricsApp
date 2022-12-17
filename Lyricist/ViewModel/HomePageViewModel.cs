using Lyricist.Model;
using Lyricist.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lyricist.ViewModel
{
    public  class HomePageViewModel: BaseViewModel
    {
        
        public ObservableCollection<Music> MusicList { get; set; } = new ObservableCollection<Music>();
        public ObservableCollection<String> ListOfGenre { get; set; } = new ObservableCollection<String>();
        public Music selectedMusic;
        public Command RefreshAsync { get; set; }

        public async void RefreshAsyncFunc()
        {
            IsBusy = true;
            await GetDataAsync();
            await GetGenreListAsync();
            IsBusy = false;
        }

        async public Task  GetDataAsync()
        {
           await DataStore.GetMusicListAsync();
            MusicList = DataStore.MusicList;
        }

        async public Task GetGenreListAsync()
        {
            await DataStore.GetAllUniqueGenre();
            ListOfGenre = DataStore.GenreList;
        }
        
        
    }
}
