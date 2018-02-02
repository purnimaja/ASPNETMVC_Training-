using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Users
    {
        [Required(ErrorMessage ="Username not specified")]
        public string username { get; set; }

        [Required(ErrorMessage ="Password not specified")]
        public string password { get; set; }

        
    }
}