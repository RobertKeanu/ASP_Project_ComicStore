namespace ASP_Project.Models.DTOModels
{
    public class DTORent
    {
        public string Title { get; set; } = string.Empty;

        public string DateStart { get; set; } = string.Empty;

        public string DateEnd { get; set; } = string.Empty;

        public int PricePerDay { get; set; } = 5;

        public Comics Comic { get; set; } = new Comics();

        public User NewUser { get; set; } = new User();
    }
}
