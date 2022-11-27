namespace FilmApp.Entities
{
    public class Director
    {
        public int DirectorID { get; set; }
        public string DirectorName { get; set; }
        public ICollection<FilmFeatures> filmFeatures { get; set; }
        public ICollection<NextFilmFeatures> nextFilmFeatures { get; set; }
    }
}
