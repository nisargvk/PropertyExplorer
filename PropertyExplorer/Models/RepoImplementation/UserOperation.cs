using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    public class UserOperation : IUserRepository
    {
        private PropertyExplorerDBContext context;
        public UserOperation(PropertyExplorerDBContext context)
        {
            this.context = context;
        }
        public void Add(User user)
        {
            context.user.Add(user);
            context.SaveChanges();
        }

        public User GetAnUser(User user)
        {
            return context.user.Where(u => u.Username == user.Username && u.UserType == user.UserType).FirstOrDefault();

        }
        public User GetUserById(int Id)
        {
            return context.user.Find(Id);
        }
    }
}
