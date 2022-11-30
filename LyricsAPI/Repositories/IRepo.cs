using LyricsAPI.Models;

namespace LyricsAPI.Repositories
{
    public interface IRepo
    {
        IEnumerable<Music> GetAllMusic();
        Music GetMusicById(int id);

        void AddMusic(Music m);

        void SaveChanges();

        void DeleteMusic(Music m);
    }
}