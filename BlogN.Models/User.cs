using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogN.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? FullName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool Confirmation { get; set; }
        [NotMapped]
        public string Token { get; set; }
    }
}
