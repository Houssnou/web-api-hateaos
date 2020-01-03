using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_hateoas.Models
{
    public class Movie
    {
        [Key]
        public Guid MovieId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }
        [Required]
        public DateTimeOffset ReleaseDate { get; set; }
        [Required]
        public Guid DirectorId { get; set; }
        public ICollection<Trailer> Trailers { get; set; }
        public ICollection<Poster> Posters { get; set; }
    }
}
