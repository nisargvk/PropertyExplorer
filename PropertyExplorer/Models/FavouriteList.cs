using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    public class FavouriteList
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> HomeListingID { get; set; }
    }
}
