using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyExplorer.Models
{
    
    public class HomeListing
    {

        
        public int Id { get; set; }

       
        [Required(ErrorMessage = "Home Type is Required")]
        public string HomeType { get; set; }

        
        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

       
        [Required(ErrorMessage = "City Name is Required")]
        public string City { get; set; }

        
        [Required(ErrorMessage = "Price is Required")]
        public int Price { get; set; }

       
        [Required(ErrorMessage = "Home Size is Required")]
        public string HomeSize { get; set; }

       
        [Required(ErrorMessage = "Summary is Required")]
        public string Summary { get; set; }

       
        public int AgentId { get; set; }
    }
}
