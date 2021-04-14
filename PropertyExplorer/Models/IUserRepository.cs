using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    public interface IUserRepository
    {
        User GetAnUser(User user);
        User GetUserById(int Id);
        void Add(User user);
    }
}
