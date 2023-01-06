namespace ASP_Project.Models.DTOModels
{
    public class DTOComics
    {
        public string ComicsName { get; set; } = string.Empty;

        public string ComicsDescription { get; set; } = string.Empty;

        public int ComicsPrice { get; set; }

        public string ComicsType { get; set; } = string.Empty;

        public ComicStore ComicStore { get; set; } = new ComicStore();
    }
}
