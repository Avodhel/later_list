using later_list.Interfaces;

namespace later_list.Handlers
{
    public class SettingsViewHandler : IViewHandler
    {
        private readonly SettingsForm settingsForm;

        #region Constructor

        public SettingsViewHandler(SettingsForm _settingsForm)
        {
            settingsForm = _settingsForm;
        }

        #endregion

        #region Button Active/Deactive

        public void SaveSettingsButtonActive()
        {
            settingsForm.SaveSettingsButton.Enabled = true;
            settingsForm.SaveSettingsButton.BackColor = Colors.SaveSettingsButtonActiveColor;
        }

        public void SaveSettingsButtonDeactive()
        {
            settingsForm.SaveSettingsButton.Enabled = false;
            settingsForm.SaveSettingsButton.BackColor = Colors.OptionButtonsDeactiveColor;
        }

        #endregion

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
                    SaveSettingsButtonActive();
                }
            }
            else if (settingsForm.DarkThemeCheck)
            {
                ThemeHandler.SetAllThemeColors(Colors.DarkThemeBackgroundColor,
                                               Colors.LightThemeTextColor,
                                               Colors.DarkThemeTextColor);
                if (Properties.Settings.Default.light_checked == true)
                {
                    SaveSettingsButtonActive();
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
