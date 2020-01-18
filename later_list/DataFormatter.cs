using later_list.Handlers;
using later_list.Models;

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
            FormatHandler.SplitExistedDataWithTwoParams(getExistedData, 
                                                        out string namePart, out string genrePart);
            MovieModel currentMovieData = new MovieModel(namePart, genrePart);
            return currentMovieData;
        }

        public static SerieModel SerieExistedDataFormatter(string getExistedData)
        {
            FormatHandler.SplitExistedDataWithTwoParams(getExistedData, 
                                                        out string namePart, out string genrePart);
            SerieModel currentSerieData = new SerieModel(namePart, genrePart);
            return currentSerieData;
        }

        public static BookModel BookExistedDataFormatter(string getExistedData)
        {
            FormatHandler.SplitExistedDataWithThreeParams(getExistedData, 
                                                          out string namePart, out string authorPart, out string genrePart);
            BookModel currentBookData = new BookModel(namePart, authorPart, genrePart);
            return currentBookData;
        }
    }
}
