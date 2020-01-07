using System.Drawing;

namespace later_list
{
    public class ViewManager
    {
        #region variables

        private readonly MainForm mainForm;
        private readonly SettingsForm settingsForm;

        #endregion

        #region Constructor

        public ViewManager(MainForm _mainForm, SettingsForm _settingsForm)
        {
            mainForm = _mainForm;
            settingsForm = _settingsForm;
        }

        #endregion

        #region Section Transition

        public void SectionTransition(MainForm.Sections section)
        {
            mainForm.ListOperationsGB.Text = section + "s";
            LoadGenresToCombobox(section);
            RefreshInputFields();
            AddButtonActive();
            mainForm.SaveButton.Enabled = false;

            if (section == MainForm.Sections.Movie)
            {
                MovieSectionSelected();
            }

            if (section == MainForm.Sections.Serie)
            {
                SerieSectionSelected();
            }

            if (section == MainForm.Sections.Book)
            {
                BookSectionSelected();
            }
        }

        public void TransitionBetweenSectionsActive()
        {
            mainForm.MovieSectionButton.Enabled = true;
            mainForm.SerieSectionButton.Enabled = true;
            mainForm.BookSectionButton.Enabled = true;
        }

        public void TransitionBetweenSecionsDeactive(MainForm.Sections section)
        {
            switch (section)
            {
                case MainForm.Sections.Movie:
                    mainForm.SerieSectionButton.Enabled = false;
                    mainForm.BookSectionButton.Enabled = false;
                    break;
                case MainForm.Sections.Serie:
                    mainForm.MovieSectionButton.Enabled = false;
                    mainForm.BookSectionButton.Enabled = false;
                    break;
                case MainForm.Sections.Book:
                    mainForm.MovieSectionButton.Enabled = false;
                    mainForm.SerieSectionButton.Enabled = false;
                    break;
            }
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
            mainForm.MovieListBox.Visible = true;
            mainForm.SerieListBox.Visible = false;
            mainForm.BookListBox.Visible = false;
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
            mainForm.MovieListBox.Visible = false;
            mainForm.SerieListBox.Visible = true;
            mainForm.BookListBox.Visible = false;
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
            mainForm.MovieListBox.Visible = false;
            mainForm.SerieListBox.Visible = false;
            mainForm.BookListBox.Visible = true;
        }

        #endregion

        public void AddButtonActive()
        {
            mainForm.AddButton.Enabled = true;
            mainForm.RemoveButton.Enabled = false;
            mainForm.EditButton.Enabled = false;
        }

        public void EditRemoveButtonsActive()
        {
            mainForm.AddButton.Enabled = false;
            mainForm.RemoveButton.Enabled = true;
            mainForm.EditButton.Enabled = true;
        }

        public void RefreshInputFields()
        {
            mainForm.NameTextBox.Text = string.Empty;
            mainForm.GenreComboBox.Text = string.Empty;
            mainForm.AuthorTextBox.Text = string.Empty;
        }

        public void InputFieldClicked()
        {
            if (mainForm.NameTextBox.Text == string.Empty && mainForm.GenreComboBox.Text == string.Empty)
            {
                AddButtonActive();
            }
        }

        public void LoadGenresToCombobox(MainForm.Sections section)
        {
            mainForm.GenreComboBox.Items.Clear();
            mainForm.GenreComboBox.Items.AddRange(Genres.GetGenres(section));
        }

        #region Button Clicked

        public void ClearButtonClicked()
        {
            mainForm.MovieListBox.ClearSelected();
            mainForm.SerieListBox.ClearSelected();
            mainForm.BookListBox.ClearSelected();
            RefreshInputFields();
            AddButtonActive();
        }

        public void RemoveButtonClicked()
        {
            mainForm.SaveButton.Enabled = true;
            RefreshInputFields();
        }

        public void EditButtonClicked()
        {
            mainForm.SaveButton.Enabled = true;
            RefreshInputFields();
        }

        public void SettingsButtonClicked()
        {
            settingsForm.ShowDialog();
        }

        #endregion

        #region Theme

        public void LoadThemeForMain()
        {
            ThemeManager.RegisterForm(mainForm);
            ThemeManager.RegisterGroupBox(mainForm.ListOperationsGB);
            ThemeManager.RegisterTextBox(mainForm.NameTextBox);
            ThemeManager.RegisterTextBox(mainForm.AuthorTextBox);
            ThemeManager.RegisterComboBox(mainForm.GenreComboBox);
            ThemeManager.RegisterListBox(mainForm.MovieListBox);
            ThemeManager.RegisterListBox(mainForm.SerieListBox);
            ThemeManager.RegisterListBox(mainForm.BookListBox);
            ThemeManager.RegisterButton(mainForm.ClearButton);
            ThemeManager.RegisterButton(mainForm.AddButton);
            ThemeManager.RegisterButton(mainForm.RemoveButton);
            ThemeManager.RegisterButton(mainForm.EditButton);
            ThemeManager.RegisterButton(mainForm.SaveButton);
            ThemeManager.RegisterButton(mainForm.DiscardButton);
            ThemeManager.CurrrentTheme(settingsForm);
        }

        #endregion
    }
}
