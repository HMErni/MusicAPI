using AutoMapper;
using MusicAPI.DTOs;
using MusicAPI.Models;

namespace MusicAPI.Profiles
{
    public class MusicProfile : Profile
    {
        public MusicProfile(){
            CreateMap<Music, MusicReadDTO>();
            CreateMap<MusciCreateDTO, Music>();
        }
    }
}