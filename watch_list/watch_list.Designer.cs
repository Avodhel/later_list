namespace watch_list
{
    partial class watch_list
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_button = new System.Windows.Forms.Button();
            this.movie_listbox = new System.Windows.Forms.ListBox();
            this.movie_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.movie_name_tb = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.genre_label = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(15, 105);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(261, 26);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // movie_listbox
            // 
            this.movie_listbox.Location = new System.Drawing.Point(282, 36);
            this.movie_listbox.Name = "movie_listbox";
            this.movie_listbox.Size = new System.Drawing.Size(261, 160);
            this.movie_listbox.TabIndex = 8;
            // 
            // movie_label
            // 
            this.movie_label.AutoSize = true;
            this.movie_label.Location = new System.Drawing.Point(12, 40);
            this.movie_label.Name = "movie_label";
            this.movie_label.Size = new System.Drawing.Size(70, 13);
            this.movie_label.TabIndex = 4;
            this.movie_label.Text = "Movie Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Fiction",
            "Science Fiction"});
            this.comboBox1.Location = new System.Drawing.Point(88, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // movie_name_tb
            // 
            this.movie_name_tb.Location = new System.Drawing.Point(88, 36);
            this.movie_name_tb.Name = "movie_name_tb";
            this.movie_name_tb.Size = new System.Drawing.Size(188, 20);
            this.movie_name_tb.TabIndex = 10;
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(15, 137);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(261, 28);
            this.remove_button.TabIndex = 11;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(12, 81);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(39, 13);
            this.genre_label.TabIndex = 12;
            this.genre_label.Text = "Genre:";
            this.genre_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(15, 171);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(261, 28);
            this.edit_button.TabIndex = 13;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // watch_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 229);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.movie_name_tb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.movie_label);
            this.Controls.Add(this.movie_listbox);
            this.Controls.Add(this.add_button);
            this.Name = "watch_list";
            this.Text = "Watch_List_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListBox movie_listbox;
        private System.Windows.Forms.Label movie_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox movie_name_tb;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Button edit_button;
    }
}

