using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace later_list
{
    public partial class SettingsForm : Form
    {
        #region variables
        private string fileName;
        private string filePath;

        public Color lightThemeBackgroundColor = Color.FromArgb(242,242,242);
        public Color darkThemeBackgroundColor = Color.FromArgb(51,51,51);
        public Color lightThemeTextColor = Color.FromArgb(242,242,242);
        public Color darkThemeTextColor = Color.FromArgb(31, 31, 31);

        public string MovieFilePathText
        {
            get { return movie_path_tb.Text; }
            set { movie_path_tb.Text = value; }
        }

        public string SerieFilePathText
        {
            get { return serie_path_tb.Text; }
            set { serie_path_tb.Text = value; }
        }

        public string BookFilePathText
        {
            get { return book_path_tb.Text; }
            set { book_path_tb.Text = value; }
        }

        public bool LightThemeCheck
        {
            get { return light_rb.Checked; }
            set { light_rb.Checked = value; }
        }

        public bool DarkThemeCheck
        {
            get { return dark_rb.Checked; }
            set { dark_rb.Checked = value; }
        }
        #endregion 

        #region settings opened
        public SettingsForm()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            LoadTheme();
        }

        private Form mainForm = null;
        public SettingsForm(Form settings)
        {
            mainForm = settings as SettingsForm;
            InitializeComponent();
        }

        private void SettingsLoad(object sender, EventArgs e)
        {
            //LoadTheme();
        }

        public void LoadTheme()
        {
            ThemeManager.RegisterForm(this);
            ThemeManager.RegisterGroupBox(settings_gb);
            ThemeManager.RegisterGroupBox(themes_gb);
            ThemeManager.RegisterTextBox(movie_path_tb);
            ThemeManager.RegisterTextBox(serie_path_tb);
            ThemeManager.RegisterTextBox(book_path_tb);
            ThemeManager.RegisterButton(save_settings_button);
        }
        #endregion

        #region settings closed
        private void SettingsFormClosing(object sender, FormClosingEventArgs e)
        {
            if (save_settings_button.Enabled == true)
            {
                DialogResult confirm = MessageBox.Show("Unsaved settings will be lost. Continue?", "Exit",
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirm == DialogResult.OK)
                {
                    save_settings_button.Enabled = false;
                    GetSettings();
                    ThemeManager.CurrrentTheme(this);
                }
                else if (confirm == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region settings datas
        public void GetSettings()
        {
            MovieFilePathText = Properties.Settings.Default.movie_path;
            SerieFilePathText = Properties.Settings.Default.serie_path;
            BookFilePathText = Properties.Settings.Default.book_path;
        }

        public void SaveSettings()
        {
            SetFilePath();
            SetThemeOption();
            save_settings_button.Enabled = false;
            Properties.Settings.Default.Save();
            CheckSettingsFormState();
        }

        private void SetFilePath()
        {
            Properties.Settings.Default.movie_path = MovieFilePathText;
            Properties.Settings.Default.serie_path = SerieFilePathText;
            Properties.Settings.Default.book_path = BookFilePathText;
        }

        private void SetThemeOption()
        {
            if (LightThemeCheck)
            {
                Properties.Settings.Default.light_checked = true;
                Properties.Settings.Default.dark_checked = false;
            }

            if (DarkThemeCheck)
            {
                Properties.Settings.Default.dark_checked = true;
                Properties.Settings.Default.light_checked = false;
            }
        }

        private void CheckSettingsFormState()
        {
            //check settings form is already open
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == this.Name)
                {
                    this.Close(); //if it's open, close it
                }
            }
        }
        #endregion

        #region settings input fields
        private void PathChanged(object sender, EventArgs e)
        {
            if (MovieFilePathText == string.Empty)
            {
                clear_movie_path_button.Enabled = false;
            }
            else if (MovieFilePathText != string.Empty)
            {
                clear_movie_path_button.Enabled = true;
            }

            if (SerieFilePathText == string.Empty)
            {
                clear_serie_path_button.Enabled = false;
            }
            else if (SerieFilePathText != string.Empty)
            {
                clear_serie_path_button.Enabled = true;
            }

            if (BookFilePathText == string.Empty)
            {
                clear_book_path_button.Enabled = false;
            }
            else if (BookFilePathText != string.Empty)
            {
                clear_book_path_button.Enabled = true;
            }
        }
        #endregion

        #region settings buttons
        private void SetFileName(string whichButton, string fileName)
        {
            switch (whichButton)
            {
                case "open_movie_path_button":
                    MovieFilePathText = fileName;
                    break;
                case "open_serie_path_button":
                    SerieFilePathText = fileName;
                    break;
                case "open_book_path_button":
                    BookFilePathText = fileName;
                    break;
            }
        }

        private void DetectButton(string whichButton)
        {
            switch (whichButton)
            {
                case "open_movie_path_button":
                    filePath = @Properties.Settings.Default.movie_path;
                    fileName = "movielist";
                    break;
                case "open_serie_path_button":
                    filePath = @Properties.Settings.Default.serie_path;
                    fileName = "serielist";
                    break;
                case "open_book_path_button":
                    filePath = @Properties.Settings.Default.book_path;
                    fileName = "booklist";
                    break;
            }
        }
        private void OpenPath(object sender, EventArgs e)
        {
            DetectButton(((Button)sender).Name);
            openfiledialog.InitialDirectory = filePath;
            openfiledialog.RestoreDirectory = true;
            openfiledialog.FileName = fileName;
            openfiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openfiledialog.FilterIndex = 0;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                SetFileName(((Button)sender).Name, openfiledialog.FileName);
                save_settings_button.Enabled = true;
            }
            else
            {
                GetSettings();
                save_settings_button.Enabled = false;
            }
        }

        private void ClearPath(object sender, EventArgs e)
        {
            save_settings_button.Enabled = true;
            switch (((Button)sender).Name)
            {
                case "clear_movie_path_button":
                    MovieFilePathText = string.Empty;
                    break;
                case "clear_serie_path_button":
                    SerieFilePathText = string.Empty;
                    break;
                case "clear_book_path_button":
                    BookFilePathText = string.Empty;
                    break;
            }
        }

        public void ThemeRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (LightThemeCheck)
            {
                ThemeManager.SetAllThemeColors(lightThemeBackgroundColor, darkThemeTextColor, darkThemeTextColor);
                if (Properties.Settings.Default.dark_checked == true)
                {
                    save_settings_button.Enabled = true;
                }
            }
            else if (DarkThemeCheck)
            {
                ThemeManager.SetAllThemeColors(darkThemeBackgroundColor, lightThemeTextColor, darkThemeTextColor);
                if (Properties.Settings.Default.light_checked == true)
                {
                    save_settings_button.Enabled = true;
                }
            }
        }

        private void SaveSettingsButtonClick(object sender, EventArgs e)
        {
            SaveSettings();
            MessageBox.Show("Settings Saved!");
        }

        private void SaveSettingsButtonEnabledChanged(object sender, EventArgs e)
        {
            if (save_settings_button.Enabled == true)
            {
                settings_error_provider.SetError(save_settings_button, "There're unsaved settings!");
            }
            if (save_settings_button.Enabled == false)
            {
                settings_error_provider.Clear();
            }
        }
        #endregion

    }
}
