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
        string which_section = "movie";
        string data;
        //List<string> listbox = new List<string>();
        ListBox listBox = new ListBox();
        string genre_part;
        #endregion

        #region start app
        public watch_list()
        {
            InitializeComponent();
            choose_listbox();
            load_list();
        }
        #endregion

        #region exit from app
        private void watch_list_FormClosing(object sender, FormClosingEventArgs e)
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
        #endregion

        #region choose section
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            if (movie_rb.Checked && !series_rb.Checked && !books_rb.Checked)
            {
                which_section = "movie";
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
                //refresh input fields
                name_tb.Text = "";
                genre_cb.Text = "";
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }
            if (!movie_rb.Checked && series_rb.Checked && !books_rb.Checked)
            {
                which_section = "serie";
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
                //textbox
                name_tb.Text = "";
                genre_cb.Text = "";
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }
            if (!movie_rb.Checked && !series_rb.Checked && books_rb.Checked)
            {
                which_section = "book";
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
                //textbox
                name_tb.Text = "";
                genre_cb.Text = "";
                //enable buttons
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
                save_button.Enabled = false;
            }
        }
        #endregion

        #region input fields
        private void input_fields_Click(object sender, EventArgs e)
        {
            if (name_tb.Text == "" && genre_cb.Text == "")
            {
                add_button.Enabled = true;
                remove_button.Enabled = false;
                edit_button.Enabled = false;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            name_tb.Text = "";
            genre_cb.Text = "";

            //enable buttons
            add_button.Enabled = true;
            remove_button.Enabled = false;
            edit_button.Enabled = false;
        }
        #endregion

        #region add
        private void add_button_Click(object sender, EventArgs e)
        {
            save_button.Enabled = true;

            if (name_tb.Text == "")
            {
                MessageBox.Show("Please add a " + which_section + " name", "Error",
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
            switch (which_section)
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
        #endregion

        #region remove
        private void remove_button_Click(object sender, EventArgs e)
        {
            save_button.Enabled = true;

            listBox.Items.Remove(listBox.SelectedItem);
            //refresh input fields
            name_tb.Text = "";
            genre_cb.Text = "";
        }
        #endregion

        #region edit
        private void selectedIndexChanged(object sender, EventArgs e)
        {
            add_button.Enabled = false;
            remove_button.Enabled = true;
            edit_button.Enabled = true;

            try
            {
                //name_tb.Text = listBox.SelectedItem.ToString();
                string get_info = listBox.SelectedItem.ToString();
                string name_part = get_info.Split('(')[0];
                name_part = name_part.TrimEnd(' ');

                try
                {
                    genre_part = get_info.Split('(')[1];
                    genre_part = genre_part.TrimEnd(')');
                }
                catch
                {
                    genre_part = "";
                }
                name_tb.Text = name_part;
                genre_cb.Text = genre_part;
            }
            catch
            {

            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            save_button.Enabled = true;

            int index = listBox.SelectedIndex;
            listBox.Items.RemoveAt(index);
            listBox.Items.Insert(index, name_tb.Text + " (" + genre_cb.Text + ")");
            //refresh input fields
            name_tb.Text = "";
            genre_cb.Text = "";
        }
        #endregion

        #region save
        private void save_button_Click(object sender, EventArgs e)
        {
            save_list(true);
        }
        #endregion

        #region save and load system
        private void choose_listbox()
        {
            listBox.Items.Clear();
            switch (which_section)
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
        
        private void save_list(bool show_message)
        {
            string sPath = which_section + "list.txt";

            StreamWriter saveFile = new StreamWriter(sPath);
            foreach (var item in listBox.Items)
            {
                saveFile.WriteLine(item);
            }

            saveFile.Close();

            if (show_message)
            {
                MessageBox.Show(which_section + " list saved!");
                show_message = false;
                save_button.Enabled = false;
            }
        }
        
        private void load_list()
        {
            string file_path = which_section + "list.txt";

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
                MessageBox.Show("There isn't a " + which_section + " list.", "File Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
