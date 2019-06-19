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
            this.movie_name_lbl = new System.Windows.Forms.Label();
            this.genre_cb = new System.Windows.Forms.ComboBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.genre_label = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.book_name_lbl = new System.Windows.Forms.Label();
            this.serie_name_lbl = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.books_rb = new System.Windows.Forms.RadioButton();
            this.series_rb = new System.Windows.Forms.RadioButton();
            this.movie_rb = new System.Windows.Forms.RadioButton();
            this.serie_listbox = new System.Windows.Forms.ListBox();
            this.book_listbox = new System.Windows.Forms.ListBox();
            this.movie_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_button.Location = new System.Drawing.Point(6, 64);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(261, 26);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // movie_listbox
            // 
            this.movie_listbox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_listbox.ItemHeight = 15;
            this.movie_listbox.Location = new System.Drawing.Point(277, 9);
            this.movie_listbox.Name = "movie_listbox";
            this.movie_listbox.Size = new System.Drawing.Size(261, 154);
            this.movie_listbox.TabIndex = 8;
            // 
            // movie_name_lbl
            // 
            this.movie_name_lbl.AutoSize = true;
            this.movie_name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movie_name_lbl.Location = new System.Drawing.Point(3, 12);
            this.movie_name_lbl.Name = "movie_name_lbl";
            this.movie_name_lbl.Size = new System.Drawing.Size(74, 15);
            this.movie_name_lbl.TabIndex = 4;
            this.movie_name_lbl.Text = "Movie Name:";
            // 
            // genre_cb
            // 
            this.genre_cb.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_cb.FormattingEnabled = true;
            this.genre_cb.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Fiction",
            "Science Fiction"});
            this.genre_cb.Location = new System.Drawing.Point(79, 37);
            this.genre_cb.Name = "genre_cb";
            this.genre_cb.Size = new System.Drawing.Size(185, 24);
            this.genre_cb.TabIndex = 6;
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(79, 9);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(188, 20);
            this.name_tb.TabIndex = 10;
            // 
            // remove_button
            // 
            this.remove_button.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.remove_button.Location = new System.Drawing.Point(6, 96);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(261, 28);
            this.remove_button.TabIndex = 11;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genre_label.Location = new System.Drawing.Point(3, 40);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(41, 15);
            this.genre_label.TabIndex = 12;
            this.genre_label.Text = "Genre:";
            this.genre_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(6, 130);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(261, 28);
            this.edit_button.TabIndex = 13;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // movie_panel
            // 
            this.movie_panel.Controls.Add(this.book_listbox);
            this.movie_panel.Controls.Add(this.serie_listbox);
            this.movie_panel.Controls.Add(this.book_name_lbl);
            this.movie_panel.Controls.Add(this.serie_name_lbl);
            this.movie_panel.Controls.Add(this.movie_name_lbl);
            this.movie_panel.Controls.Add(this.edit_button);
            this.movie_panel.Controls.Add(this.genre_label);
            this.movie_panel.Controls.Add(this.remove_button);
            this.movie_panel.Controls.Add(this.name_tb);
            this.movie_panel.Controls.Add(this.add_button);
            this.movie_panel.Controls.Add(this.movie_listbox);
            this.movie_panel.Controls.Add(this.genre_cb);
            this.movie_panel.Location = new System.Drawing.Point(12, 73);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(541, 171);
            this.movie_panel.TabIndex = 14;
            // 
            // book_name_lbl
            // 
            this.book_name_lbl.AutoSize = true;
            this.book_name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.book_name_lbl.Location = new System.Drawing.Point(6, 11);
            this.book_name_lbl.Name = "book_name_lbl";
            this.book_name_lbl.Size = new System.Drawing.Size(67, 15);
            this.book_name_lbl.TabIndex = 17;
            this.book_name_lbl.Text = "Book Name:";
            this.book_name_lbl.Visible = false;
            // 
            // serie_name_lbl
            // 
            this.serie_name_lbl.AutoSize = true;
            this.serie_name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serie_name_lbl.Location = new System.Drawing.Point(6, 12);
            this.serie_name_lbl.Name = "serie_name_lbl";
            this.serie_name_lbl.Size = new System.Drawing.Size(71, 15);
            this.serie_name_lbl.TabIndex = 4;
            this.serie_name_lbl.Text = "Serie Name:";
            this.serie_name_lbl.Visible = false;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.books_rb);
            this.main_panel.Controls.Add(this.series_rb);
            this.main_panel.Controls.Add(this.movie_rb);
            this.main_panel.Location = new System.Drawing.Point(12, 12);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(541, 54);
            this.main_panel.TabIndex = 15;
            // 
            // books_rb
            // 
            this.books_rb.AutoSize = true;
            this.books_rb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.books_rb.Location = new System.Drawing.Point(449, 18);
            this.books_rb.Name = "books_rb";
            this.books_rb.Size = new System.Drawing.Size(61, 22);
            this.books_rb.TabIndex = 2;
            this.books_rb.Text = "books";
            this.books_rb.UseVisualStyleBackColor = true;
            this.books_rb.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // series_rb
            // 
            this.series_rb.AutoSize = true;
            this.series_rb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.series_rb.Location = new System.Drawing.Point(242, 18);
            this.series_rb.Name = "series_rb";
            this.series_rb.Size = new System.Drawing.Size(62, 22);
            this.series_rb.TabIndex = 1;
            this.series_rb.Text = "series";
            this.series_rb.UseVisualStyleBackColor = true;
            this.series_rb.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // movie_rb
            // 
            this.movie_rb.AutoSize = true;
            this.movie_rb.Checked = true;
            this.movie_rb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movie_rb.Location = new System.Drawing.Point(37, 18);
            this.movie_rb.Name = "movie_rb";
            this.movie_rb.Size = new System.Drawing.Size(65, 22);
            this.movie_rb.TabIndex = 0;
            this.movie_rb.TabStop = true;
            this.movie_rb.Text = "movies";
            this.movie_rb.UseVisualStyleBackColor = true;
            this.movie_rb.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // serie_listbox
            // 
            this.serie_listbox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie_listbox.ItemHeight = 15;
            this.serie_listbox.Location = new System.Drawing.Point(277, 9);
            this.serie_listbox.Name = "serie_listbox";
            this.serie_listbox.Size = new System.Drawing.Size(261, 154);
            this.serie_listbox.TabIndex = 9;
            this.serie_listbox.Visible = false;
            // 
            // book_listbox
            // 
            this.book_listbox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_listbox.ItemHeight = 15;
            this.book_listbox.Location = new System.Drawing.Point(277, 9);
            this.book_listbox.Name = "book_listbox";
            this.book_listbox.Size = new System.Drawing.Size(261, 154);
            this.book_listbox.TabIndex = 10;
            this.book_listbox.Visible = false;
            // 
            // watch_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 255);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.movie_panel);
            this.Name = "watch_list";
            this.Text = "Watch_List_Form";
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListBox movie_listbox;
        private System.Windows.Forms.Label movie_name_lbl;
        private System.Windows.Forms.ComboBox genre_cb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.RadioButton books_rb;
        private System.Windows.Forms.RadioButton series_rb;
        private System.Windows.Forms.RadioButton movie_rb;
        private System.Windows.Forms.Label serie_name_lbl;
        private System.Windows.Forms.Label book_name_lbl;
        private System.Windows.Forms.ListBox book_listbox;
        private System.Windows.Forms.ListBox serie_listbox;
    }
}

