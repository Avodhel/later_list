namespace later_list.Models
{
    public class BookModel
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }

        public BookModel(string name, string author, string genre)
        {
            Name = name;
            Author = author;
            Genre = genre;
        }
    }
}
