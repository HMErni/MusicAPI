using MusicAPI.Models;

namespace MusicAPI.Data{
    public interface IAlbumRepo
    {
        bool SaveChanges();
        IEnumerable<Album> GetAllAlbums();
        Album GetAlbumById(int id);
        void Add(Album album);
        void Update(Album album);
        void Delete(Album album);
    }
}