using RssReader.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.Data.Configurations
{
    class UserRoleConfiguration : EntityBaseConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            Property(x => x.UserId).IsRequired();
            Property(x => x.RoleId).IsRequired();
        }
    }
}
