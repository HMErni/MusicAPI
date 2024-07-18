using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicAPI.Data;
using MusicAPI.DTOs;
using MusicAPI.Models;

namespace MusicAPI.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase {
        private readonly IMusicRepo _musicRepo;
        private readonly IMapper _mapper;

        public MusicController(IMusicRepo musicRepo, IMapper mapper)
        {
            _musicRepo = musicRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<MusicReadDTO>> GetAllMusic(){
            var musicList = _musicRepo.GetAllMusic();

            return Ok(_mapper.Map<IEnumerable<MusicReadDTO>>(musicList));
        }

        [HttpGet("{id}")]
        public ActionResult <MusicReadDTO> GetMusicById(int id){

            var musicItem = _musicRepo.GetById(id);

            if (musicItem == null)
                return NotFound();

            return Ok(_mapper.Map<MusicReadDTO>(musicItem));
        }

        [HttpPost]
        public ActionResult <MusicReadDTO> CreateMusic(MusciCreateDTO musciCreateDTO){
            if (musciCreateDTO == null)
                return BadRequest();

            var musicItem = _mapper.Map<Music>(musciCreateDTO);
            _musicRepo.CreateMusic(musicItem);

            return Ok(_mapper.Map<MusicReadDTO>(musicItem));
        }

    }

}