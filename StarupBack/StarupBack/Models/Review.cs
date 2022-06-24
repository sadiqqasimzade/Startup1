using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarupBack.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Img { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public int Starts { get; set; }
        [Required]
        public string Comment { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
