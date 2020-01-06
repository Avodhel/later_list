namespace later_list
{
    public static class DataRefactor
    {
        /// <summary>
        /// Re-arrangement data according to section before adding to list
        /// </summary>

        public static string MovieNewDataRefactor(MovieModel newMovieData)
        {
            return Refactors.NewDataRefactorWithTwoParameters(newMovieData.Name, newMovieData.Genre);
        }

        public static string SerieNewDataRefactor(SerieModel newSerieData)
        {
            return Refactors.NewDataRefactorWithTwoParameters(newSerieData.Name, newSerieData.Genre);
        }

        public static string BookNewDataRefactor(BookModel newBookData)
        {
            return Refactors.NewDataRefactorWithThreeParameters(newBookData.Name, newBookData.Author, newBookData.Genre);
        }

        /// <summary>
        /// Re-arrangement data according to section before editing and adding to list
        /// </summary>

        public static MovieModel MovieExistedDataRefactor(string getExistedData)
        {
            string namePart, genrePart;
            Refactors.ExistedDataRefactorWithTwoParameters(getExistedData, out namePart, out genrePart);

            MovieModel currentMovieData = new MovieModel
            {
                Name = namePart,
                Genre = genrePart
            };

            return currentMovieData;
        }

        public static SerieModel SerieExistedDataRefactor(string getExistedData)
        {
            string namePart, genrePart;
            Refactors.ExistedDataRefactorWithTwoParameters(getExistedData, out namePart, out genrePart);

            SerieModel currentSerieData = new SerieModel
            {
                Name = namePart,
                Genre = genrePart
            };

            return currentSerieData;
        }

        public static BookModel BookExistedDataRefactor(string getExistedData)
        {
            string namePart, authorPart, genrePart;
            Refactors.ExistedDataRefactorWithThreeParameters(getExistedData, out namePart, out authorPart, out genrePart);

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
