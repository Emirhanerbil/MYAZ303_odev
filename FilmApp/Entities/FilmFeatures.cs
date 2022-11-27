using System.ComponentModel.DataAnnotations;

namespace FilmApp.Entities
{
    public class FilmFeatures
    {
        [Key]
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public bool watched { get; set; } = false;
        public string FilmComment { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int DirectorID { get; set; }
        public virtual Director Director { get; set; }
    }
}
