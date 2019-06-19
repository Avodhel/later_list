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

namespace watch_list
{ 
    public partial class watch_list : Form
    {
        #region variables
        string which_genre = "movie";
        string data;
        //List<string> listbox = new List<string>();
        ListBox listBox = new ListBox();
        #endregion

        public watch_list()
        {
            InitializeComponent();
            choose_listbox();
            load_list();
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            if (movie_rb.Checked && !series_rb.Checked && !books_rb.Checked)
            {
                which_genre = "movie";
                //labels
                movie_name_lbl.Visible = true;
                serie_name_lbl.Visible = false;
                book_name_lbl.Visible = false;
                //listbox
                movie_listbox.Visible = true;
                serie_listbox.Visible = false;
                book_listbox.Visible = false;
                //load list
                choose_listbox();
                load_list();
            }
            if (!movie_rb.Checked && series_rb.Checked && !books_rb.Checked)
            {
                which_genre = "serie";
                //labels
                movie_name_lbl.Visible = false;
                serie_name_lbl.Visible = true;
                book_name_lbl.Visible = false;
                //listbox
                movie_listbox.Visible = false;
                serie_listbox.Visible = true;
                book_listbox.Visible = false;
                //load list
                choose_listbox();
                load_list();
            }
            if (!movie_rb.Checked && !series_rb.Checked && books_rb.Checked)
            {
                which_genre = "book";
                //labels
                movie_name_lbl.Visible = false;
                serie_name_lbl.Visible = false;
                book_name_lbl.Visible = true;
                //listbox
                movie_listbox.Visible = false;
                serie_listbox.Visible = false;
                book_listbox.Visible = true;
                //load list
                choose_listbox();
                load_list();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (name_tb.Text == "")
            {
                MessageBox.Show("Please add a " + which_genre + " name", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data = name_tb.Text + " (" + genre_cb.Text + ")";
                addToList(data);
                name_tb.Text = "";
                genre_cb.Text = "";
            }
        }

        private void addToList(string info)
        {
            switch (which_genre)
            {
                case "movie":
                    movie_listbox.Items.Add(info);
                    break;
                case "serie":
                    serie_listbox.Items.Add(info);
                    break;
                case "book":
                    book_listbox.Items.Add(info);
                    break;
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            save_list();
        }

        #region save and load system

        private void choose_listbox()
        {
            listBox.Items.Clear();
            switch (which_genre)
            {
                case "movie":
                    listBox = movie_listbox;
                    break;
                case "serie":
                    listBox = serie_listbox;
                    break;
                case "book":
                    listBox = book_listbox;
                    break;
            }
        }
        
        private void save_list()
        {
            string sPath = which_genre + "list.txt";

            StreamWriter saveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox.Items)
            {
                saveFile.WriteLine(item);
            }

            saveFile.Close();

            MessageBox.Show(which_genre + " list saved!");
        }

        private void load_list()
        {
            //OpenFileDialog f = new OpenFileDialog();
            //listBox.Items.Clear();

            List<string> lines = new List<string>();
            string file_path = which_genre + "list.txt";

            try
            {
                using (StreamReader loadFile = new StreamReader(file_path))
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
                MessageBox.Show("There isn't a " + which_genre + " list.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
