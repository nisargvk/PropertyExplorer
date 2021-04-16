using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PropertyExplorer.Models
{
    public class User
    {

        
        public int Id { get; set; }
       
        [Required(ErrorMessage = "User Name is Required")]
        public string Username { get; set; }

      
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

       
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Write valid Email")]
        public string Email { get; set; }

      
        [Required(ErrorMessage = "Phone is Required")]
        [Phone(ErrorMessage = "Write valid Phone Number")]
        public string Phone { get; set; }


        [ForeignKey("UserType")]
        public int UserType { get; set; }






    }
}

}
