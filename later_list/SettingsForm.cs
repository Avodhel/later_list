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
        string fileName;
        string filePath;
        public Color lightBC = Color.FromArgb(242,242,242);
        public Color darkBC = Color.FromArgb(51,51,51);
        public Color lightTC = Color.FromArgb(242,242,242);
        public Color darkTC = Color.FromArgb(31, 31, 31);
        #endregion

        #region settings opened
        public SettingsForm()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private Form mainForm = null;
        public SettingsForm(Form settings)
        {
            mainForm = settings as SettingsForm;
            InitializeComponent();
        }

        private void SettingsLoad(object sender, EventArgs e)
        {
            LoadTheme();
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
                    if (Properties.Settings.Default.light_checked == true)
                    {
                        light_rb.Checked = true;
                        dark_rb.Checked = false;
                        ThemeManager.SetAllBackColors(lightBC, darkTC, darkTC);
                    }
                    if (Properties.Settings.Default.dark_checked == true)
                    {
                        dark_rb.Checked = true;
                        light_rb.Checked = false;
                        ThemeManager.SetAllBackColors(darkBC, lightTC, darkTC);
                    }
                }
                else if (confirm == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region settings option variables
        public string MovieTextBoxText
        {
            get { return movie_path_tb.Text; }
            set { movie_path_tb.Text = value; }
        }

        public string SerieTextBoxText
        {
            get { return serie_path_tb.Text; }
            set { serie_path_tb.Text = value; }
        }

        public string BookTextBoxText
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

        #region settings datas
        public void GetSettings()
        {
            movie_path_tb.Text = Properties.Settings.Default.movie_path;
            serie_path_tb.Text = Properties.Settings.Default.serie_path;
            book_path_tb.Text = Properties.Settings.Default.book_path;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.movie_path = movie_path_tb.Text;
            Properties.Settings.Default.serie_path = serie_path_tb.Text;
            Properties.Settings.Default.book_path = book_path_tb.Text;
            if (light_rb.Checked)
            {
                Properties.Settings.Default.light_checked = true;
                Properties.Settings.Default.dark_checked = false;
            }

            if (dark_rb.Checked)
            {
                Properties.Settings.Default.dark_checked = true;
                Properties.Settings.Default.light_checked = false;
            }
            save_settings_button.Enabled = false;
            Properties.Settings.Default.Save();

            //check settings form is already open
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "settings")
                {
                    this.Close(); //if it's, close it
                }
            }
        }
        #endregion

        #region settings input fields
        private void PathChanged(object sender, EventArgs e)
        {
            if (movie_path_tb.Text == string.Empty)
            {
                clear_movie_path_button.Enabled = false;
            }
            else if (movie_path_tb.Text != string.Empty)
            {
                clear_movie_path_button.Enabled = true;
            }

            if (serie_path_tb.Text == string.Empty)
            {
                clear_serie_path_button.Enabled = false;
            }
            else if (serie_path_tb.Text != string.Empty)
            {
                clear_serie_path_button.Enabled = true;
            }

            if (book_path_tb.Text == string.Empty)
            {
                clear_book_path_button.Enabled = false;
            }
            else if (book_path_tb.Text != string.Empty)
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
                    movie_path_tb.Text = fileName;
                    break;
                case "open_serie_path_button":
                    serie_path_tb.Text = fileName;
                    break;
                case "open_book_path_button":
                    book_path_tb.Text = fileName;
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
                    movie_path_tb.Text = string.Empty;
                    break;
                case "clear_serie_path_button":
                    serie_path_tb.Text = string.Empty;
                    break;
                case "clear_book_path_button":
                    book_path_tb.Text = string.Empty;
                    break;
            }
        }

        public void ThemeRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (light_rb.Checked)
            {
                ThemeManager.SetAllBackColors(lightBC, darkTC, darkTC);
                if (Properties.Settings.Default.dark_checked == true)
                {
                    save_settings_button.Enabled = true;
                }
            }
            else if (dark_rb.Checked)
            {
                ThemeManager.SetAllBackColors(darkBC, lightTC, darkTC);
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
