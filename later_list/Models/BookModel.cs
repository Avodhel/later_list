namespace later_list
{
    public class BookModel : IModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public BookModel(string name, string author, string genre)
        {
            Name = name;
            Author = author;
            Genre = genre;
        }
    }
}
