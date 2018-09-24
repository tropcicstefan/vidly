using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }
        [Required]
        public DateTime ReleaseDateTime { get; set; }
        [Required]
        public DateTime AddedDateTime { get; set; }
        [Required]
        public int NoInStock { get; set; }

    }
}