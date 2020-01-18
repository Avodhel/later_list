using System.IO;
using System.Windows.Forms;
using later_list.Models;

namespace later_list.Handlers
{
    public static class SaveLoadHandler
    {
        private static string savePath;
        private static string loadPath;

        public static void SetPaths(string filePath)
        {
            savePath = filePath;
            loadPath = filePath;
        }

        #region Save

        public static void SaveList(bool showMessage, Button saveButton, Sections section, ListView listView)
        {
            StreamWriter saveFile = new StreamWriter(savePath);
            foreach (ListViewItem item in listView.Items)
            {
                if (section == Sections.Movie)
                {
                    MovieModel movieData = new MovieModel(item.Text, item.SubItems[1].Text);
                    string formattedData = DataFormatter.MovieNewDataFormatter(movieData);
                    saveFile.WriteLine(formattedData);
                }

                if (section == Sections.Serie)
                {
                    SerieModel serieData = new SerieModel(item.Text, item.SubItems[1].Text);
                    string formattedData = DataFormatter.SerieNewDataFormatter(serieData);
                    saveFile.WriteLine(formattedData);
                }

                if (section == Sections.Book)
                {
                    BookModel bookData = new BookModel(item.Text, item.SubItems[1].Text, item.SubItems[2].Text);
                    string formattedData = DataFormatter.BookNewDataFormatter(bookData);
                    saveFile.WriteLine(formattedData);
                }
            }

            saveFile.Close();

            if (showMessage)
            {
                MessageBox.Show(section + "list saved!");
                showMessage = false;
                saveButton.Enabled = false;
                saveButton.BackColor = Colors.OptionButtonsDeactiveColor;
            }
        }

        #endregion

        #region Load

        public static void LoadList(Sections section, SettingsForm settingsForm, ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (StreamReader loadFile = new StreamReader(loadPath))
                {
                    string line;
                    while ((line = loadFile.ReadLine()) != null)
                    {
                        if (section == Sections.Movie)
                        {
                            MovieModel formattedLine = DataFormatter.MovieExistedDataFormatter(line);
                            string[] row = { formattedLine.Name, formattedLine.Genre };
                            var listViewItem = new ListViewItem(row);
                            listView.Items.Add(listViewItem);
                        }
                        if (section == Sections.Serie)
                        {
                            SerieModel formattedLine = DataFormatter.SerieExistedDataFormatter(line);
                            string[] row = { formattedLine.Name, formattedLine.Genre };
                            var listViewItem = new ListViewItem(row);
                            listView.Items.Add(listViewItem);
                        }
                        if (section == Sections.Book)
                        {
                            BookModel formattedLine = DataFormatter.BookExistedDataFormatter(line);
                            string[] row = { formattedLine.Name, formattedLine.Author, formattedLine.Genre };
                            var listViewItem = new ListViewItem(row);
                            listView.Items.Add(listViewItem);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                NotFoundExceptions(section, settingsForm);
            }
            catch (DirectoryNotFoundException)
            {
                NotFoundExceptions(section, settingsForm);
            }
            catch (System.ArgumentException)
            {

            }
        }

        #endregion

        private static void NotFoundExceptions(Sections section, SettingsForm settingsForm)
        {
            if (section == Sections.Movie && Properties.Settings.Default.movie_path != string.Empty)
            {
                ShowFileNotFoundMsg(section);
                settingsForm.MovieFilePathTextBox.Text = string.Empty;
                Properties.Settings.Default.movie_path = string.Empty;
            }
            else if (section == Sections.Serie && Properties.Settings.Default.serie_path != string.Empty)
            {
                ShowFileNotFoundMsg(section);
                settingsForm.SerieFilePathTextBox.Text = string.Empty;
                Properties.Settings.Default.serie_path = string.Empty;
            }
            else if (section == Sections.Book && Properties.Settings.Default.book_path != string.Empty)
            {
                ShowFileNotFoundMsg(section);
                settingsForm.BookFilePathTextBox.Text = string.Empty;
                Properties.Settings.Default.book_path = string.Empty;
            }
            Properties.Settings.Default.Save();
        }

        private static void ShowFileNotFoundMsg(Sections section)
        {
            MessageBox.Show(section + "list not found.", "File Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
