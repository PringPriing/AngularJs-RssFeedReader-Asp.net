using RssReader.Data.Repositories;
using RssReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Data.Extensions
{
    public static class UserExtension
    {
        public static User GetSingleByUsername(this IEntityBaseRepository<User> userRepository, string username)
        {
            return userRepository.GetAll().FirstOrDefault(u => u.UserName == username);
        }
    }
}
