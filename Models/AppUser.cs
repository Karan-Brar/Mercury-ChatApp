using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MercuryOne.Models
{
    public class AppUser
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }

        public List<Message> Messages { get; } = new();
    }
}
