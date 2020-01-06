namespace later_list
{
    public class MovieModel : IModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        public MovieModel(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
    }
}
