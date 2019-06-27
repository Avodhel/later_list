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
    public partial class Settings : Form
    {
        #region variables
        string which_theme;
        #endregion

        #region settings opened
        public Settings()
        {
            FormManager.registerForm(this);
            InitializeComponent();
        }

        private Form mainForm = null;
        public Settings(Form settings)
        {
            mainForm = settings as Settings;
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region settings closed
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save_settings_button.Enabled == true)
            {
                DialogResult confirm = MessageBox.Show("Unsaved settings will be lost. Continue?", "Exit",
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirm == DialogResult.OK)
                {

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

        #region settings
        public void getSettings()
        {
            movie_path_tb.Text = Properties.Settings.Default.movie_path;
            serie_path_tb.Text = Properties.Settings.Default.serie_path;
            book_path_tb.Text = Properties.Settings.Default.book_path;
        }

        public void saveSettings()
        {
            Properties.Settings.Default.movie_path = movie_path_tb.Text;
            Properties.Settings.Default.serie_path = serie_path_tb.Text;
            Properties.Settings.Default.book_path = book_path_tb.Text;
            Properties.Settings.Default.theme = which_theme;

            save_settings_button.Enabled = false;
            Properties.Settings.Default.Save();

            //check settings form is already open
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Settings")
                {
                    this.Close(); //if it's close it
                }
            }
        }

        private void open_movie_path_button_Click(object sender, EventArgs e)
        {
            openfiledialog.InitialDirectory = @Properties.Settings.Default.movie_path;
            openfiledialog.RestoreDirectory = true;
            openfiledialog.FileName = "movielist";
            openfiledialog.Filter = "Metin dosyaları (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";
            openfiledialog.FilterIndex = 0;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                movie_path_tb.Text = openfiledialog.FileName;
                save_settings_button.Enabled = true;
            }
            else
            {
                getSettings();
                save_settings_button.Enabled = false;
            }
        }

        private void open_serie_path_button_Click(object sender, EventArgs e)
        {
            openfiledialog.InitialDirectory = @Properties.Settings.Default.serie_path;
            openfiledialog.RestoreDirectory = true;
            openfiledialog.FileName = "serielist";
            openfiledialog.Filter = "Metin dosyaları (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";
            openfiledialog.FilterIndex = 0;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                serie_path_tb.Text = openfiledialog.FileName;
                save_settings_button.Enabled = true;
            }
            else
            {
                getSettings();
                save_settings_button.Enabled = false;
            }
        }

        private void open_book_path_button_Click(object sender, EventArgs e)
        {
            openfiledialog.InitialDirectory = @Properties.Settings.Default.book_path;
            openfiledialog.RestoreDirectory = true;
            openfiledialog.FileName = "booklist";
            openfiledialog.Filter = "Metin dosyaları (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";
            openfiledialog.FilterIndex = 0;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                book_path_tb.Text = openfiledialog.FileName;
                save_settings_button.Enabled = true;
            }
            else
            {
                getSettings();
                save_settings_button.Enabled = false;
            }
        }

        public void theme_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (light_rb.Checked)
            {
                which_theme = "Light";
                FormManager.setAllBackcolors(SystemColors.InactiveBorder);
                if(Properties.Settings.Default.theme == "Dark")
                {
                    save_settings_button.Enabled = true;
                }
                //else if (Properties.Settings.Default.theme == "Light")
                //{
                //    save_settings_button.Enabled = false;
                //}
            }
            if (dark_rb.Checked)
            {
                which_theme = "Dark";
                FormManager.setAllBackcolors(SystemColors.InactiveCaptionText);
                if (Properties.Settings.Default.theme == "Light")
                {
                    save_settings_button.Enabled = true;
                }
                //else if (Properties.Settings.Default.theme == "Dark")
                //{
                //    save_settings_button.Enabled = false;
                //}
            }
        }

        private void save_settings_button_Click(object sender, EventArgs e)
        {
            saveSettings();
            MessageBox.Show("Settings Saved!");
        }
        #endregion
    }

    #region Form Manager
    public static class FormManager
    {
        private static List<Form> formList = new List<Form>();

        public static void registerForm(Form form)
        {
            if (!formList.Contains(form)) formList.Add(form);
        }

        public static void unRegisterForm(Form form)
        {
            if (formList.Contains(form)) formList.Remove(form);
        }

        public static void setAllBackcolors(Color backColor)
        {
            foreach (Form f in formList) if (f != null) f.BackColor = backColor;
        }
    }
    #endregion
}
