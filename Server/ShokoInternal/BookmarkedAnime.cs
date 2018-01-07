
namespace Shoko.Models.Server
{
    public class BookmarkedAnime
    {
        public int AnimeID { get; set; }
        public int Priority { get; set; }
        public string Notes { get; set; }
        public int Downloading { get; set; }
        public BookmarkedAnime()
        {
        }
    }
}