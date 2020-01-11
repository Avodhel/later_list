﻿using System;
using System.Windows.Forms;

namespace later_list
{ 
    public partial class MainForm : Form
    {
        #region Variables

        public enum Sections
        {
            Movie,
            Serie,
            Book
        }
        private Sections currentSection;
        private string getExistedData;
        private string listPath;
        private string refactoredData;
        private string newEditedData;
        private ListBox currentListBox = new ListBox();
        private SettingsForm settingsForm = new SettingsForm();
        private DataHandler sectionHandler = new DataHandler();
        private MainViewHandler mViewHandler;

        #endregion

        #region Properties

        public GroupBox ListOperationsGB
        {
            get { return list_operations_gb; }
            set { list_operations_gb = value; }
        }

        public TextBox NameTextBox
        {
            get { return name_tb; }
            set { name_tb = value; }
        }

        public TextBox AuthorTextBox
        {
            get { return author_tb; }
            set { author_tb = value; }
        }

        public ComboBox GenreComboBox
        {
            get { return genre_cb; }
            set { genre_cb = value; }
        }

        public ListBox MovieListBox
        {
            get { return movie_listbox; }
            set { movie_listbox = value; }
        }

        public ListBox SerieListBox
        {
            get { return serie_listbox; }
            set { serie_listbox = value; }
        }

        public ListBox BookListBox
        {
            get { return book_listbox; }
            set { book_listbox = value; }
        }

        public Button AddButton
        {
            get { return add_button; }
            set { add_button = value; }
        }

        public Button ClearButton
        {
            get { return clear_button; }
            set { clear_button = value; }
        }

        public Button RemoveButton
        {
            get { return remove_button; }
            set { remove_button = value; }
        }

        public Button EditButton
        {
            get { return edit_button; }
            set { edit_button = value; }
        }

        public Button SaveButton
        {
            get { return save_button; }
            set { save_button = value; }
        }

        public Button DiscardButton
        {
            get { return discard_button; }
            set { discard_button = value; }
        }

        public Button MovieSectionButton
        {
            get { return movieSectionBtn; }
            set { movieSectionBtn = value; }
        }

        public Button SerieSectionButton
        {
            get { return serieSectionBtn; }
            set { serieSectionBtn = value; }
        }

        public Button BookSectionButton
        {
            get { return bookSectionBtn; }
            set { bookSectionBtn = value; }
        }

        public Label MovieNameLabel
        {
            get { return movie_name_lbl; }
            set { movie_name_lbl = value; }
        }

        public Label SerieNameLabel
        {
            get { return serie_name_lbl; }
            set { serie_name_lbl = value; }
        }

        public Label BookNameLabel
        {
            get { return book_name_lbl; }
            set { book_name_lbl = value; }
        }

        public Label AuthorLabel
        {
            get { return author_lbl; }
            set { author_lbl = value; }
        }

        public Label GenreLabel
        {
            get { return genre_lbl; }
            set { genre_lbl = value; }
        }

        #endregion

        #region Constructors

        public MainForm()
        {
            CenterToScreen();
            InitializeComponent();
            mViewHandler = new MainViewHandler(this, settingsForm);
            SetCurrentListBox();
            SetFilePath();
            settingsForm.GetAllFilePathsFromProperties();   
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            mViewHandler.LoadTheme();
            mViewHandler.LoadGenresToCombobox(currentSection);
            PrepareSection(currentSection);
            SaveLoadHandler.LoadList(currentSection, settingsForm, currentListBox);
        }

        #endregion

