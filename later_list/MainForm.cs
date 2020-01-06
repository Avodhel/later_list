using System;
using System.Drawing;
using System.Windows.Forms;

namespace later_list
{ 
    public partial class MainForm : Form, IForm
    {
        #region Variables

        private string whichSection = "movie";
        private string getExistedData;
        private string listPath;
        private string refactoredData;
        private string newEditedData;
        private ListBox listBox = new ListBox();
        private SettingsForm settingsForm = new SettingsForm();
        private SectionManager sectionManager = new SectionManager();

        #endregion

        #region Start App

        public MainForm()
        {
            CenterToScreen();
            InitializeComponent();
            ChooseAndLoadListbox();
            LoadGenres();
            if (whichSection == "movie" && Properties.Settings.Default.movie_path != string.Empty)
            {
                SaveLoadManager.LoadList(whichSection, settingsForm, listBox);
            }
            settingsForm.GetAllFilePathsFromProperties();
            
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            PrepareSection(whichSection);
            LoadTheme();
        }

        public void LoadTheme()
        {
            ThemeManager.RegisterForm(this);
            ThemeManager.RegisterGroupBox(list_operations_gb);
            ThemeManager.RegisterTextBox(name_tb);
            ThemeManager.RegisterTextBox(author_tb);
            ThemeManager.RegisterCheckBox(genre_cb);
            ThemeManager.RegisterListBox(movie_listbox);
            ThemeManager.RegisterListBox(serie_listbox);
            ThemeManager.RegisterListBox(book_listbox);
            ThemeManager.RegisterButton(clear_button);
            ThemeManager.RegisterButton(add_button);
            ThemeManager.RegisterButton(remove_button);
            ThemeManager.RegisterButton(edit_button);
            ThemeManager.RegisterButton(save_button);
            ThemeManager.RegisterButton(discard_button);
            ThemeManager.CurrrentTheme(settingsForm);
        }

        #endregion

        #region Exit From App

        private void MainFormClosing(object sender, FormClosingEventArgs e)
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

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            ThemeManager.UnRegisterForm(this);
        }

        #endregion

        #region Choosing Section

