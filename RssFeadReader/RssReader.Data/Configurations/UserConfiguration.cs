using RssReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Data.Configurations
{
    class UserConfiguration :EntityBaseConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.UserName).IsRequired().HasMaxLength(100);
            Property(x => x.Email).IsRequired().HasMaxLength(200);
            Property(x => x.HashedPassword).IsRequired().HasMaxLength(200);
            Property(x => x.Salt).IsRequired().HasMaxLength(200);
            Property(x => x.IsLocked).IsRequired();
            Property(x => x.DateCreated);
        }
    }
}
