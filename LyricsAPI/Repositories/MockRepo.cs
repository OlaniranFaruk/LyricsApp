using LyricsAPI.Models;
using System.Linq;

namespace LyricsAPI.Repositories
{
    public class MockRepo : IRepo
    {
        List<Music> MusicList = new List<Music>();

        public MockRepo()
        {
            MusicList.Add(new Music("team", "j. cole", "rap", "Lyrics1"){id = 1});
            MusicList.Add(new Music("im still", "juice wrld", "rap", "lyrics2"){id = 2});
            MusicList.Add(new Music("Mrs. Davies", "Gucci mane", "pop", "Lyrics3"){id = 3});
        }

        public void AddMusic(Music m)
        {
            MusicList.Add(m);
        }

        public void DeleteMusic(Music m)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Music> GetAllMusic(){
            return MusicList;
        }

        public Music GetMusicById(int id ){
             Music _music = MusicList.FirstOrDefault<Music>(m => m.id == id);
             return _music;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}