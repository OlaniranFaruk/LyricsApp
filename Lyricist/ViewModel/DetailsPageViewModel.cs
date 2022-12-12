using Lyricist.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyricist.ViewModel
{
    internal class DetailsPageViewModel : BaseViewModel
    {
        async public void removeMusic(Music m)
        { 
            DataStore.DeleteMusicAsync(m);
        }
    }
}
