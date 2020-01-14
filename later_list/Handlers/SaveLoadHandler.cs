using System.IO;
using System.Windows.Forms;

namespace later_list
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

        public static void SaveList(bool showMessage, Button saveButton, MainForm.Sections section, ListView listView)
        {
            StreamWriter saveFile = new StreamWriter(savePath);
            foreach (ListViewItem item in listView.Items)
            {
                if (section == MainForm.Sections.Movie)
                {
                    MovieModel mv = new MovieModel(item.Text, item.SubItems[1].Text);
                    string formattedData = DataFormatter.MovieNewDataFormatter(mv);
                    saveFile.WriteLine(formattedData);
                }

                if (section == MainForm.Sections.Serie)
                {
                    SerieModel sv = new SerieModel(item.Text, item.SubItems[1].Text);
                    string formattedData = DataFormatter.SerieNewDataFormatter(sv);
                    saveFile.WriteLine(formattedData);
                }

                if (section == MainForm.Sections.Book)
                {
                    BookModel bv = new BookModel(item.Text, item.SubItems[1].Text, item.SubItems[2].Text);
                    string formattedData = DataFormatter.BookNewDataFormatter(bv);
                    saveFile.WriteLine(formattedData);
                }
            }

            saveFile.Close();

            if (showMessage)
            {
                MessageBox.Show(section + "list saved!");
                showMessage = false;
                saveButton.Enabled = false;
            }
        }

        #endregion

        #region Load

        public static void LoadList(MainForm.Sections section, SettingsForm settingsForm, ListView listView)
        {
            try
            {
                listView.Items.Clear();
                using (StreamReader loadFile = new StreamReader(loadPath))
                {
                    string line;
                    while ((line = loadFile.ReadLine()) != null)
                    {
                        if (section == MainForm.Sections.Movie)
                        {
                            MovieModel formattedLine = DataFormatter.MovieExistedDataFormatter(line);
                            string[] row = { formattedLine.Name, formattedLine.Genre };
                            var listViewItem = new ListViewItem(row);
                            listView.Items.Add(listViewItem);
                        }
                        if (section == MainForm.Sections.Serie)
                        {
                            SerieModel formattedLine = DataFormatter.SerieExistedDataFormatter(line);
                            string[] row = { formattedLine.Name, formattedLine.Genre };
                            var listViewItem = new ListViewItem(row);
                            listView.Items.Add(listViewItem);
                        }
                        if (section == MainForm.Sections.Book)
                        {
                            BookModel formattedLine = DataFormatter.BookExistedDataFormatter(line);
                            string[] row = { formattedLine.Name, formattedLine.Author, formattedLine.Genre };
                            var listViewItem = new ListViewItem(row);
                            listView.Items.Add(listViewItem);
                        }
                        listView.Sorting = SortOrder.Ascending;
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

        private static void NotFoundExceptions(MainForm.Sections section, SettingsForm settingsForm)
        {
            if (section == MainForm.Sections.Movie && Properties.Settings.Default.movie_path != string.Empty)
            {
                ShowFileNotFoundMsg(section);
                settingsForm.MovieFilePathTextBox.Text = string.Empty;
                Properties.Settings.Default.movie_path = string.Empty;
            }
            else if (section == MainForm.Sections.Serie && Properties.Settings.Default.serie_path != string.Empty)
            {
                ShowFileNotFoundMsg(section);
                settingsForm.SerieFilePathTextBox.Text = string.Empty;
                Properties.Settings.Default.serie_path = string.Empty;
            }
            else if (section == MainForm.Sections.Book && Properties.Settings.Default.book_path != string.Empty)
            {
                ShowFileNotFoundMsg(section);
                settingsForm.BookFilePathTextBox.Text = string.Empty;
                Properties.Settings.Default.book_path = string.Empty;
            }
            Properties.Settings.Default.Save();
        }

        private static void ShowFileNotFoundMsg(MainForm.Sections section)
        {
            MessageBox.Show(section + "list not found.", "File Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
