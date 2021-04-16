using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    public class FavouriteListOperation: IFavouriteProperty
    {
        private PropertyExplorerDBContext context;

        public void Add(int userId, int propertyId)
        {
            FavouriteList fa = new FavouriteList();
            fa.UserId = userId;
            fa.HomeListingID = propertyId;
            context.favourite.Add(fa);
            context.SaveChanges();
        }

        public void Delete(FavouriteList fList)
        {
            context.favourite.Remove(fList);
            context.SaveChanges();
        }

        public IEnumerable<FavouriteList> GetAllFavtProperty()
        {
            return context.favourite.ToList();
        }

        public IEnumerable<FavouriteList> GetByUserId(int userId)
        {
            return context.favourite.Where(f => f.UserId == userId).ToList();
        }
    }
}
