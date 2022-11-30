using LyricsAPI.Models;
using LyricsAPI.Contexts;
using LyricsAPI.Repositories;

namespace LyricsAPI.Repositories
{
    public class MySqlRepo : IRepo
    {
        private readonly LyricsContext _context;
        public MySqlRepo(LyricsContext context)
        {
            _context = context;
        }

        public void AddMusic(Music m)
        {
            _context.music.Add(m);
        }

        public void DeleteMusic(Music m)
        {
            _context.music.Remove(m);
        }

        public IEnumerable<Music> GetAllMusic()
        {   
            return _context.music;
        }

        public Music GetMusicById(int id)
        {
            return _context.music.FirstOrDefault<Music>(m => m.id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
    
}