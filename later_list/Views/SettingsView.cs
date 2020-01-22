using later_list.Data;
using later_list.Controllers;
using later_list.Interfaces;

namespace later_list.Views
{
    public class SettingsView : IView
    {
        private readonly SettingsForm settingsForm;

        #region Constructor

        public SettingsView(SettingsForm _settingsForm)
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
                ThemeController.SetAllThemeColors(Colors.LightThemeBackgroundColor,
                                               Colors.DarkThemeTextColor,
                                               Colors.DarkThemeTextColor);
                if (Properties.Settings.Default.dark_checked == true)
                {
                    SaveSettingsButtonActive();
                }
            }
            else if (settingsForm.DarkThemeCheck)
            {
                ThemeController.SetAllThemeColors(Colors.DarkThemeBackgroundColor,
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
            ThemeController.RegisterForm(settingsForm);
            ThemeController.RegisterGroupBox(settingsForm.SettingsGB);
            ThemeController.RegisterGroupBox(settingsForm.ThemesGB);
            ThemeController.RegisterTextBox(settingsForm.MovieFilePathTextBox);
            ThemeController.RegisterTextBox(settingsForm.SerieFilePathTextBox);
            ThemeController.RegisterTextBox(settingsForm.BookFilePathTextBox);
            ThemeController.RegisterButton(settingsForm.SaveSettingsButton);
        }

        #endregion
    }
}
