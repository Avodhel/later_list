using System.Drawing;

namespace later_list
{
    public class MainViewHandler : IViewHandler
    {
        #region variables

        private readonly MainForm mainForm;
        private readonly SettingsForm settingsForm;

        #endregion

        #region Constructor

        public MainViewHandler(MainForm _mainForm, SettingsForm _settingsForm)
        {
            mainForm = _mainForm;
            settingsForm = _settingsForm;
        }

        #endregion

        #region Section Transition

        public void SectionTransition(Sections section)
        {
            mainForm.ListOperationsGB.Text = section + "s";
            LoadGenresToCombobox(section);
            RefreshInputFields();
            AddButtonActive();
            mainForm.SaveButton.Enabled = false;

            if (section == Sections.Movie)
            {
                MovieSectionSelected();
            }

            if (section == Sections.Serie)
            {
                SerieSectionSelected();
            }

            if (section == Sections.Book)
            {
                BookSectionSelected();
            }
        }

        public void TransitionBetweenSectionsActive()
        {
            mainForm.MovieSectionButton.Enabled = true;
            mainForm.SerieSectionButton.Enabled = true;
            mainForm.BookSectionButton.Enabled = true;
            mainForm.SettingsButton.Enabled = true;
        }

        public void TransitionBetweenSectionsDeactive()
        {
            mainForm.MovieSectionButton.Enabled = false;
            mainForm.SerieSectionButton.Enabled = false;
            mainForm.BookSectionButton.Enabled = false;
            mainForm.SettingsButton.Enabled = false;
        }

        #endregion

        #region Prepare Section View

        public void MovieSectionSelected()
        {
            //section buttons
            mainForm.MovieSectionButton.BackColor = Colors.SectionButtonActiveColor;
            mainForm.SerieSectionButton.BackColor = Colors.SectionButtonDeactiveColor;
            mainForm.BookSectionButton.BackColor = Colors.SectionButtonDeactiveColor;
            //labels
            mainForm.MovieNameLabel.Visible = true;
            mainForm.SerieNameLabel.Visible = false;
            mainForm.BookNameLabel.Visible = false;
            mainForm.AuthorLabel.Visible = false;
            mainForm.GenreLabel.Location = new Point(43, 47);
            //checkbox
            mainForm.GenreComboBox.Location = new Point(97, 41);
            //textbox
            mainForm.AuthorTextBox.Visible = false;
            //listbox
            mainForm.MovieListView.Visible = true;
            mainForm.SerieListView.Visible = false;
            mainForm.BookListView.Visible = false;
        }

        public void SerieSectionSelected()
        {
            //section buttons
            mainForm.MovieSectionButton.BackColor = Colors.SectionButtonDeactiveColor;
            mainForm.SerieSectionButton.BackColor = Colors.SectionButtonActiveColor;
            mainForm.BookSectionButton.BackColor = Colors.SectionButtonDeactiveColor;
            //labels
            mainForm.MovieNameLabel.Visible = false;
            mainForm.SerieNameLabel.Visible = true;
            mainForm.BookNameLabel.Visible = false;
            mainForm.AuthorLabel.Visible = false;
            mainForm.GenreLabel.Location = new Point(43, 47);
            //checkbox
            mainForm.GenreComboBox.Location = new Point(97, 41);
            //textbox
            mainForm.AuthorTextBox.Visible = false;
            //listbox
            mainForm.MovieListView.Visible = false;
            mainForm.SerieListView.Visible = true;
            mainForm.BookListView.Visible = false;
        }

        public void BookSectionSelected()
        {
            //section buttons
            mainForm.MovieSectionButton.BackColor = Colors.SectionButtonDeactiveColor;
            mainForm.SerieSectionButton.BackColor = Colors.SectionButtonDeactiveColor;
            mainForm.BookSectionButton.BackColor = Colors.SectionButtonActiveColor;
            //labels
            mainForm.MovieNameLabel.Visible = false;
            mainForm.SerieNameLabel.Visible = false;
            mainForm.BookNameLabel.Visible = true;
            mainForm.AuthorLabel.Visible = true;
            mainForm.GenreLabel.Location = new Point(43, 82);
            //checkbox
            mainForm.GenreComboBox.Location = new Point(97, 76);
            //textbox
            mainForm.AuthorTextBox.Visible = true;
            //listbox
            mainForm.MovieListView.Visible = false;
            mainForm.SerieListView.Visible = false;
            mainForm.BookListView.Visible = true;
        }

