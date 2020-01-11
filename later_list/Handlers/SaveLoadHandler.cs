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

        public static void SaveList(bool showMessage, Button saveButton, MainForm.Sections section, ListBox listBox)
        {
            StreamWriter saveFile = new StreamWriter(savePath);
            foreach (var item in listBox.Items)
            {
                saveFile.WriteLine(item);
            }

            saveFile.Close();

            if (showMessage)
            {
                MessageBox.Show(section + "list saved!");
                showMessage = false;
                saveButton.Enabled = false;
            }
        }

        public static void LoadList(MainForm.Sections section, SettingsForm settingsForm, ListBox listBox)
        {
            try
            {
                listBox.Items.Clear();
                using (StreamReader loadFile = new StreamReader(loadPath))
                {
                    string line;
                    while ((line = loadFile.ReadLine()) != null)
                    {
                        listBox.Items.Add(line);
                        listBox.Sorted = true;
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
