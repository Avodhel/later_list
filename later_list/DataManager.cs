using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace later_list
{
    public static class DataManager
    {
        private static string[] movieGenres = {"Action",
                                 "Adventure",
                                 "Animation",
                                 "Biography",
                                 "Comedy",
                                 "Crime",
                                 "Documentary",
                                 "Drama",
                                 "Family",
                                 "Fantasy",
                                 "Film Noir",
                                 "History",
                                 "Horror",
                                 "Music",
                                 "Musical",
                                 "Mystery",
                                 "Romance",
                                 "Sci-Fi",
                                 "Short",
                                 "Sitcom",
                                 "Sport",
                                 "Superhero",
                                 "Thriller",
                                 "War",
                                 "Western"};
        private static string[] serieGenres = {"Action",
                                 "Adventure",
                                 "Animation",
                                 "Biography",
                                 "Comedy",
                                 "Crime",
                                 "Documentary",
                                 "Drama",
                                 "Family",
                                 "Fantasy",
                                 "Film Noir",
                                 "History",
                                 "Horror",
                                 "Music",
                                 "Musical",
                                 "Mystery",
                                 "Romance",
                                 "Sci-Fi",
                                 "Short",
                                 "Sitcom",
                                 "Sport",
                                 "Superhero",
                                 "Thriller",
                                 "War",
                                 "Western"};
        private static string[] bookGenres = {"Action and Adventure",
                                "Anthology",
                                "Biography/Autobiography",
                                "Classic",
                                "Comic and Graphic Novel",
                                "Crime and Detective",
                                "Drama",
                                "Essay",
                                "Fable",
                                "Fairy Tale",
                                "Fan-Fiction",
                                "Fantasy",
                                "Historical Fiction",
                                "Horror",
                                "Humor",
                                "Legend",
                                "Magical Realism",
                                "Memoir",
                                "Mystery",
                                "Mythology",
                                "Narrative Nonfiction",
                                "Periodicals",
                                "Realistic Fiction",
                                "Reference Books",
                                "Romance",
                                "Satire",
                                "Self-help Book",
                                "Sci-Fi",
                                "Short Story",
                                "Speech",
                                "Suspense/Thriller",
                                "Textbook",
                                "Poetry"};

        public static string[] GetGenreList(string whichSection)
        {
            if (whichSection == "movie")
            {
                return movieGenres;
            }
            else if (whichSection == "serie")
            {
                return serieGenres;
            }
            else if (whichSection == "book")
            {
                return bookGenres;
            }
            return null;
        }
    }
}
