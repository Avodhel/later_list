namespace later_list
{
    public static class DataRefactor
    {
        public static string MovieAddDataRefactor(MovieModel newMovieData)
        {
            return newMovieData.Name + " (" + newMovieData.Genre + ")";
        }

        public static string SerieAddDataRefactor(SerieModel newSerieData)
        {
            return newSerieData.Name + " (" + newSerieData.Genre + ")";
        }

        public static string BookAddDataRefactor(BookModel newBookData)
        {
            return newBookData.Name + " - " + newBookData.Author + " (" + newBookData.Genre + ")";
        }

        public static MovieModel MovieExistedDataRefactor(string getExistedData)
        {
            string namePart;
            string genrePart;

            namePart = getExistedData.Split('(')[0];
            namePart = namePart.TrimEnd(' ');

            try
            {
                genrePart = getExistedData.Split('(')[1];
                genrePart = genrePart.TrimEnd(')');
            }
            catch
            {
                genrePart = string.Empty;
            }

            MovieModel currentMovieData = new MovieModel
            {
                Name = namePart,
                Genre = genrePart
            };

            return currentMovieData;
        }


        public static SerieModel SerieExistedDataRefactor(string getExistedData)
        {
            string namePart;
            string genrePart;

            namePart = getExistedData.Split('(')[0];
            namePart = namePart.TrimEnd(' ');

            try
            {
                genrePart = getExistedData.Split('(')[1];
                genrePart = genrePart.TrimEnd(')');
            }
            catch
            {
                genrePart = string.Empty;
            }

            SerieModel currentSerieData = new SerieModel
            {
                Name = namePart,
                Genre = genrePart
            };

            return currentSerieData;
        }

        public static BookModel BookExistedDataRefactor(string getExistedData)
        {
            string namePart;
            string authorPart;
            string genrePart;


            namePart = getExistedData.Split('-')[0];
            authorPart = getExistedData.Split('-')[1];
            authorPart = authorPart.TrimStart(' ');
            namePart = namePart.TrimEnd(' ');

            try
            {
                authorPart = authorPart.Split('(')[0];
                authorPart = authorPart.TrimEnd(' ');
            }
            catch
            {
                authorPart = string.Empty;
            }

            try
            {
                genrePart = getExistedData.Split('(')[1];
                genrePart = genrePart.TrimEnd(')');
            }
            catch
            {
                genrePart = string.Empty;
            }

            BookModel currentBookData = new BookModel
            {
                Name = namePart,
                Author = authorPart,
                Genre = genrePart
            };

            return currentBookData;
        }
    }
}
