namespace Cell.Models.Interfaces.Managers
{
    public interface IUserManager
    {
        bool LoginUser(string fullName, string password);
    }
}