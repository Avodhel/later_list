namespace later_list
{
    public static class Refactors
    {
        /// <summary>
        /// Methods for re-arrangement data before adding to list
        /// </summary>
        
        public static string NewDataRefactorWithTwoParameters(string p1, string p2)
        {
            return p1 + " (" + p2 + ")";
        }

        public static string NewDataRefactorWithThreeParameters(string p1, string p2, string p3)
        {
            return p1 + " - " + p2 + " (" + p3 + ")";
        }

        /// <summary>
        /// Methods for re-arrangement existed data before editing and adding to list 
        /// </summary>
        
        public static void ExistedDataRefactorWithTwoParameters(string getExistedData, out string namePart, out string genrePart)
        {
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
        }

        public static void ExistedDataRefactorWithThreeParameters(string getExistedData, out string namePart, out string authorPart, out string genrePart)
        {
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
        }
    }
}
