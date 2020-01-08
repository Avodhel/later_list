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

        public static void SaveList(bool show_message, Button save_button, MainForm.Sections section, ListBox listBox)
        {
            StreamWriter saveFile = new StreamWriter(savePath);
            foreach (var item in listBox.Items)
            {
                saveFile.WriteLine(item);
            }

            saveFile.Close();

            if (show_message)
            {
                MessageBox.Show(section + " list saved!");
                show_message = false;
                save_button.Enabled = false;
            }
        }

        public static void LoadList(MainForm.Sections section, SettingsForm settingsForm, ListBox listBox)
        {
            try
            {
                listBox.Items.Clear();
                if (loadPath != string.Empty)
                {
                    using (StreamReader loadFile = new StreamReader(loadPath))
                    {
                        string line;
                        while ((line = loadFile.ReadLine()) != null)
                        {
                            listBox.Items.Add(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
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
        }

        private static void ShowFileNotFoundMsg(MainForm.Sections section)
        {
            MessageBox.Show(section + "list not found.", "File Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
