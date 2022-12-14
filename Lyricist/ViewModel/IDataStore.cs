using Lyricist.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyricist.ViewModel
{
    public interface IDataStore
    {
        ObservableCollection<Music> MusicList { get; set; }
        public ObservableCollection<string> GenreList { get; set; }
        Task GetMusicListAsync();
        Task AddMusicAsync(Music music); 
        Task DeleteMusicAsync(Music music);
        int GetAmntOfMusicAvailableAsync();

        Task GetAllUniqueGenre();
    }
}
