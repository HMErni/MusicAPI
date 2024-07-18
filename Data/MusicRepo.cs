using MusicAPI.Models;

namespace MusicAPI.Data{
    public class MusicRepo : IMusicRepo
    {
        private readonly MusicContext _context;

        public MusicRepo(MusicContext context){
            _context = context;
        }

        public IEnumerable<Music> GetAllMusic()
        {
            return _context.Musics.ToList();
        }

        public Music GetById(int id)
        {
            return _context.Musics.FirstOrDefault(p => p.Id == id);
        }
        
        public void CreateMusic(Music music)
        {
            if (music == null)
                throw new ArgumentNullException(nameof(music));

            _context.Musics.Add(music);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}