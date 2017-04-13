using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthTest.Models
{
    public class UserModel
    {
        [Required]
        public string Account { get; set; }

        [Display(Name = "User Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}