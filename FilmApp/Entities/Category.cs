namespace FilmApp.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<FilmFeatures> filmFeatures { get; set; }
        public ICollection<NextFilmFeatures> nextFilmFeatures { get; set; }
    }
}