        #region Form Close

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveButton.Enabled)
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
            ThemeHandler.UnRegisterForm(this);
        }

        #endregion

        #region Choosing Section

        private void SectionSelected(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "movieSectionBtn":
                    PrepareSection(Sections.Movie);
                    break;
                case "serieSectionBtn":
                    PrepareSection(Sections.Serie);
                    break;
                case "bookSectionBtn":
                    PrepareSection(Sections.Book);
                    break;
            }
        }

        private void PrepareSection(Sections section)
        {
            currentSection = section;
            SetCurrentListBox();
            SetFilePath();
            SaveLoadHandler.LoadList(currentSection, settingsForm, currentListBox);
            mViewHandler.SectionTransition(section);
            //refresh panel scroll
            input_fields_panel.VerticalScroll.Value = 0;
        }

        #endregion

        #region ListBox

        private void SetCurrentListBox()
        {
            if (currentSection == Sections.Movie) currentListBox = MovieListBox;
            if (currentSection == Sections.Serie) currentListBox = SerieListBox;
            if (currentSection == Sections.Book) currentListBox = BookListBox;
        }

        #endregion

        #region File Paths

        private void GetFilePath()
        {
            if (currentSection == Sections.Movie) listPath = Properties.Settings.Default.movie_path;
            if (currentSection == Sections.Serie) listPath = Properties.Settings.Default.serie_path;
            if (currentSection == Sections.Book)  listPath = Properties.Settings.Default.book_path;
        }

        private void SetFilePath()
        {
            if (currentSection == Sections.Movie) SaveLoadHandler.SetPaths(Properties.Settings.Default.movie_path);
            if (currentSection == Sections.Serie) SaveLoadHandler.SetPaths(Properties.Settings.Default.serie_path);
            if (currentSection == Sections.Book)  SaveLoadHandler.SetPaths(Properties.Settings.Default.book_path);
        }

        #endregion

        #region Input Fields

        private void InputFieldsClick(object sender, EventArgs e)
        {
            mViewHandler.InputFieldClicked();
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            mViewHandler.ClearButtonClicked();
        }

        #endregion

        #region Add Data

        bool NameFieldRequireCheck => (NameTextBox.Text != string.Empty) ? true : false;

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (NameFieldRequireCheck)
            {
                AddNewDataToList();
                mViewHandler.RefreshInputFields();
                SaveButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please add a " + currentSection + " name", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SaveButton.Enabled = false;
            }
        }

        private void AddNewDataToList()
        {
            if (currentSection == Sections.Movie)
            {
                AddNewMovie();
            }
            else if (currentSection == Sections.Serie)
            {
                AddNewSerie();
            }
            else if (currentSection == Sections.Book)
            {
                AddNewBook();
            }
        }

        private void AddNewMovie()
        {
            MovieModel newMovieData = new MovieModel(NameTextBox.Text, GenreComboBox.Text);
            refactoredData = DataRefactor.MovieNewDataRefactor(newMovieData);
            sectionHandler.AddDataToList(refactoredData, MovieListBox);
        }

        private void AddNewSerie()
        {
            SerieModel newSerieData = new SerieModel(NameTextBox.Text, GenreComboBox.Text);
            refactoredData = DataRefactor.SerieNewDataRefactor(newSerieData);
            sectionHandler.AddDataToList(refactoredData, SerieListBox);
        }

        private void AddNewBook()
        {
            BookModel newBookData = new BookModel(NameTextBox.Text, AuthorTextBox.Text, GenreComboBox.Text);
            refactoredData = DataRefactor.BookNewDataRefactor(newBookData);
            sectionHandler.AddDataToList(refactoredData, BookListBox);
        }

        #endregion

        #region Remove Data

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            sectionHandler.RemoveDataFromList(currentListBox);
            mViewHandler.RemoveButtonClicked();
        }

        #endregion

        #region Edit Data

        private void EditButtonClick(object sender, EventArgs e)
        {
            SendEditedDataToList();
            mViewHandler.EditButtonClicked();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            mViewHandler.EditRemoveButtonsActive();

            try
            {
                getExistedData = currentListBox.SelectedItem.ToString();
                if (currentSection == Sections.Movie)
                {
                    MovieModel currentMovieData = DataRefactor.MovieExistedDataRefactor(getExistedData);
                    NameTextBox.Text = currentMovieData.Name;
                    GenreComboBox.Text = currentMovieData.Genre;
                }
                if (currentSection == Sections.Serie)
                {
                    SerieModel currentSerieData = DataRefactor.SerieExistedDataRefactor(getExistedData);
                    NameTextBox.Text = currentSerieData.Name;
                    GenreComboBox.Text = currentSerieData.Genre;
                }
                if (currentSection == Sections.Book)
                {
                    BookModel currentBookData = DataRefactor.BookExistedDataRefactor(getExistedData);
                    NameTextBox.Text = currentBookData.Name;
                    AuthorTextBox.Text = currentBookData.Author;
                    GenreComboBox.Text = currentBookData.Genre;
                }
            }
            catch
            {

            }
        }

        private void SendEditedDataToList()
        {
            if (currentSection == Sections.Movie)
            {
                MovieModel editedMovieData = new MovieModel(NameTextBox.Text, GenreComboBox.Text);
                newEditedData = DataRefactor.MovieNewDataRefactor(editedMovieData);
            }
            if (currentSection == Sections.Serie)
            {
                SerieModel editedSerieData = new SerieModel(NameTextBox.Text, GenreComboBox.Text);
                newEditedData = DataRefactor.SerieNewDataRefactor(editedSerieData);
            }
            if (currentSection == Sections.Book)
            {
                BookModel editedBookData = new BookModel(NameTextBox.Text, AuthorTextBox.Text, GenreComboBox.Text);
                newEditedData = DataRefactor.BookNewDataRefactor(editedBookData);
            }

            int index = currentListBox.SelectedIndex;
            currentListBox.Items.RemoveAt(index);
            sectionHandler.InsertEditedDataToList(index, newEditedData, currentListBox);
        }

        #endregion

        #region Save Data

        private void SaveButtonClick(object sender, EventArgs e)
        {
            GetFilePath();
            FileExistenceControl();
        }

        private void FileExistenceControl()
        {
            if (listPath == string.Empty)
            {
                CreateFileAndSave();
            }
            else if (listPath != string.Empty)
            {
                SaveLoadHandler.SaveList(true, SaveButton, currentSection, currentListBox);
            }
        }

        private void CreateFileAndSave()
        {
            savefiledialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            savefiledialog.RestoreDirectory = true;
            savefiledialog.FileName = currentSection + "list";
            savefiledialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                settingsForm.SetFilePath(currentSection, savefiledialog.FileName);
                settingsForm.SaveSettings();
                GetFilePath();
                SaveLoadHandler.SetPaths(listPath);
                SaveLoadHandler.SaveList(true, SaveButton, currentSection, currentListBox);
            }
            else
            {
                settingsForm.GetAllFilePathsFromProperties();
            }
        }

        private void SaveButtonEnabledChanged(object sender, EventArgs e)
        {
            if (SaveButton.Enabled)
            {
                mViewHandler.TransitionBetweenSectionsDeactive(currentSection);
                error_provider.SetError(save_button, "There're unsaved changes in " + currentSection + " list!");
                DiscardButton.Visible = true;
            }
            else
            {
                mViewHandler.TransitionBetweenSectionsActive();
                error_provider.Clear();
                DiscardButton.Visible = false;
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
                LoadPreviousFileVersion();
                SaveButton.Enabled = false;
            }
            else if (confirm == DialogResult.Cancel)
            {
               
            }
        }

        private void LoadPreviousFileVersion()
        {
            currentListBox.Items.Clear();
            SaveLoadHandler.LoadList(currentSection, settingsForm, currentListBox);
        }

        #endregion

        #region Settings Form

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            mViewHandler.SettingsButtonClicked();
        }

        #endregion

    }
}
