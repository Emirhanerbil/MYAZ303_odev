using System.ComponentModel.DataAnnotations;

namespace FilmApp.Entities
{
    public class NextFilmFeatures
    {

        [Key]
        public int NextFilmId { get; set; }
        public string NextFilmName { get; set; }
        public bool watched { get; set; } = false;


        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        public virtual Director Director { get; set; }
        public int DirectorID { get; set; }


    }
}
