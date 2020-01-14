namespace later_list
{
    public static class FormatHandler
    {
        /// <summary>
        /// Methods for formatting data before adding to list
        /// </summary>

        public static string FormatNewDataWithTwoParams(string p1, string p2)
        {
            string strFormat = "{0, -35}{1, -10}";
            return string.Format(strFormat, p1, "(" + p2 + ")");
        }

        public static string FormatNewDataWithThreeParams(string p1, string p2, string p3)
        {
            string strFormat = "{0, -20}{1, -20}{2, -10}";
            return string.Format(strFormat, p1, " - " + p2, "(" + p3 + ")");
        }

        /// <summary>
        /// Methods for re-arrangement existed data before editing and adding to list 
        /// </summary>

        public static void SplitExistedDataWithTwoParams(string getExistedData, out string namePart, out string genrePart)
        {
            namePart = getExistedData.Split('(')[0];
            namePart = namePart.TrimEnd(' ');

            try
            {
                genrePart = getExistedData.Split('(')[1];
                genrePart = genrePart.TrimEnd(' ');
                genrePart = genrePart.TrimEnd(')');
            }
            catch
            {
                genrePart = string.Empty;
            }
        }

        public static void SplitExistedDataWithThreeParams(string getExistedData, out string namePart, out string authorPart, out string genrePart)
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
                genrePart = genrePart.TrimEnd(' ');
                genrePart = genrePart.TrimEnd(')');
            }
            catch
            {
                genrePart = string.Empty;
            }
        }
    }
}
