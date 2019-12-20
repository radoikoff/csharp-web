using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyPanda.Models
{
    public class User
    {
        public string Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Package> Packages { get; set; }

        public ICollection<Receipt> Receipts { get; set; }
    }
}
