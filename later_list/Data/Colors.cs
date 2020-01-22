using System.Drawing;

namespace later_list.Data
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

        public static Color OptionButtonsDeactiveColor
        {
            get { return SystemColors.InactiveCaption; }
        }

        public static Color AddButtonActiveColor
        {
            get { return Color.PaleGreen; }
        }

        public static Color EditButtonActiveColor
        {
            get { return Color.Yellow; }
        }

        public static Color RemoveButtonActiveColor
        {
            get { return Color.Salmon; }
        }

        public static Color SaveListButtonActiveColor
        {
            get { return Color.FromArgb(255, 128, 0); }
        }

        public static Color ClearButtonActiveColor
        {
            get { return Color.Thistle; }
        }

        public static Color SaveSettingsButtonActiveColor
        {
            get { return SystemColors.Highlight; }
        }
    }
}
