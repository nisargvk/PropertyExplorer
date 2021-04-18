using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    public class FavouriteListOperation: IFavouriteProperty
    {
        private PropertyExplorerDBContext context;
        public FavouriteListOperation(PropertyExplorerDBContext context)
        {
            this.context = context;
        }

        public void Add(int userId, int propertyId)
        {
            FavouriteList fa = new FavouriteList();
            fa.UserId = userId;
            fa.HomeListingID = propertyId;
            context.favt.Add(fa);
            context.SaveChanges();
        }

        public void Delete(FavouriteList fList)
        {
            context.favt.Remove(fList);
            context.SaveChanges();
        }

        public IEnumerable<FavouriteList> GetAllFavtProperty()
        {
            return context.favt.ToList();
        }

        public IEnumerable<FavouriteList> GetByUserId(int userId)
        {
            return context.favt.Where(f => f.UserId == userId).ToList();
        }
    }
}
