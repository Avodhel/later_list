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
        string data;
        //List<string> MovieList = new List<string>();

        public watch_list()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (movie_name_tb.Text == "")
            {
                MessageBox.Show("Please Add a Movie name", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                data = movie_name_tb.Text + " (" + comboBox1.Text + ")";
                addToList(data);
                movie_name_tb.Text = "";
                comboBox1.Text = "";
            }
        }

        private void addToList(string movie_info)
        {
            //MovieList.Add(movie_info);
            movie_listbox.Items.Add(movie_info);
        }
    }
}
