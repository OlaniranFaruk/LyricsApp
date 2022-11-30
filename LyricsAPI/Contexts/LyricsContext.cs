
using LyricsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LyricsAPI.Contexts
{
    public class LyricsContext: DbContext
    {

        public LyricsContext(DbContextOptions<LyricsContext> opt): base(opt)
        {
            
        }
        public DbSet<Music> music{get; set;}
    }
}