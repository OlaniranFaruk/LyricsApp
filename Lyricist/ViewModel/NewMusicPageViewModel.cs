using Lyricist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyricist.ViewModel
{
    class NewMusicPageViewModel : BaseViewModel
    {
        public string mTitle { get; set; } = "";
        public string mArtist { get; set; } = "";
        public string mGenre { get; set; } = "";
        public string mLyrics { get; set; } = "";

        async public Task addNewMusic()
        {
            if (mTitle != "" && mArtist != "" && mGenre != "" && mLyrics != "")
            {
                DataStore.MusicList.Clear();
                Music m = new Music(mTitle, mArtist, mGenre, mLyrics);
                DataStore.AddMusicAsync(m);
                mTitle = "";
                mArtist = "";
                mGenre = "";
                mLyrics = "";
                await DataStore.GetMusicListAsync();
                await App.Current.MainPage.Navigation.PopAsync();
            }
        }
    }
}
