namespace later_list
{
    public class SettingsViewHandler : IViewHandler
    {
        private readonly SettingsForm settingsForm;

        public SettingsViewHandler(SettingsForm _settingsForm)
        {
            settingsForm = _settingsForm;
        }

        #region Theme

        public void ThemeChanged()
        {
            if (settingsForm.LightThemeCheck)
            {
                ThemeHandler.SetAllThemeColors(Colors.LightThemeBackgroundColor,
                                               Colors.DarkThemeTextColor,
                                               Colors.DarkThemeTextColor);
                if (Properties.Settings.Default.dark_checked == true)
                {
                    settingsForm.SaveSettingsButton.Enabled = true;
                }
            }
            else if (settingsForm.DarkThemeCheck)
            {
                ThemeHandler.SetAllThemeColors(Colors.DarkThemeBackgroundColor,
                                               Colors.LightThemeTextColor,
                                               Colors.DarkThemeTextColor);
                if (Properties.Settings.Default.light_checked == true)
                {
                    settingsForm.SaveSettingsButton.Enabled = true;
                }
            }
        }

        public void LoadTheme()
        {
            ThemeHandler.RegisterForm(settingsForm);
            ThemeHandler.RegisterGroupBox(settingsForm.SettingsGB);
            ThemeHandler.RegisterGroupBox(settingsForm.ThemesGB);
            ThemeHandler.RegisterTextBox(settingsForm.MovieFilePathTextBox);
            ThemeHandler.RegisterTextBox(settingsForm.SerieFilePathTextBox);
            ThemeHandler.RegisterTextBox(settingsForm.BookFilePathTextBox);
            ThemeHandler.RegisterButton(settingsForm.SaveSettingsButton);
        }

        #endregion
    }
}
