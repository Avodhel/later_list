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
        string whichSection = "movie";
        string data;
        string getInfo;
        string namePart;
        string authorPart;
        string genrePart;
        string savePath;
        string loadPath;
        string listPath;
        string[] movieGenres = {"Action",
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
        string[] serieGenres = {"Action",
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
        string[] bookGenres = {"Action and Adventure",
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
        bool canAddListControl = true;
        ListBox listBox = new ListBox();
        settings settingsForm = new settings();
        #endregion

        #region start app
        public later_list()
        {
            this.CenterToScreen();
            FormManager.registerForm(this);
            InitializeComponent();
            chooseListbox();
            loadGenres();
            if(whichSection == "movie" && Properties.Settings.Default.movie_path != "")
            {
                loadList();
            }
            settingsForm.getSettings();
            themeControl();
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
            if (movie_rb.Checked && !serie_rb.Checked && !book_rb.Checked)
            {
                whichSection = "movie";
                //panel scroll
                input_fields_panel.VerticalScroll.Value = 0;
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
                chooseListbox();
                if (Properties.Settings.Default.movie_path != "")
                {
                    loadList();
                }
                //load genres
                loadGenres();
                //refresh input fields
                refreshInputFields();
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }

            if (!movie_rb.Checked && serie_rb.Checked && !book_rb.Checked)
            {
                whichSection = "serie";
                //panel scroll
                input_fields_panel.VerticalScroll.Value = 0;
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
                chooseListbox();
                if (Properties.Settings.Default.serie_path != "")
                {
                    loadList();
                }
                //load genres
                loadGenres();
                //refresh input fields
                refreshInputFields();
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }

            if (!movie_rb.Checked && !serie_rb.Checked && book_rb.Checked)
            {
                whichSection = "book";
                //panel scroll
                input_fields_panel.VerticalScroll.Value = 0;
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
                chooseListbox();
                if (Properties.Settings.Default.book_path != "")
                {
                    loadList();
                }
                //load genres
                loadGenres();
                //refresh input fields
                refreshInputFields();
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
            movie_listbox.ClearSelected();
            serie_listbox.ClearSelected();
            book_listbox.ClearSelected();
            refreshInputFields();
            //enable buttons
            add_button.Enabled = true;
            remove_button.Enabled = false;
            edit_button.Enabled = false;
        }

        private void refreshInputFields()
        {
            name_tb.Text = "";
            genre_cb.Text = "";
            author_tb.Text = "";
        }

        private void loadGenres()
        {
            genre_cb.Items.Clear();
            switch (whichSection)
            {
                case "movie":
                    genre_cb.Items.AddRange(movieGenres);
                    break;
                case "serie":
                    genre_cb.Items.AddRange(serieGenres);
                    break;
                case "book":
                    genre_cb.Items.AddRange(bookGenres);
                    break;
            }
        }
        #endregion

        #region add
        private void add_button_Click(object sender, EventArgs e)
        {
            if(name_tb.Text != "")
            {
                save_button.Enabled = true;
                canAddListControl = true;
            }
            else if (name_tb.Text == "")
            {
                MessageBox.Show("Please add a " + whichSection + " name", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                save_button.Enabled = false;
                canAddListControl = false;
            }

            if (whichSection != "book" && canAddListControl)
            {
                data = name_tb.Text + " (" + genre_cb.Text + ")";
                addToList(data);
                refreshInputFields();
            }
            else if(whichSection == "book" && canAddListControl)
            {
                data = name_tb.Text + " - " + author_tb.Text + " (" + genre_cb.Text + ")";
                addToList(data);
                refreshInputFields();
            }
        }

        private void addToList(string info)
        {
            switch (whichSection)
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
            refreshInputFields();
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
                getInfo = listBox.SelectedItem.ToString();        
                if (whichSection != "book")
                {
                    namePart = getInfo.Split('(')[0];
                }
                else if (whichSection == "book")
                {
                    namePart = getInfo.Split('-')[0];
                    authorPart = getInfo.Split('-')[1];
                    authorPart = authorPart.TrimStart(' ');
                }
                namePart = namePart.TrimEnd(' ');

                if (whichSection == "book")
                {
                    try
                    {
                        authorPart = authorPart.Split('(')[0];
                        authorPart = authorPart.TrimEnd(' ');
                    }
                    catch
                    {
                        authorPart = "";
                    }
                }

                try
                {
                    genrePart = getInfo.Split('(')[1];
                    genrePart = genrePart.TrimEnd(')');
                }
                catch
                {
                    genrePart = "";
                }

                name_tb.Text = namePart;
                if (whichSection == "book")
                {
                    author_tb.Text = authorPart;
                }
                genre_cb.Text = genrePart;
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
            if(whichSection != "book")
            {
                listBox.Items.Insert(index, name_tb.Text + " (" + genre_cb.Text + ")");
            }
            else if (whichSection == "book")
            {
               listBox.Items.Insert(index, name_tb.Text + " - " + author_tb.Text + " (" + genre_cb.Text + ")");
            }
            //refresh input fields
            refreshInputFields();
        }
        #endregion

        #region save
        private void setListPath()
        {
            switch (whichSection)
            {
                case "movie":
                    listPath = Properties.Settings.Default.movie_path;
                    break;
                case "serie":
                    listPath = Properties.Settings.Default.serie_path;
                    break;
                case "book":
                    listPath = Properties.Settings.Default.book_path;
                    break;
            }
        }

        private void setFileName(string fileName)
        {
            switch (whichSection)
            {
                case "movie":
                    settingsForm.MovieTextBoxText = fileName;
                    break;
                case "serie":
                    settingsForm.SerieTextBoxText = fileName;
                    break;
                case "book":
                    settingsForm.BookTextBoxText = fileName;
                    break;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            setListPath();

            if ( listPath == "")
            {
                savefiledialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                savefiledialog.RestoreDirectory = true;
                savefiledialog.FileName = whichSection + "list";
                savefiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (savefiledialog.ShowDialog() == DialogResult.OK)
                {
                    setFileName(savefiledialog.FileName);
                    settingsForm.saveSettings();
                    setListPath();
                    savePath = listPath;
                    loadPath = listPath;
                    saveList(true);
                }
                else
                {
                    settingsForm.getSettings();
                }
            }
            else if (listPath != "")
            {
                saveList(true);
            }
        }

        private void save_button_EnabledChanged(object sender, EventArgs e)
        {
            if (save_button.Enabled == true)
            {
                switch (whichSection)
                {
                    case "movie":
                        serie_rb.Enabled = false;
                        book_rb.Enabled = false;
                        break;
                    case "serie":
                        movie_rb.Enabled = false;
                        book_rb.Enabled = false;
                        break;
                    case "book":
                        movie_rb.Enabled = false;
                        serie_rb.Enabled = false;
                        break;
                }
                error_provider.SetError(save_button, "There're unsaved changes in " + whichSection + " list!");
                discard_button.Visible = true;
            }
            if (save_button.Enabled == false)
            {
                movie_rb.Enabled = true;
                serie_rb.Enabled = true;
                book_rb.Enabled = true;
                error_provider.Clear();
                discard_button.Visible = false;
            }
        }
        #endregion

        #region discard
        private void discard_button_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("All changes will discard, Continue ?", "Discard",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirm == DialogResult.OK)
            {
                switch (whichSection)
                {
                    case "movie":
                        movie_listbox.Items.Clear();
                        if (Properties.Settings.Default.movie_path != "")
                        {
                            loadList();
                        }
                        break;
                    case "serie":
                        serie_listbox.Items.Clear();
                        if (Properties.Settings.Default.serie_path != "")
                        {
                            loadList();
                        }
                        break;
                    case "book":
                        book_listbox.Items.Clear();
                        if (Properties.Settings.Default.book_path != "")
                        {
                            loadList();
                        }
                        break;
                }
                save_button.Enabled = false;
            }
            else if (confirm == DialogResult.Cancel)
            {
               
            }
        }
        #endregion

        #region save and load system
        private void chooseListbox()
        {
            listBox.Items.Clear();
            switch (whichSection)
            {
                case "movie":
                    listBox = movie_listbox;
                    savePath = Properties.Settings.Default.movie_path;
                    loadPath = Properties.Settings.Default.movie_path;
                    break;
                case "serie":
                    listBox = serie_listbox;
                    savePath = Properties.Settings.Default.serie_path;
                    loadPath = Properties.Settings.Default.serie_path;
                    break;
                case "book":
                    listBox = book_listbox;
                    savePath = Properties.Settings.Default.book_path;
                    loadPath = Properties.Settings.Default.book_path;
                    break;
            }
        }
        
        private void saveList(bool show_message)
        {
            StreamWriter saveFile = new StreamWriter(savePath);
            foreach (var item in listBox.Items)
            {
                saveFile.WriteLine(item);
            }

            saveFile.Close();

            if (show_message)
            {
                MessageBox.Show(whichSection + " list saved!");
                show_message = false;
                save_button.Enabled = false;
            }
        }
        
        private void loadList()
        {
            try
            {
                using (StreamReader loadFile = new StreamReader(loadPath))
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
            settingsForm.ShowDialog();
        }

        private void themeControl()
        {
            if (Properties.Settings.Default.theme == "Light")
            {
                FormManager.setAllBackcolors(SystemColors.InactiveBorder);
                settingsForm.LightThemeCheck = true;
                settingsForm.DarkThemeCheck = false;
            }
            if (Properties.Settings.Default.theme == "Dark")
            {
                FormManager.setAllBackcolors(SystemColors.InactiveCaptionText);
                settingsForm.LightThemeCheck = false;
                settingsForm.DarkThemeCheck = true;
            }
        }
        #endregion

    }
}
