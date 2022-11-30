using Microsoft.AspNetCore.Mvc;

namespace LyricsAPI.Controllers;

using AutoMapper;
using LyricsAPI.dto;
using LyricsAPI.Models;
using LyricsAPI.Repositories;

[ApiController]
[Route("api/lyrics")]
public class LyricsController : ControllerBase
{
    //MockRepo _repo = new MockRepo();

    private readonly IRepo _repo;
    private readonly IMapper _map;

    public LyricsController(IRepo repo, IMapper map)
    {
        _repo = repo;
        _map = map;
      
    }

    [HttpGet]
    public ActionResult GetAllMusic() {
        return Ok(_map.Map<IEnumerable<LyricsReadDto>>(_repo.GetAllMusic()));
    }
    [HttpGet("{id}", Name="GetMusicById")]
    public ActionResult GetMusicById(int id) {
       
        return Ok(_map.Map<LyricsReadDto>(_repo.GetMusicById(id)));
    }
    [HttpPost]

    public ActionResult AddMusic(LyricsWriteDto m)
    {
        var music = _map.Map<Music>(m);

        _repo.AddMusic(music);
        _repo.SaveChanges();

        return CreatedAtRoute(nameof(GetMusicById), new {id = music.id}, music);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteMusic(int id) {
        var existingMusic = _repo.GetMusicById(id);

        if(existingMusic == null)
        {
            return NotFound();
        }
        _repo.DeleteMusic(existingMusic);
        _repo.SaveChanges();
        return Ok();
    }
}
