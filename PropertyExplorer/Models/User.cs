using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PropertyExplorer.Models
{
    public class User
    {

        
        public int Id { get; set; }
       
        [Required(ErrorMessage = "UserName Required")]
        public string Username { get; set; }

      
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

       
        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Write valid Email")]
        public string Email { get; set; }

      
        [Required(ErrorMessage = "Phone Required")]
        [Phone(ErrorMessage = "Write valid Phone Number")]
        public string Phone { get; set; }


        [ForeignKey("UserType")]
        public int UserType { get; set; }


    }
}

