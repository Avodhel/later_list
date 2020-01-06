using System;
using System.Windows.Forms;

namespace later_list
{
    public partial class SettingsForm : Form, IForm
    {
        #region Variables

        private string filePath;
        //private Form mainForm = null;

        #endregion

        #region Properties

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

        #region Constructors

        public SettingsForm()
        {
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            LoadTheme();
        }

        //public SettingsForm(Form settings)
        //{
        //    //mainForm = settings as SettingsForm;
        //    InitializeComponent();
        //}

        private void SettingsLoad(object sender, EventArgs e)
        {
            //LoadTheme();
        }

        #endregion

        #region Settings Form Closed

        private void SettingsFormClosing(object sender, FormClosingEventArgs e)
        {
            if (save_settings_button.Enabled == true)
            {
                DialogResult confirm = MessageBox.Show("Unsaved settings will be lost. Continue?", "Exit",
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirm == DialogResult.OK)
                {
                    save_settings_button.Enabled = false;
                    GetAllFilePathsFromProperties();
                    ThemeManager.CurrrentTheme(this);
                }
                else if (confirm == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region Settings Form State

        public void SaveSettings()
        {
            SetAllFilePathsToProperties();
            SetThemeOption();
            save_settings_button.Enabled = false;
            Properties.Settings.Default.Save();
            SettingsFormState();
        }

        private void SettingsFormState()
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

        #region Input Fields

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

        #region File Paths

        public void GetAllFilePathsFromProperties()
        {
            MovieFilePathText = Properties.Settings.Default.movie_path;
            SerieFilePathText = Properties.Settings.Default.serie_path;
            BookFilePathText = Properties.Settings.Default.book_path;
        }

        private void SetAllFilePathsToProperties()
        {
            Properties.Settings.Default.movie_path = MovieFilePathText;
            Properties.Settings.Default.serie_path = SerieFilePathText;
            Properties.Settings.Default.book_path = BookFilePathText;
        }

        public void SetFilePath(string whichSection, string _filePath)
        {
            switch (whichSection)
            {
                case "movie":
                    MovieFilePathText = _filePath;
                    break;
                case "serie":
                    SerieFilePathText = _filePath;
                    break;
                case "book":
                    BookFilePathText = _filePath;
                    break;
            }
        }

        private void GetFilePath(string whichSection)
        {
            switch (whichSection)
            {
                case "movie":
                    filePath = @Properties.Settings.Default.movie_path;
                    break;
                case "serie":
                    filePath = @Properties.Settings.Default.serie_path;
                    break;
                case "book":
                    filePath = @Properties.Settings.Default.book_path;
                    break;
            }
        }

        private void OpenPath(object sender, EventArgs e)
        {
            GetFilePath(DetectSectionFromButton(((Button)sender).Name));
            openfiledialog.InitialDirectory = filePath;
            openfiledialog.RestoreDirectory = true;
            openfiledialog.FileName = DetectSectionFromButton(((Button)sender).Name) + "list";
            openfiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openfiledialog.FilterIndex = 0;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                SetFilePath(DetectSectionFromButton(((Button)sender).Name), openfiledialog.FileName);
                save_settings_button.Enabled = true;
            }
            else
            {
                GetAllFilePathsFromProperties();
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

        #endregion

        #region Button Actions

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

        public void ThemeRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (LightThemeCheck)
            {
                ThemeManager.SetAllThemeColors(Colors.LightThemeBackgroundColor, 
                                               Colors.DarkThemeTextColor, 
                                               Colors.DarkThemeTextColor);
                if (Properties.Settings.Default.dark_checked == true)
                {
                    save_settings_button.Enabled = true;
                }
            }
            else if (DarkThemeCheck)
            {
                ThemeManager.SetAllThemeColors(Colors.DarkThemeBackgroundColor, 
                                               Colors.LightThemeTextColor, 
                                               Colors.DarkThemeTextColor);
                if (Properties.Settings.Default.light_checked == true)
                {
                    save_settings_button.Enabled = true;
                }
            }
        }

        private string DetectSectionFromButton(string buttonName)
        {
            if (buttonName == "open_movie_path_button") return "movie";
            if (buttonName == "open_serie_path_button") return "serie";
            if (buttonName == "open_book_path_button") return "book";
            return null;
        }

        #endregion

        #region Load Theme

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

    }
}
