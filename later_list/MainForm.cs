using System;
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
        private ListBox listBox = new ListBox();
        private SettingsForm settingsForm = new SettingsForm();
        private DataManager sectionManager = new DataManager();
        private ViewManager viewManager;

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
            viewManager = new ViewManager(this, settingsForm);
            CenterToScreen();
            InitializeComponent();
            ChooseAndLoadListbox();
            viewManager.LoadGenresToCombobox(currentSection);
            SaveLoadManager.LoadList(currentSection, settingsForm, listBox);
            settingsForm.GetAllFilePathsFromProperties();   
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            PrepareSection(currentSection);
            viewManager.LoadThemeForMain();
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
            //refresh panel scroll
            input_fields_panel.VerticalScroll.Value = 0;
            //load list
            ChooseAndLoadListbox();
            //load data file
            SaveLoadManager.LoadList(currentSection, settingsForm, listBox);
            //prepare section view
            viewManager.SectionTransition(section);

            if (section == Sections.Movie)
            {
                viewManager.MovieSectionSelected();
            }

            if (section == Sections.Serie)
            {
                viewManager.SerieSectionSelected();
            }

            if (section == Sections.Book)
            {
                viewManager.BookSectionSelected();
            }
        }

        #endregion

        #region Choose and Load ListBox

        private void ChooseAndLoadListbox()
        {
            switch (currentSection)
            {
                case Sections.Movie:
                    listBox = MovieListBox;
                    SaveLoadManager.SetPaths(Properties.Settings.Default.movie_path);
                    break;
                case Sections.Serie:
                    listBox = SerieListBox;
                    SaveLoadManager.SetPaths(Properties.Settings.Default.serie_path);
                    break;
                case Sections.Book:
                    listBox = BookListBox;
                    SaveLoadManager.SetPaths(Properties.Settings.Default.book_path);
                    break;
            }
        }

        #endregion

        #region Input Fields

        private void InputFieldsClick(object sender, EventArgs e)
        {
            viewManager.InputFieldClicked();
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            viewManager.ClearButtonClicked();
        }

        #endregion

        #region Add Data

        bool NameFieldRequireCheck => (NameTextBox.Text != string.Empty) ? true : false;

        private void AddButtonClick(object sender, EventArgs e)
        {
            if (NameFieldRequireCheck)
            {
                AddNewDataToList();
                viewManager.RefreshInputFields();
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
            sectionManager.AddDataToList(refactoredData, MovieListBox);
        }

        private void AddNewSerie()
        {
            SerieModel newSerieData = new SerieModel(NameTextBox.Text, GenreComboBox.Text);
            refactoredData = DataRefactor.SerieNewDataRefactor(newSerieData);
            sectionManager.AddDataToList(refactoredData, SerieListBox);
        }

        private void AddNewBook()
        {
            BookModel newBookData = new BookModel(NameTextBox.Text, AuthorTextBox.Text, GenreComboBox.Text);
            refactoredData = DataRefactor.BookNewDataRefactor(newBookData);
            sectionManager.AddDataToList(refactoredData, BookListBox);
        }

        #endregion

        #region Remove Data

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            sectionManager.RemoveDataFromList(listBox);
            viewManager.RemoveButtonClicked();
        }

        #endregion

        #region Edit Data

        private void EditButtonClick(object sender, EventArgs e)
        {
            SendEditedDataToList();
            viewManager.EditButtonClicked();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            viewManager.EditRemoveButtonsActive();

            try
            {
                getExistedData = listBox.SelectedItem.ToString();
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
            switch (currentSection)
            {
                case Sections.Movie:
                    listPath = Properties.Settings.Default.movie_path;
                    break;
                case Sections.Serie:
                    listPath = Properties.Settings.Default.serie_path;
                    break;
                case Sections.Book:
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
                SaveLoadManager.SaveList(true, save_button, currentSection, listBox);
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
                SaveLoadManager.SetPaths(listPath);
                SaveLoadManager.SaveList(true, save_button, currentSection, listBox);
            }
            else
            {
                settingsForm.GetAllFilePathsFromProperties();
            }
        }

        private void SaveButtonEnabledChanged(object sender, EventArgs e)
        {
            if (SaveButton.Enabled == true)
            {
                viewManager.TransitionBetweenSecionsDeactive(currentSection);
                error_provider.SetError(save_button, "There're unsaved changes in " + currentSection + " list!");
                DiscardButton.Visible = true;
            }
            if (save_button.Enabled == false)
            {
                viewManager.TransitionBetweenSectionsActive();
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
            switch (currentSection)
            {
                case Sections.Movie:
                    MovieListBox.Items.Clear();
                    break;
                case Sections.Serie:
                    SerieListBox.Items.Clear();
                    break;
                case Sections.Book:
                    BookListBox.Items.Clear();
                    break;
            }
            SaveLoadManager.LoadList(currentSection, settingsForm, listBox);
        }

        #endregion

        #region Settings Form

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            viewManager.SettingsButtonClicked();
        }

        #endregion

    }
}
