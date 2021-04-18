using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyExplorer.Models
{

    [Table("FavouriteList")]
    public class FavouriteList
    {
        [Key]
        public int Id { get; set; }
        [Column("UserId")]
        public int UserId { get; set; }

        [Column("HomeListingID")]
        public int HomeListingID { get; set; }
    }
}
