using MusicAPI.Models;

namespace MusicAPI.Data
{
    public interface IMusicRepo
    {
        bool SaveChanges();

        IEnumerable<Music> GetAll();

        Music GetById(int id);

        void CreateMusic(Music music);

        void UpdateMusic(Music music);

        void DeleteMusic(int id);

    }
}