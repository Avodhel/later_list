namespace later_list
{
    public class MovieModel
    {
        public string Name { get; private set; }
        public string Genre { get; private set; }

        public MovieModel(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
    }
}
