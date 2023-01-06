namespace ASP_Project.Models.DTOModels
{
    public class DTOBuyMagazineReq
    {
        public string Title { get; set; } = string.Empty;

        public int Price { get; set; } = 0;

        public string BuyDate { get; set; } = string.Empty;

        public int NumberOfUnitsSold { get; set; } = default!;

    }
}
