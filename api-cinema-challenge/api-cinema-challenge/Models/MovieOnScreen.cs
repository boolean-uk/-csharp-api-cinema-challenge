using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Models
{
    [Table("movieOnScreen")]
    [PrimaryKey("movieId","screenId" )]
    public class MovieOnScreen
    {
        [Column("movie")]
        public Movie movie {  get; set; }
        [Column("screen")]
        public Screen screen { get; set; }
        [Column("movieId")]
        public int movieId { get; set; }
        [Column("screenId")]
        public int screenId { get; set; }

    }
}
