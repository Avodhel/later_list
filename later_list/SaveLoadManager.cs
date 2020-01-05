using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace later_list
{
    public static class SaveLoadManager
    {
        private static string savePath;
        private static string loadPath;

        public static void SetPaths(string filePath)
        {
            savePath = filePath;
            loadPath = filePath;
        }

        public static void SaveList(bool show_message, Button save_button, string whichSection, ListBox listBox)
        {
            StreamWriter saveFile = new StreamWriter(savePath);
            foreach (var item in listBox.Items)
            {
                saveFile.WriteLine(item);
            }

            saveFile.Close();

            if (show_message)
            {
                MessageBox.Show(whichSection + " list saved!");
                show_message = false;
                save_button.Enabled = false;
            }
        }

        public static void LoadList(string whichSection, SettingsForm settingsForm, ListBox listBox)
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
                    }
                }
            }
            catch (FileNotFoundException)
            {
                if (whichSection == "movie" && Properties.Settings.Default.movie_path != string.Empty)
                {
                    ShowFileNotFoundMsg(whichSection);
                    settingsForm.MovieFilePathText = string.Empty;
                    Properties.Settings.Default.movie_path = string.Empty;
                }
                else if (whichSection == "serie" && Properties.Settings.Default.serie_path != string.Empty)
                {
                    ShowFileNotFoundMsg(whichSection);
                    settingsForm.SerieFilePathText = string.Empty;
                    Properties.Settings.Default.serie_path = string.Empty;
                }
                else if (whichSection == "book" && Properties.Settings.Default.book_path != string.Empty)
                {
                    ShowFileNotFoundMsg(whichSection);
                    settingsForm.BookFilePathText = string.Empty;
                    Properties.Settings.Default.book_path = string.Empty;
                }
                Properties.Settings.Default.Save();
            }
        }

        private static void ShowFileNotFoundMsg(string whichSection)
        {
            MessageBox.Show(whichSection + " list not found.", "File Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
