using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.CodeAnalysis;

namespace ASP_Project.Models.DTOModels
{
    public class DTOUserResponse
    {
        public Guid Id { get; set; }
        public required string UserName { get; set; }

        public required string Email { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Preferences { get; set; }

        public string Token { get; set; }


        [SetsRequiredMembers]
        public DTOUserResponse (User user , string token)
        {
            Id = user.Id;
            UserName = user.FirstName;
            Email = user.Email;
            PhoneNumber= user.PhoneNumber;
            Preferences = user.Preferences;
            Token = token;
        }

    }
}
