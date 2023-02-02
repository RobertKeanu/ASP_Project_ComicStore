namespace ASP_Project.Models.DTOModels
{
    public class DTOUserResponse
    {
        public Guid Id { get; set; }
        public required string UserName { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public DTOUserResponse (User user , string token)
        {
            Id = user.Id;
            UserName = user.FirstName;
            Email = user.Email;
            /*Token = token;*/ // for auth
        }

    }
}
