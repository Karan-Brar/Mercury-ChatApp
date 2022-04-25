using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MercuryOne.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        [Required]
        public string MessageText { get; set; }
        public DateTime TimeSent { get; set; }

        public AppUser AppUser { get; set; }
    }
}
