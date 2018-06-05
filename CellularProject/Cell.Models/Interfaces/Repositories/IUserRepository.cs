namespace Cell.Models.Interfaces.Repositories
{
    public interface IUserRepository
    {
        bool LoginUser(string fullName, string password);
    }
}