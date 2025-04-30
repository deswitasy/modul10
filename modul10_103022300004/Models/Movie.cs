namespace modul10_103022300004.Models
{
    public class Movie
    {
        public string title { get; set; }
        public string Director { get; set; }
        public List<string> stars { get; set; }
        public string Description { get; set; }

        public Movie (string title, string director, List<string> stars, string description)
        {
            this.title = title;
            Director = director;
            this.stars = stars;
            Description = description;
        }
    }
}
