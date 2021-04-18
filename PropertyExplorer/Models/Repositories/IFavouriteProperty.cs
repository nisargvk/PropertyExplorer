using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    public interface IFavouriteProperty
    {
        
        IEnumerable<FavouriteList> GetAllFavtProperty();

        
        IEnumerable<FavouriteList> GetByUserId(int userId);
        
        void Add(int userId, int propertyId);
        
        void Delete(FavouriteList fList);
    }
}
