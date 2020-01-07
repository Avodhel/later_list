using System.Drawing;

namespace later_list
{
    public static class Colors
    {
        public static Color LightThemeBackgroundColor
        {
            get { return Color.FromArgb(242, 242, 242); }
        }

        public static Color DarkThemeBackgroundColor
        {
            get { return Color.FromArgb(51, 51, 51); }
        }

        public static Color LightThemeTextColor
        {
            get { return Color.FromArgb(242, 242, 242); }
        }

        public static Color DarkThemeTextColor
        {
            get { return Color.FromArgb(31, 31, 31); }
        }

        public static Color SectionButtonActiveColor
        {
            get { return SystemColors.ButtonFace; }
        }

        public static Color SectionButtonDeactiveColor
        {
            get { return SystemColors.Highlight; }
        }
    }
}
