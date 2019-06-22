using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace watch_list
{
    public partial class Settings : Form
    {
        public Settings()
        {
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

        #region settings
        public void getSettings()
        {
            //MovieTextBox = Properties.Settings.Default.movie_path;
            movie_path_tb.Text = Properties.Settings.Default.movie_path;
            serie_path_tb.Text = Properties.Settings.Default.serie_path;
            book_path_tb.Text = Properties.Settings.Default.book_path;
        }

        public void saveSettings()
        {
            Properties.Settings.Default.movie_path = movie_path_tb.Text;
            Properties.Settings.Default.serie_path = serie_path_tb.Text;
            Properties.Settings.Default.book_path = book_path_tb.Text;

            Properties.Settings.Default.Save();
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
            }
            else
            {
                getSettings();
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
            }
            else
            {
                getSettings();
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
            }
            else
            {
                getSettings();
            }
        }

        private void save_settings_button_Click(object sender, EventArgs e)
        {

            saveSettings();
        }
        #endregion
    }
}
