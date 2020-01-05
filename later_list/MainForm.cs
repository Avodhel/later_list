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
    public partial class MainForm : Form, IForm
    {
        #region variables
        private string whichSection = "movie";
        private string data;
        private string getExistedData;
        private string namePart;
        private string authorPart;
        private string genrePart;
        private string listPath;
        private bool addToListControl = true;
        private ListBox listBox = new ListBox();
        private SettingsForm settingsForm = new SettingsForm();
        #endregion

        #region start app
        public MainForm()
        {
            this.CenterToScreen();
            InitializeComponent();
            ChooseAndLoadListbox();
            LoadGenres();
            if (whichSection == "movie" && Properties.Settings.Default.movie_path != "")
            {
                SaveLoadManager.LoadList(whichSection, settingsForm, listBox);
            }
            settingsForm.GetSettings();
            
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

        #region exit from app
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

        #region choose section
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

        #region input fields
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
            genre_cb.Items.AddRange(DataManager.GetGenreList(whichSection));
        }
        #endregion

        #region add
        private void AddButtonClick(object sender, EventArgs e)
        {
            NameFieldCheck();
            PrepareDataToAdd();
        }

        private void NameFieldCheck()
        {
            if (name_tb.Text != string.Empty)
            {
                save_button.Enabled = true;
                addToListControl = true;
            }
            else if (name_tb.Text == string.Empty)
            {
                MessageBox.Show("Please add a " + whichSection + " name", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                save_button.Enabled = false;
                addToListControl = false;
            }
        }

        private void PrepareDataToAdd()
        {
            if (whichSection != "book" && addToListControl)
            {
                data = name_tb.Text + " (" + genre_cb.Text + ")";
                AddToList(data);
                RefreshInputFields();
            }
            else if (whichSection == "book" && addToListControl)
            {
                data = name_tb.Text + " - " + author_tb.Text + " (" + genre_cb.Text + ")";
                AddToList(data);
                RefreshInputFields();
            }
        }

        private void AddToList(string data)
        {
            switch (whichSection)
            {
                case "movie":
                    movie_listbox.Items.Add(data);
                    break;
                case "serie":
                    serie_listbox.Items.Add(data);
                    break;
                case "book":
                    book_listbox.Items.Add(data);
                    break;
            }
        }
        #endregion

        #region remove
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            save_button.Enabled = true;

            listBox.Items.Remove(listBox.SelectedItem);
            //refresh input fields
            RefreshInputFields();
        }
        #endregion

        #region edit
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            add_button.Enabled = false;
            remove_button.Enabled = true;
            edit_button.Enabled = true;

            try
            {
                getExistedData = listBox.SelectedItem.ToString();        
                if (whichSection != "book")
                {
                    namePart = getExistedData.Split('(')[0];
                }
                else if (whichSection == "book")
                {
                    namePart = getExistedData.Split('-')[0];
                    authorPart = getExistedData.Split('-')[1];
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
                        authorPart = string.Empty;
                    }
                }

                try
                {
                    genrePart = getExistedData.Split('(')[1];
                    genrePart = genrePart.TrimEnd(')');
                }
                catch
                {
                    genrePart = string.Empty;
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

        private void EditButtonClick(object sender, EventArgs e)
        {
            save_button.Enabled = true;
            int index = listBox.SelectedIndex;
            listBox.Items.RemoveAt(index);
            PrepareDataToEdit(index);
            RefreshInputFields();
        }

        private void PrepareDataToEdit(int index)
        {
            if (whichSection != "book")
            {
                listBox.Items.Insert(index, name_tb.Text + " (" + genre_cb.Text + ")");
            }
            else if (whichSection == "book")
            {
                listBox.Items.Insert(index, name_tb.Text + " - " + author_tb.Text + " (" + genre_cb.Text + ")");
            }
        }
        #endregion

        #region save
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
                settingsForm.GetSettings();
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

        #region discard
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

        #region choose and load listbox
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

        #region settings form
        private void SettingsButtonClick(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }
        #endregion
    }
}
