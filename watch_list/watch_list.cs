using System;
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
        //List<string> MovieList = new List<string>();
        #endregion

        public watch_list()
        {
            InitializeComponent();
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
            }
        }
    }
}
