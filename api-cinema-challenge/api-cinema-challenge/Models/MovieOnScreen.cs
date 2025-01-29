using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Models
{
    [Table("movieOnScreen")]
    [PrimaryKey("movieId","screenId" )]
    public class MovieOnScreen
    {
        [NotMapped]
        public virtual Movie movie {  get; set; }
        [NotMapped]
        public virtual Screen screen { get; set; }
        [Column("movieId")]
        public int movieId { get; set; }
        [Column("screenId")]
        public int screenId { get; set; }

    }
}
