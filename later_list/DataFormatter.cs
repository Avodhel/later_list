namespace later_list
{
    public static class DataFormatter
    {
        /// <summary>
        /// Formatting data according to section before adding to list
        /// </summary>

        public static string MovieNewDataFormatter(MovieModel newMovieData)
        {
            return FormatHandler.FormatNewDataWithTwoParams(newMovieData.Name, newMovieData.Genre);
        }

        public static string SerieNewDataFormatter(SerieModel newSerieData)
        {
            return FormatHandler.FormatNewDataWithTwoParams(newSerieData.Name, newSerieData.Genre);
        }

        public static string BookNewDataFormatter(BookModel newBookData)
        {
            return FormatHandler.FormatNewDataWithThreeParams(newBookData.Name, newBookData.Author, newBookData.Genre);
        }

        /// <summary>
        /// Re-arrangement data according to section before editing and adding to list
        /// </summary>

        public static MovieModel MovieExistedDataFormatter(string getExistedData)
        {
            string namePart, genrePart;
            FormatHandler.SplitExistedDataWithTwoParams(getExistedData, out namePart, out genrePart);
            MovieModel currentMovieData = new MovieModel(namePart, genrePart);
            return currentMovieData;
        }

        public static SerieModel SerieExistedDataFormatter(string getExistedData)
        {
            string namePart, genrePart;
            FormatHandler.SplitExistedDataWithTwoParams(getExistedData, out namePart, out genrePart);
            SerieModel currentSerieData = new SerieModel(namePart, genrePart);
            return currentSerieData;
        }

        public static BookModel BookExistedDataFormatter(string getExistedData)
        {
            string namePart, authorPart, genrePart;
            FormatHandler.SplitExistedDataWithThreeParams(getExistedData, out namePart, out authorPart, out genrePart);
            BookModel currentBookData = new BookModel(namePart, authorPart, genrePart);
            return currentBookData;
        }
    }
}
