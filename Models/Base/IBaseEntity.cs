namespace ASP_Project.Models.Base
{
    public class IBaseEntity
    {
        Guid Id { get; set; }

        DateTime DateCreated { get; set; }

        DateTime DateModified { get; set; } //maybe nullable?
    }
}