        private void ChooseSection(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "movieSectionBtn":
                    PrepareSection("movie");
                    break;
                case "serieSectionBtn":
                    PrepareSection("serie");
                    break;
                case "bookSectionBtn":
                    PrepareSection("book");
                    break;
            }
        }

        private void PrepareSection(string section)
        {
            if (section == "movie")
            {
                whichSection = "movie";
                list_operations_gb.Text = "Movies";
                //section buttons
                movieSectionBtn.BackColor = SystemColors.ButtonFace;
                serieSectionBtn.BackColor = SystemColors.Highlight;
                bookSectionBtn.BackColor = SystemColors.Highlight;
                //panel scroll
                input_fields_panel.VerticalScroll.Value = 0;
                //labels
                movie_name_lbl.Visible = true;
                serie_name_lbl.Visible = false;
                book_name_lbl.Visible = false;
                author_lbl.Visible = false;
                genre_lbl.Location = new Point(43, 47);
                //checkbox
                genre_cb.Location = new Point(97, 41);
                //textbox
                author_tb.Visible = false;
                //listbox
                movie_listbox.Visible = true;
                serie_listbox.Visible = false;
                book_listbox.Visible = false;
                //load list
                ChooseAndLoadListbox();
                if (Properties.Settings.Default.movie_path != string.Empty)
                {
                    SaveLoadManager.LoadList(whichSection, settingsForm, listBox);
                }
                //load genres
                LoadGenres();
                //refresh input fields
                RefreshInputFields();
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }

            if (section == "serie")
            {
                whichSection = "serie";
                list_operations_gb.Text = "Series";
                //section buttons
                movieSectionBtn.BackColor = SystemColors.Highlight;
                serieSectionBtn.BackColor = SystemColors.ButtonFace;
                bookSectionBtn.BackColor = SystemColors.Highlight;
                //panel scroll
                input_fields_panel.VerticalScroll.Value = 0;
                //labels
                movie_name_lbl.Visible = false;
                serie_name_lbl.Visible = true;
                book_name_lbl.Visible = false;
                author_lbl.Visible = false;
                genre_lbl.Location = new Point(43, 47);
                //checkbox
                genre_cb.Location = new Point(97, 41);
                //textbox
                author_tb.Visible = false;
                //listbox
                movie_listbox.Visible = false;
                serie_listbox.Visible = true;
                book_listbox.Visible = false;
                //load list
                ChooseAndLoadListbox();
                if (Properties.Settings.Default.serie_path != string.Empty)
                {
                    SaveLoadManager.LoadList(whichSection, settingsForm, listBox);
                }
                //load genres
                LoadGenres();
                //refresh input fields
                RefreshInputFields();
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }

            if (section == "book")
            {
                whichSection = "book";
                list_operations_gb.Text = "Books";
                //section buttons
                movieSectionBtn.BackColor = SystemColors.Highlight;
                serieSectionBtn.BackColor = SystemColors.Highlight;
                bookSectionBtn.BackColor = SystemColors.ButtonFace;
                //panel scroll
                input_fields_panel.VerticalScroll.Value = 0;
                //labels
                movie_name_lbl.Visible = false;
                serie_name_lbl.Visible = false;
                book_name_lbl.Visible = true;
                author_lbl.Visible = true;
                genre_lbl.Location = new Point(43, 82);
                //checkbox
                genre_cb.Location = new Point(97, 76);
                //textbox
                author_tb.Visible = true;
                //listbox
                movie_listbox.Visible = false;
                serie_listbox.Visible = false;
                book_listbox.Visible = true;
                //load list
                ChooseAndLoadListbox();
                if (Properties.Settings.Default.book_path != string.Empty)
                {
                    SaveLoadManager.LoadList(whichSection, settingsForm, listBox);
                }
                //load genres
                LoadGenres();
                //refresh input fields
                RefreshInputFields();
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }
        }

        #endregion

        #region Input Fields

        private void InputFieldsClick(object sender, EventArgs e)
        {
            if (name_tb.Text == string.Empty && genre_cb.Text == string.Empty)
            {
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            movie_listbox.ClearSelected();
            serie_listbox.ClearSelected();
            book_listbox.ClearSelected();
            RefreshInputFields();
            //enable buttons
            add_button.Enabled = true;
            remove_button.Enabled = false;
            edit_button.Enabled = false;
        }

        private void RefreshInputFields()
        {
            name_tb.Text = string.Empty;
            genre_cb.Text = string.Empty;
            author_tb.Text = string.Empty;
        }

        private void LoadGenres()
        {
            genre_cb.Items.Clear();
            genre_cb.Items.AddRange(Genres.GetGenres(whichSection));
        }

        #endregion

        #region Add Data

        private void AddButtonClick(object sender, EventArgs e)
        {
            AddNewDataToList(NameFieldCheck());
        }

        private bool NameFieldCheck()
        {
            if (name_tb.Text != string.Empty) return true;
            else return false;
        }

        private void AddNewDataToList(bool nameFieldRequireCheck)
        {
            if (nameFieldRequireCheck)
            {
                if (whichSection == "movie")
                {
                    AddNewMovie();
                }
                else if (whichSection == "serie")
                {
                    AddNewSerie();
                }
                else if (whichSection == "book")
                {
                    AddNewBook();
                }
                RefreshInputFields();
                save_button.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please add a " + whichSection + " name", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                save_button.Enabled = false;
            }
        }

        private void AddNewMovie()
        {
            MovieModel newMovieData = new MovieModel
            {
                Name = name_tb.Text,
                Genre = genre_cb.Text
            };

            refactoredData = DataRefactor.MovieAddDataRefactor(newMovieData);
            sectionManager.AddDataToList(refactoredData, movie_listbox);
        }

        private void AddNewSerie()
        {
            SerieModel newSerieData = new SerieModel
            {
                Name = name_tb.Text,
                Genre = genre_cb.Text
            };

            refactoredData = DataRefactor.SerieAddDataRefactor(newSerieData);
            sectionManager.AddDataToList(refactoredData, serie_listbox);
        }

        private void AddNewBook()
        {
            BookModel newBookData = new BookModel
            {
                Name = name_tb.Text,
                Author = author_tb.Text,
                Genre = genre_cb.Text
            };

            refactoredData = DataRefactor.BookAddDataRefactor(newBookData);
            sectionManager.AddDataToList(refactoredData, book_listbox);
        }

        #endregion

        #region Remove Data

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            save_button.Enabled = true;
            sectionManager.RemoveDataFromList(listBox);
            RefreshInputFields();
        }

        #endregion

        #region Edit Data

        private void EditButtonClick(object sender, EventArgs e)
        {
            SendEditedDataToList();
            save_button.Enabled = true;
            RefreshInputFields();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            add_button.Enabled = false;
            remove_button.Enabled = true;
            edit_button.Enabled = true;

            try
            {
                getExistedData = listBox.SelectedItem.ToString();
                if (whichSection == "movie")
                {
                    MovieModel currentMovieData = DataRefactor.MovieExistedDataRefactor(getExistedData);
                    name_tb.Text = currentMovieData.Name;
                    genre_cb.Text = currentMovieData.Genre;
                }
                if (whichSection == "serie")
                {
                    SerieModel currentSerieData = DataRefactor.SerieExistedDataRefactor(getExistedData);
                    name_tb.Text = currentSerieData.Name;
                    genre_cb.Text = currentSerieData.Genre;
                }
                if (whichSection == "book")
                {
                    BookModel currentBookData = DataRefactor.BookExistedDataRefactor(getExistedData);
                    name_tb.Text = currentBookData.Name;
                    author_tb.Text = currentBookData.Author;
                    genre_cb.Text = currentBookData.Genre;
                }
            }
            catch
            {

            }
        }

        private void SendEditedDataToList()
        {
            if (whichSection == "movie")
            {
                MovieModel editedMovieData = new MovieModel
                {
                    Name = name_tb.Text,
                    Genre = genre_cb.Text
                };
                newEditedData = DataRefactor.MovieAddDataRefactor(editedMovieData);
            }
            if (whichSection == "serie")
            {
                SerieModel editedSerieData = new SerieModel
                {
                    Name = name_tb.Text,
                    Genre = genre_cb.Text
                };
                newEditedData = DataRefactor.SerieAddDataRefactor(editedSerieData);
            }
            if (whichSection == "book")
            {
                BookModel editedBookData = new BookModel
                {
                    Name = name_tb.Text,
                    Author = author_tb.Text,
                    Genre = genre_cb.Text
                };
                newEditedData = DataRefactor.BookAddDataRefactor(editedBookData);
            }

            int index = listBox.SelectedIndex;
            listBox.Items.RemoveAt(index);
            sectionManager.InsertEditedDataToList(index, newEditedData, listBox);
        }

        #endregion

        #region Save Data

        private void SaveButtonClick(object sender, EventArgs e)
        {
            GetFilePath();
            FileExistenceControl();
        }

        private void GetFilePath()
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

        private void FileExistenceControl()
        {
            if (listPath == string.Empty)
            {
                CreateFileAndSave();
            }
            else if (listPath != string.Empty)
            {
                SaveLoadManager.SaveList(true, save_button, whichSection, listBox);
            }
        }

        private void CreateFileAndSave()
        {
            savefiledialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            savefiledialog.RestoreDirectory = true;
            savefiledialog.FileName = whichSection + "list";
            savefiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                settingsForm.SetFilePath(whichSection, savefiledialog.FileName);
                settingsForm.SaveSettings();
                GetFilePath();
                SaveLoadManager.SetPaths(listPath);
                SaveLoadManager.SaveList(true, save_button, whichSection, listBox);
            }
            else
            {
                settingsForm.GetAllFilePathsFromProperties();
            }
        }

        private void SaveButtonEnabledChanged(object sender, EventArgs e)
        {
            if (save_button.Enabled == true)
            {
                switch (whichSection)
                {
                    case "movie":
                        serieSectionBtn.Enabled = false;
                        bookSectionBtn.Enabled = false;
                        break;
                    case "serie":
                        movieSectionBtn.Enabled = false;
                        bookSectionBtn.Enabled = false;
                        break;
                    case "book":
                        movieSectionBtn.Enabled = false;
                        serieSectionBtn.Enabled = false;
                        break;
                }
                error_provider.SetError(save_button, "There're unsaved changes in " + whichSection + " list!");
                discard_button.Visible = true;
            }
            if (save_button.Enabled == false)
            {
                movieSectionBtn.Enabled = true;
                serieSectionBtn.Enabled = true;
                bookSectionBtn.Enabled = true;
                error_provider.Clear();
                discard_button.Visible = false;
            }
        }

        #endregion

        #region Discard Data

        private void DiscardButtonClick(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("All changes will discard, Continue ?", "Discard",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirm == DialogResult.OK)
            {
                LoadPreviousFile();
                save_button.Enabled = false;
            }
            else if (confirm == DialogResult.Cancel)
            {
               
            }
        }

        private void LoadPreviousFile()
        {
            switch (whichSection)
            {
                case "movie":
                    movie_listbox.Items.Clear();
                    if (Properties.Settings.Default.movie_path != string.Empty)
                    {
                        SaveLoadManager.LoadList(whichSection, settingsForm, listBox);
                    }
                    break;
                case "serie":
                    serie_listbox.Items.Clear();
                    if (Properties.Settings.Default.serie_path != string.Empty)
                    {
                        SaveLoadManager.LoadList(whichSection, settingsForm, listBox);
                    }
                    break;
                case "book":
                    book_listbox.Items.Clear();
                    if (Properties.Settings.Default.book_path != string.Empty)
                    {
                        SaveLoadManager.LoadList(whichSection, settingsForm, listBox);
                    }
                    break;
            }
        }

        #endregion

        #region Choose and Load ListBox

        private void ChooseAndLoadListbox()
        {
            switch (whichSection)
            {
                case "movie":
                    listBox = movie_listbox;
                    SaveLoadManager.SetPaths(Properties.Settings.Default.movie_path);
                    break;
                case "serie":
                    listBox = serie_listbox;
                    SaveLoadManager.SetPaths(Properties.Settings.Default.serie_path);
                    break;
                case "book":
                    listBox = book_listbox;
                    SaveLoadManager.SetPaths(Properties.Settings.Default.book_path);
                    break;
            }
        }

        #endregion

        #region Settings Form

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }

        #endregion

    }
}
