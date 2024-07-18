using MusicAPI.Models;

namespace MusicAPI.Data
{
    public interface IMusicRepo
    {
        bool SaveChanges();

        IEnumerable<Music> GetAllMusic();

        Music GetById(int id);

        void CreateMusic(Music music);


    }
}