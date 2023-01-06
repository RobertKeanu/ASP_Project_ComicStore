namespace ASP_Project.Models.DTOModels
{
    public class DTOComicStore
    {
        public string ComicStoreName { get; set; } = string.Empty;

        public Location Location { get; set; } = new Location();
    }
}
