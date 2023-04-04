using Api_Shop.Models;
using System.Collections.Generic;
using System.Linq;

namespace Api_Shop.Repositories
{
    public static class UseRepository
    {
        public static User Get(string username, string password)
        {
            var user = new List<User>();
            user.Add(new User { Id = 1, UserName = "batman", Password = "batman", Role = "manager" });
            user.Add(new User { Id = 2, UserName = "robin", Password = "robin", Role = "employee" });
            return user.Where(x => x.UserName.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}
