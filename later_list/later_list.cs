using System;
using System.IO;
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
    public partial class later_list : Form
    {
        #region variables
        string which_section = "movie";
        string data;
        //List<string> listbox = new List<string>();
        ListBox listBox = new ListBox();
        string genre_part;
        string save_path;
        string load_path;
        string[] movie_genres = {"Action",
                                 "Adventure",
                                 "Animation",
                                 "Biography",
                                 "Comedy",
                                 "Crime",
                                 "Documentary",
                                 "Drama",
                                 "Family",
                                 "Fantasy",
                                 "Film Noir",
                                 "History",
                                 "Horror",
                                 "Music",
                                 "Musical",
                                 "Mystery",
                                 "Romance",
                                 "Sci-Fi",
                                 "Short",
                                 "Sitcom",
                                 "Sport",
                                 "Superhero",
                                 "Thriller",
                                 "War",
                                 "Western"};
        string[] serie_genres = {"Action",
                                 "Adventure",
                                 "Animation",
                                 "Biography",
                                 "Comedy",
                                 "Crime",
                                 "Documentary",
                                 "Drama",
                                 "Family",
                                 "Fantasy",
                                 "Film Noir",
                                 "History",
                                 "Horror",
                                 "Music",
                                 "Musical",
                                 "Mystery",
                                 "Romance",
                                 "Sci-Fi",
                                 "Short",
                                 "Sitcom",
                                 "Sport",
                                 "Superhero",
                                 "Thriller",
                                 "War",
                                 "Western"};
        string[] book_genres = {"Action and Adventure",
                                "Anthology",
                                "Biography/Autobiography",
                                "Classic",
                                "Comic and Graphic Novel",
                                "Crime and Detective",
                                "Drama",
                                "Essay",
                                "Fable",
                                "Fairy Tale",
                                "Fan-Fiction",
                                "Fantasy",
                                "Historical Fiction",
                                "Horror",
                                "Humor",
                                "Legend",
                                "Magical Realism",
                                "Memoir",
                                "Mystery",
                                "Mythology",
                                "Narrative Nonfiction",
                                "Periodicals",
                                "Realistic Fiction",
                                "Reference Books",
                                "Romance",
                                "Satire",
                                "Self-help Book",
                                "Sci-Fi",
                                "Short Story",
                                "Speech",
                                "Suspense/Thriller",
                                "Textbook",
                                "Poetry"};
        //Settings Form
        Settings settings_screen = new Settings();
        
        #endregion

        #region start app
        public later_list()
        {
            FormManager.registerForm(this);
            InitializeComponent();
            choose_listbox();
            load_genres();
            if(which_section == "movie" && Properties.Settings.Default.movie_path != "")
            {
                load_list();
            }
            settings_screen.getSettings();
            theme_control();
        }
        #endregion

        #region exit from app
        private void later_list_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save_button.Enabled == true)
            {
                DialogResult confirm = MessageBox.Show("Unsaved changes will be lost. Continue?", "Exit",
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

        private void later_list_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.unRegisterForm(this);
        }
        #endregion

        #region choose section
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            if (movie_rb.Checked && !series_rb.Checked && !books_rb.Checked)
            {
                which_section = "movie";
                //labels
                movie_name_lbl.Visible = true;
                serie_name_lbl.Visible = false;
                book_name_lbl.Visible = false;
                author_lbl.Visible = false;
                genre_lbl.Location = new Point(37, 37);
                //checkbox
                genre_cb.Location = new Point(85, 35);
                //textbox
                author_tb.Visible = false;
                //listbox
                movie_listbox.Visible = true;
                serie_listbox.Visible = false;
                book_listbox.Visible = false;
                //load list
                choose_listbox();
                if (Properties.Settings.Default.movie_path != "")
                {
                    load_list();
                }
                //load genres
                load_genres();
                //refresh input fields
                refresh_input_fields();
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }
            if (!movie_rb.Checked && series_rb.Checked && !books_rb.Checked)
            {
                which_section = "serie";
                //labels
                movie_name_lbl.Visible = false;
                serie_name_lbl.Visible = true;
                book_name_lbl.Visible = false;
                author_lbl.Visible = false;
                genre_lbl.Location = new Point(37, 37);
                //checkbox
                genre_cb.Location = new Point(85, 35);
                //textbox
                author_tb.Visible = false;
                //listbox
                movie_listbox.Visible = false;
                serie_listbox.Visible = true;
                book_listbox.Visible = false;
                //load list
                choose_listbox();
                if (Properties.Settings.Default.serie_path != "")
                {
                    load_list();
                }
                //load genres
                load_genres();
                //refresh input fields
                refresh_input_fields();
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }
            if (!movie_rb.Checked && !series_rb.Checked && books_rb.Checked)
            {
                which_section = "book";
                //labels
                movie_name_lbl.Visible = false;
                serie_name_lbl.Visible = false;
                book_name_lbl.Visible = true;
                author_lbl.Visible = true;
                genre_lbl.Location = new Point(37, 69);
                //checkbox
                genre_cb.Location = new Point(85, 67);
                //textbox
                author_tb.Visible = true;
                //listbox
                movie_listbox.Visible = false;
                serie_listbox.Visible = false;
                book_listbox.Visible = true;
                //load list
                choose_listbox();
                if (Properties.Settings.Default.book_path != "")
                {
                    load_list();
                }
                //load genres
                load_genres();
                //refresh input fields
                refresh_input_fields();
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }
        }
        #endregion

        #region input fields
        private void input_fields_Click(object sender, EventArgs e)
        {
            if (name_tb.Text == "" && genre_cb.Text == "")
            {
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            refresh_input_fields();
            //enable buttons
            add_button.Enabled = true;
            remove_button.Enabled = false;
            edit_button.Enabled = false;
        }

        private void refresh_input_fields()
        {
            name_tb.Text = "";
            genre_cb.Text = "";
            author_tb.Text = "";
        }

        private void load_genres()
        {
            genre_cb.Items.Clear();
            switch (which_section)
            {
                case "movie":
                    genre_cb.Items.AddRange(movie_genres);
                    break;
                case "serie":
                    genre_cb.Items.AddRange(serie_genres);
                    break;
                case "book":
                    genre_cb.Items.AddRange(book_genres);
                    break;
            }
        }
        #endregion

        #region add
        private void add_button_Click(object sender, EventArgs e)
        {
            save_button.Enabled = true;

            if (name_tb.Text == "")
            {
                MessageBox.Show("Please add a " + which_section + " name", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data = name_tb.Text + " (" + genre_cb.Text + ")";
                addToList(data);
                refresh_input_fields();
            }
        }

        private void addToList(string info)
        {
            switch (which_section)
            {
                case "movie":
                    movie_listbox.Items.Add(info);
                    break;
                case "serie":
                    serie_listbox.Items.Add(info);
                    break;
                case "book":
                    book_listbox.Items.Add(info);
                    break;
            }
        }
        #endregion

        #region remove
        private void remove_button_Click(object sender, EventArgs e)
        {
            save_button.Enabled = true;

            listBox.Items.Remove(listBox.SelectedItem);
            //refresh input fields
            refresh_input_fields();
        }
        #endregion

        #region edit
        private void selectedIndexChanged(object sender, EventArgs e)
        {
            add_button.Enabled = false;
            remove_button.Enabled = true;
            edit_button.Enabled = true;

            try
            {
                //name_tb.Text = listBox.SelectedItem.ToString();
                string get_info = listBox.SelectedItem.ToString();
                string name_part = get_info.Split('(')[0];
                name_part = name_part.TrimEnd(' ');

                try
                {
                    genre_part = get_info.Split('(')[1];
                    genre_part = genre_part.TrimEnd(')');
                }
                catch
                {
                    genre_part = "";
                }
                name_tb.Text = name_part;
                genre_cb.Text = genre_part;
            }
            catch
            {

            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            save_button.Enabled = true;

            int index = listBox.SelectedIndex;
            listBox.Items.RemoveAt(index);
            listBox.Items.Insert(index, name_tb.Text + " (" + genre_cb.Text + ")");
            //refresh input fields
            refresh_input_fields();
        }
        #endregion

        #region save
        private void save_button_Click(object sender, EventArgs e)
        {
            #region movie
            if (which_section == "movie" && Properties.Settings.Default.movie_path == "")
            {
                savefiledialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                savefiledialog.RestoreDirectory = true;
                savefiledialog.FileName = "movielist";
                savefiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    settings_screen.MovieTextBoxText = savefiledialog.FileName;
                    settings_screen.saveSettings();
                    save_path = Properties.Settings.Default.movie_path;
                    load_path = Properties.Settings.Default.movie_path;
                    save_list(true);
                }
                else
                {
                    settings_screen.getSettings();
                }
            }
            else if(which_section == "movie" && Properties.Settings.Default.movie_path != "")
            {
                save_list(true);
            }
            #endregion

            #region serie
            if (which_section == "serie" && Properties.Settings.Default.serie_path == "")
            {
                savefiledialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                savefiledialog.RestoreDirectory = true;
                savefiledialog.FileName = "serielist";
                savefiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    settings_screen.SerieTextBoxText = savefiledialog.FileName;
                    settings_screen.saveSettings();
                    save_path = Properties.Settings.Default.serie_path;
                    load_path = Properties.Settings.Default.serie_path;
                    save_list(true);
                }
                else
                {
                    settings_screen.getSettings();
                }
            }
            else if (which_section == "serie" && Properties.Settings.Default.serie_path != "")
            {
                save_list(true);
            }
            #endregion

            #region book
            if (which_section == "book" && Properties.Settings.Default.book_path == "")
            {
                savefiledialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                savefiledialog.RestoreDirectory = true;
                savefiledialog.FileName = "booklist";
                savefiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    settings_screen.BookTextBoxText = savefiledialog.FileName;
                    settings_screen.saveSettings();
                    save_path = Properties.Settings.Default.book_path;
                    load_path = Properties.Settings.Default.book_path;
                    save_list(true);
                }
                else
                {
                    settings_screen.getSettings();
                }
            }
            else if (which_section == "book" && Properties.Settings.Default.book_path != "")
            {
                save_list(true);
            }
            #endregion
        }

        private void save_button_EnabledChanged(object sender, EventArgs e)
        {
            if (save_button.Enabled == true)
            {
                error_provider.SetError(save_button, "There're unsaved changes in " + which_section + " list!");
            }
            if (save_button.Enabled == false)
            {
                error_provider.Clear();
            }
        }
        #endregion

        #region save and load system
        private void choose_listbox()
        {
            listBox.Items.Clear();
            switch (which_section)
            {
                case "movie":
                    listBox = movie_listbox;
                    save_path = Properties.Settings.Default.movie_path;
                    load_path = Properties.Settings.Default.movie_path;
                    break;
                case "serie":
                    listBox = serie_listbox;
                    save_path = Properties.Settings.Default.serie_path;
                    load_path = Properties.Settings.Default.serie_path;
                    break;
                case "book":
                    listBox = book_listbox;
                    save_path = Properties.Settings.Default.book_path;
                    load_path = Properties.Settings.Default.book_path;
                    break;
            }
        }
        
        private void save_list(bool show_message)
        {
            StreamWriter saveFile = new StreamWriter(save_path);
            foreach (var item in listBox.Items)
            {
                saveFile.WriteLine(item);
            }

            saveFile.Close();

            if (show_message)
            {
                MessageBox.Show(which_section + " list saved!");
                show_message = false;
                save_button.Enabled = false;
            }
        }
        
        private void load_list()
        {
            try
            {
                using (StreamReader loadFile = new StreamReader(load_path))
                {
                    string line;
                    while ((line = loadFile.ReadLine()) != null)
                    {
                        listBox.Items.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                //MessageBox.Show("There isn't a " + which_section + " list.", "File Not Found",
                //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region settings screen
        private void settings_button_Click(object sender, EventArgs e)
        { 
            settings_screen.ShowDialog();
        }

        private void theme_control()
        {
            if (Properties.Settings.Default.theme == "Light")
            {
                FormManager.setAllBackcolors(SystemColors.InactiveBorder);
                settings_screen.LightThemeCheck = true;
                settings_screen.DarkThemeCheck = false;
            }
            if (Properties.Settings.Default.theme == "Dark")
            {
                FormManager.setAllBackcolors(SystemColors.InactiveCaptionText);
                settings_screen.LightThemeCheck = false;
                settings_screen.DarkThemeCheck = true;
            }
        }
        #endregion
    }
}
