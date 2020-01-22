using later_list.Data;
using later_list.Models;

namespace later_list.Controllers
{
    public static class DataFormatController
    {
        /// <summary>
        /// Formatting data according to section before adding to list
        /// </summary>

        public static string NewMovieDataFormatter(MovieModel newMovieData)
        {
            return Formatter.FormatNewDataWithTwoParams(newMovieData.Name, newMovieData.Genre);
        }

        public static string NewSerieDataFormatter(SerieModel newSerieData)
        {
            return Formatter.FormatNewDataWithTwoParams(newSerieData.Name, newSerieData.Genre);
        }

        public static string NewBookDataFormatter(BookModel newBookData)
        {
            return Formatter.FormatNewDataWithThreeParams(newBookData.Name, newBookData.Author, newBookData.Genre);
        }

        /// <summary>
        /// Re-arrangement data according to section before editing and adding to list
        /// </summary>

        public static MovieModel ExistedMovieDataFormatter(string getExistedData)
        {
            Formatter.SplitExistedDataWithTwoParams(getExistedData, 
                                                        out string namePart, out string genrePart);
            MovieModel currentMovieData = new MovieModel(namePart, genrePart);
            return currentMovieData;
        }

        public static SerieModel ExistedSerieDataFormatter(string getExistedData)
        {
            Formatter.SplitExistedDataWithTwoParams(getExistedData, 
                                                        out string namePart, out string genrePart);
            SerieModel currentSerieData = new SerieModel(namePart, genrePart);
            return currentSerieData;
        }

        public static BookModel ExistedBookDataFormatter(string getExistedData)
        {
            Formatter.SplitExistedDataWithThreeParams(getExistedData, 
                                                          out string namePart, out string authorPart, out string genrePart);
            BookModel currentBookData = new BookModel(namePart, authorPart, genrePart);
            return currentBookData;
        }
    }
}
