using System;
using System.Windows.Forms;
using later_list.Handlers;

namespace later_list
{ 
    public partial class MainForm : Form
    {
        #region Variables

        private Sections currentSection;
        private string listPath;
        private ListViewItem newData;
        private ListViewItem newEditedData;
        private ListView currentListView = new ListView();
        private SettingsForm settingsForm = new SettingsForm();
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

        public ListView MovieListView
        {
            get { return movie_listview; }
            set { movie_listview = value; }
        }

        public ListView SerieListView
        {
            get { return serie_listview; }
            set { serie_listview = value; }
        }

        public ListView BookListView
        {
            get { return book_listview; }
            set { book_listview = value; }
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

        public Button SettingsButton
        {
            get { return settings_button; }
            set { settings_button = value; }
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
            //CenterToScreen();
            InitializeComponent();
            mViewHandler = new MainViewHandler(this, settingsForm);
            SetCurrentListView();
            SetFilePath();
            settingsForm.GetAllFilePathsFromProperties();   
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            mViewHandler.LoadTheme();
            mViewHandler.LoadGenresToCombobox(currentSection);
            PrepareSection(currentSection);
            SaveLoadHandler.LoadList(currentSection, settingsForm, currentListView);
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
            input_fields_panel.VerticalScroll.Value = 0;
            currentSection = section;
            SetCurrentListView();
            SetFilePath();
            SaveLoadHandler.LoadList(currentSection, settingsForm, currentListView);
            mViewHandler.SectionTransition(section);
        }

        #endregion

        #region ListView

        private void SetCurrentListView()
        {
            if (currentSection == Sections.Movie) currentListView = MovieListView;
            if (currentSection == Sections.Serie) currentListView = SerieListView;
            if (currentSection == Sections.Book) currentListView = BookListView;
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

        private void InputTextChanged(object sender, EventArgs e)
        {
            mViewHandler.ClearButtonActive();
        }

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

        private void AddButtonClick(object sender, EventArgs e)
        {
            NameFieldState();
        }

        private void NameFieldState()
        {
            if (ErrorHandler.NameFieldRequireCheck(NameTextBox.Text))
            {
                AddNewDataToList();
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
            if (currentSection == Sections.Movie) AddNewMovie();
            if (currentSection == Sections.Serie) AddNewSerie();
            if (currentSection == Sections.Book) AddNewBook();
        }

        private void AddNewMovie()
        {
            string[] row = { NameTextBox.Text, GenreComboBox.Text };
            newData = new ListViewItem(row);
            DuplicateState();
        }

        private void AddNewSerie()
        {
            string[] row = { NameTextBox.Text, GenreComboBox.Text };
            newData = new ListViewItem(row);
            DuplicateState();
        }

        private void AddNewBook()
        {
            string[] row = { NameTextBox.Text, AuthorTextBox.Text, GenreComboBox.Text };
            newData = new ListViewItem(row);
            DuplicateState();
        }

        private void DuplicateState()
        {
            if (ErrorHandler.DuplicateCheck(currentListView.FindItemWithText(NameTextBox.Text)))
            {
                MessageBox.Show(NameTextBox.Text + " is already in " + currentSection + "list.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mViewHandler.SaveButtonDeactive();
            }
            else
            {
                DataHandler.AddDataToList(newData, currentListView);
                mViewHandler.RefreshInputFields();
                mViewHandler.SaveButtonActive();
            }
        }

        #endregion

        #region Remove Data

        private void RemoveButtonClick(object sender, EventArgs e)
        {
            DataHandler.RemoveDataFromList(currentListView);
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
                if (currentSection == Sections.Movie)
                {
                    NameTextBox.Text = currentListView.SelectedItems[0].SubItems[0].Text;
                    GenreComboBox.Text = currentListView.SelectedItems[0].SubItems[1].Text;
                }
                if (currentSection == Sections.Serie)
                {
                    NameTextBox.Text = currentListView.SelectedItems[0].SubItems[0].Text;
                    GenreComboBox.Text = currentListView.SelectedItems[0].SubItems[1].Text;
                }
                if (currentSection == Sections.Book)
                {
                    NameTextBox.Text = currentListView.SelectedItems[0].SubItems[0].Text;
                    AuthorTextBox.Text = currentListView.SelectedItems[0].SubItems[1].Text;
                    GenreComboBox.Text = currentListView.SelectedItems[0].SubItems[2].Text;
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
                string[] row = { NameTextBox.Text, GenreComboBox.Text };
                newEditedData = new ListViewItem(row);
            }
            if (currentSection == Sections.Serie)
            {
                string[] row = { NameTextBox.Text, GenreComboBox.Text };
                newEditedData = new ListViewItem(row);
            }
            if (currentSection == Sections.Book)
            {
                string[] row = { NameTextBox.Text, AuthorTextBox.Text, GenreComboBox.Text };
                newEditedData = new ListViewItem(row);
            }

            var index = currentListView.SelectedIndices[0];
            currentListView.Items.RemoveAt(index);
            DataHandler.InsertEditedDataToList(index, newEditedData, currentListView);
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
                SaveLoadHandler.SaveList(true, SaveButton, currentSection, currentListView);
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
                SaveLoadHandler.SaveList(true, SaveButton, currentSection, currentListView);
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
                mViewHandler.TransitionBetweenSectionsDeactive();
                error_provider.SetError(SaveButton, "There're unsaved changes in " + currentSection + " list!");
                DiscardButton.Visible = true;
            }
            else
            {
                mViewHandler.TransitionBetweenSectionsActive();
                error_provider.SetError(SaveButton, string.Empty); //use this instead clear()
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
                mViewHandler.AddButtonActive();
                mViewHandler.SaveButtonDeactive();
            }
            else if (confirm == DialogResult.Cancel)
            {
               
            }
        }

        private void LoadPreviousFileVersion()
        {
            currentListView.Items.Clear();
            SaveLoadHandler.LoadList(currentSection, settingsForm, currentListView);
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
