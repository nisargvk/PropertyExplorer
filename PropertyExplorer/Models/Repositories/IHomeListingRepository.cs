using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    public interface IHomeListingRepository
    {
        HomeListing GetAHomeListing(int id);

        IEnumerable<HomeListing> GetHomeListings();

        void Add(HomeListing homeListing);

        void Update(HomeListing changeHome);

        void Delete(HomeListing homeListing);

        IEnumerable<HomeListing> GetHomeListingsByAgentBy(int id);
    }
}
