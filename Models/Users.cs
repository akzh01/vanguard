using System;
using System.ComponentModel.DataAnnotations;

namespace Vanguard.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

    }
  
}
