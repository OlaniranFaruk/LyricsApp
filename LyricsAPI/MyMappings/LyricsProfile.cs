using AutoMapper;
using LyricsAPI.dto;
using LyricsAPI.Models;

namespace LyricsAPI.MyMappings
{
    public class LyricsProfile:Profile
    {
        public LyricsProfile()
        {
            CreateMap<Music, LyricsReadDto>();
            CreateMap<LyricsWriteDto, Music>();
        }
    }
}