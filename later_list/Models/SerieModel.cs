namespace later_list
{
    public class SerieModel : IModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        public SerieModel(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
    }
}