        #endregion

        #region Button Active/Deactive

        public void ClearButtonActive()
        {
            mainForm.ClearButton.Enabled = true;
            mainForm.ClearButton.BackColor = Colors.ClearButtonActiveColor;
        }

        public void ClearButtonDeactive()
        {
            mainForm.ClearButton.Enabled = false;
            mainForm.ClearButton.BackColor = Colors.OptionButtonsDeactiveColor;
        }

        public void AddButtonActive()
        {
            mainForm.AddButton.Enabled = true;
            mainForm.AddButton.BackColor = Colors.AddButtonActiveColor;
            mainForm.RemoveButton.Enabled = false;
            mainForm.RemoveButton.BackColor = Colors.OptionButtonsDeactiveColor;
            mainForm.EditButton.Enabled = false;
            mainForm.EditButton.BackColor = Colors.OptionButtonsDeactiveColor;
        }

        public void EditRemoveButtonsActive()
        {
            mainForm.AddButton.Enabled = false;
            mainForm.AddButton.BackColor = Colors.OptionButtonsDeactiveColor;
            mainForm.RemoveButton.Enabled = true;
            mainForm.RemoveButton.BackColor = Colors.RemoveButtonActiveColor;
            mainForm.EditButton.Enabled = true;
            mainForm.EditButton.BackColor = Colors.EditButtonActiveColor;
            ClearButtonActive();
        }

        public void SaveButtonActive()
        {
            mainForm.SaveButton.Enabled = true;
            mainForm.SaveButton.BackColor = Colors.SaveListButtonActiveColor;
        }

        public void SaveButtonDeactive()
        {
            mainForm.SaveButton.Enabled = false;
            mainForm.SaveButton.BackColor = Colors.OptionButtonsDeactiveColor;
        }

        #endregion

        #region Input Field

        public void RefreshInputFields()
        {
            mainForm.NameTextBox.Text = string.Empty;
            mainForm.GenreComboBox.Text = string.Empty;
            mainForm.AuthorTextBox.Text = string.Empty;
            ClearButtonDeactive();
        }

        public void InputFieldClicked()
        {
            if (mainForm.NameTextBox.Text == string.Empty && mainForm.GenreComboBox.Text == string.Empty)
            {
                AddButtonActive();
            }
        }

        #endregion

        #region Genres

        public void LoadGenresToCombobox(Sections section)
        {
            mainForm.GenreComboBox.Items.Clear();
            mainForm.GenreComboBox.Items.AddRange(Genres.GetGenres(section));
        }

        #endregion

        #region Button Clicked

        public void ClearButtonClicked()
        {
            mainForm.MovieListView.SelectedItems.Clear();
            mainForm.SerieListView.SelectedItems.Clear();
            mainForm.BookListView.SelectedItems.Clear();
            RefreshInputFields();
            AddButtonActive();
        }

        public void RemoveButtonClicked()
        {
            SaveButtonActive();
            RefreshInputFields();
        }

        public void EditButtonClicked()
        {
            SaveButtonActive();
            RefreshInputFields();
        }

        public void SettingsButtonClicked()
        {
            settingsForm.ShowDialog();
        }

        #endregion

        #region Theme

        public void LoadTheme()
        {
            ThemeHandler.RegisterForm(mainForm);
            ThemeHandler.RegisterGroupBox(mainForm.ListOperationsGB);
            ThemeHandler.RegisterTextBox(mainForm.NameTextBox);
            ThemeHandler.RegisterTextBox(mainForm.AuthorTextBox);
            ThemeHandler.RegisterComboBox(mainForm.GenreComboBox);
            ThemeHandler.RegisterListView(mainForm.MovieListView);
            ThemeHandler.RegisterListView(mainForm.SerieListView);
            ThemeHandler.RegisterListView(mainForm.BookListView);
            ThemeHandler.RegisterButton(mainForm.ClearButton);
            ThemeHandler.RegisterButton(mainForm.AddButton);
            ThemeHandler.RegisterButton(mainForm.RemoveButton);
            ThemeHandler.RegisterButton(mainForm.EditButton);
            ThemeHandler.RegisterButton(mainForm.SaveButton);
            ThemeHandler.RegisterButton(mainForm.DiscardButton);
            ThemeHandler.CurrrentTheme(settingsForm);
        }

        #endregion
    }
}
