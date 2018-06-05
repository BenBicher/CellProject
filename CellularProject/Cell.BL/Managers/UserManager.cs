using Cell.DAL;
using Cell.Models.Interfaces.Managers;
using Cell.Models.Interfaces.Repositories;

namespace Cell.BL.Managers
{
    public class UserManager : IUserManager
    {
        private IUserRepository _userRepository;

        public UserManager()
        {
            _userRepository = new UserRepository();
        }

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public bool LoginUser(string fullName, string password)
        {
            return _userRepository.LoginUser(fullName, password);
        }
    }
}