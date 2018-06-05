using Cell.Models.Entities;
using Cell.Models.Interfaces.Repositories;
using Cell.DAL.Helpers;
using System.Linq;

namespace Cell.DAL
{
    public class UserRepository : IUserRepository
    {
        public bool LoginUser(string fullName, string password)
        {
            using (var db = new CellDbContext())
            {
                if (!db.Users.Any())
                {
                    UserDb _user = new UserDb()
                    {
                        Id = 0,
                        FullName = "admin",
                        Password = "admin"
                    };
                    _user.ToDTO();
                    db.Users.Add(_user);
                    db.SaveChanges();
                }
                if (db.Users.Select(a => a.FullName == fullName).FirstOrDefault() && 
                    db.Users.Select(a => a.Password == password).FirstOrDefault())
                    return true;

                else return false;
            }
        }
    }
}