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
        public static string savePath;
        public static string loadPath;

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
                if (whichSection == "movie" && Properties.Settings.Default.movie_path != "")
                {
                    ShowFileNotFoundMsg(whichSection);
                    settingsForm.MovieTextBoxText = String.Empty;
                    Properties.Settings.Default.movie_path = String.Empty;
                }
                else if (whichSection == "serie" && Properties.Settings.Default.serie_path != "")
                {
                    ShowFileNotFoundMsg(whichSection);
                    settingsForm.SerieTextBoxText = String.Empty;
                    Properties.Settings.Default.serie_path = String.Empty;
                }
                else if (whichSection == "book" && Properties.Settings.Default.book_path != "")
                {
                    ShowFileNotFoundMsg(whichSection);
                    settingsForm.BookTextBoxText = String.Empty;
                    Properties.Settings.Default.book_path = String.Empty;
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
