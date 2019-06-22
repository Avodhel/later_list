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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(watch_list));
            this.add_button = new System.Windows.Forms.Button();
            this.movie_listbox = new System.Windows.Forms.ListBox();
            this.movie_name_lbl = new System.Windows.Forms.Label();
            this.genre_cb = new System.Windows.Forms.ComboBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.genre_label = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.serie_listbox = new System.Windows.Forms.ListBox();
            this.save_button = new System.Windows.Forms.Button();
            this.book_listbox = new System.Windows.Forms.ListBox();
            this.book_name_lbl = new System.Windows.Forms.Label();
            this.serie_name_lbl = new System.Windows.Forms.Label();
            this.books_rb = new System.Windows.Forms.RadioButton();
            this.series_rb = new System.Windows.Forms.RadioButton();
            this.movie_rb = new System.Windows.Forms.RadioButton();
            this.version_lbl = new System.Windows.Forms.Label();
            this.savefiledialog = new System.Windows.Forms.SaveFileDialog();
            this.sections_gb = new System.Windows.Forms.GroupBox();
            this.list_operations_gb = new System.Windows.Forms.GroupBox();
            this.settings_button = new System.Windows.Forms.Button();
            this.sections_gb.SuspendLayout();
            this.list_operations_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.PaleGreen;
            this.add_button.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Image = ((System.Drawing.Image)(resources.GetObject("add_button.Image")));
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(11, 72);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(129, 27);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add to List";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // movie_listbox
            // 
            this.movie_listbox.Font = new System.Drawing.Font("Advanced Pixel-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_listbox.ItemHeight = 14;
            this.movie_listbox.Location = new System.Drawing.Point(11, 135);
            this.movie_listbox.Name = "movie_listbox";
            this.movie_listbox.Size = new System.Drawing.Size(266, 116);
            this.movie_listbox.TabIndex = 8;
            this.movie_listbox.SelectedIndexChanged += new System.EventHandler(this.selectedIndexChanged);
            // 
            // movie_name_lbl
            // 
            this.movie_name_lbl.AutoSize = true;
            this.movie_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.movie_name_lbl.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_lbl.Location = new System.Drawing.Point(8, 19);
            this.movie_name_lbl.Name = "movie_name_lbl";
            this.movie_name_lbl.Size = new System.Drawing.Size(76, 16);
            this.movie_name_lbl.TabIndex = 4;
            this.movie_name_lbl.Text = "Movie Name:";
            // 
            // genre_cb
            // 
            this.genre_cb.Font = new System.Drawing.Font("Advanced Pixel-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_cb.FormattingEnabled = true;
            this.genre_cb.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Fiction",
            "Science Fiction"});
            this.genre_cb.Location = new System.Drawing.Point(90, 43);
            this.genre_cb.Name = "genre_cb";
            this.genre_cb.Size = new System.Drawing.Size(135, 22);
            this.genre_cb.TabIndex = 6;
            this.genre_cb.Click += new System.EventHandler(this.input_fields_Click);
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Advanced Pixel-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tb.Location = new System.Drawing.Point(90, 13);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(135, 26);
            this.name_tb.TabIndex = 10;
            this.name_tb.Click += new System.EventHandler(this.input_fields_Click);
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Salmon;
            this.remove_button.Enabled = false;
            this.remove_button.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_button.Image = ((System.Drawing.Image)(resources.GetObject("remove_button.Image")));
            this.remove_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_button.Location = new System.Drawing.Point(149, 72);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(128, 28);
            this.remove_button.TabIndex = 11;
            this.remove_button.Text = "Remove Item";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.BackColor = System.Drawing.Color.Transparent;
            this.genre_label.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_label.Location = new System.Drawing.Point(11, 45);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(42, 16);
            this.genre_label.TabIndex = 12;
            this.genre_label.Text = "Genre:";
            this.genre_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Yellow;
            this.edit_button.Enabled = false;
            this.edit_button.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_button.Image")));
            this.edit_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_button.Location = new System.Drawing.Point(11, 101);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(129, 28);
            this.edit_button.TabIndex = 13;
            this.edit_button.Text = "Edit Item";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Thistle;
            this.clear_button.Font = new System.Drawing.Font("Advanced Pixel-7", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Image = ((System.Drawing.Image)(resources.GetObject("clear_button.Image")));
            this.clear_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear_button.Location = new System.Drawing.Point(231, 13);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(46, 53);
            this.clear_button.TabIndex = 19;
            this.clear_button.Text = "Clear Fields";
            this.clear_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // serie_listbox
            // 
            this.serie_listbox.Font = new System.Drawing.Font("Advanced Pixel-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie_listbox.ItemHeight = 14;
            this.serie_listbox.Location = new System.Drawing.Point(11, 135);
            this.serie_listbox.Name = "serie_listbox";
            this.serie_listbox.Size = new System.Drawing.Size(266, 116);
            this.serie_listbox.TabIndex = 9;
            this.serie_listbox.Visible = false;
            this.serie_listbox.SelectedIndexChanged += new System.EventHandler(this.selectedIndexChanged);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save_button.Enabled = false;
            this.save_button.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Image = ((System.Drawing.Image)(resources.GetObject("save_button.Image")));
            this.save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_button.Location = new System.Drawing.Point(149, 101);
            this.save_button.Name = "save_button";
            this.save_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save_button.Size = new System.Drawing.Size(128, 28);
            this.save_button.TabIndex = 18;
            this.save_button.Text = "Save List";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // book_listbox
            // 
            this.book_listbox.Font = new System.Drawing.Font("Advanced Pixel-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_listbox.ItemHeight = 14;
            this.book_listbox.Location = new System.Drawing.Point(11, 135);
            this.book_listbox.Name = "book_listbox";
            this.book_listbox.Size = new System.Drawing.Size(266, 116);
            this.book_listbox.TabIndex = 10;
            this.book_listbox.Visible = false;
            this.book_listbox.SelectedIndexChanged += new System.EventHandler(this.selectedIndexChanged);
            // 
            // book_name_lbl
            // 
            this.book_name_lbl.AutoSize = true;
            this.book_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.book_name_lbl.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_name_lbl.Location = new System.Drawing.Point(12, 19);
            this.book_name_lbl.Name = "book_name_lbl";
            this.book_name_lbl.Size = new System.Drawing.Size(72, 16);
            this.book_name_lbl.TabIndex = 17;
            this.book_name_lbl.Text = "Book Name:";
            this.book_name_lbl.Visible = false;
            // 
            // serie_name_lbl
            // 
            this.serie_name_lbl.AutoSize = true;
            this.serie_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.serie_name_lbl.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie_name_lbl.Location = new System.Drawing.Point(8, 19);
            this.serie_name_lbl.Name = "serie_name_lbl";
            this.serie_name_lbl.Size = new System.Drawing.Size(76, 16);
            this.serie_name_lbl.TabIndex = 4;
            this.serie_name_lbl.Text = "Serie Name:";
            this.serie_name_lbl.Visible = false;
            // 
            // books_rb
            // 
            this.books_rb.AutoSize = true;
            this.books_rb.Font = new System.Drawing.Font("Advanced Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books_rb.Location = new System.Drawing.Point(165, 16);
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
            this.series_rb.Font = new System.Drawing.Font("Advanced Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.series_rb.Location = new System.Drawing.Point(93, 16);
            this.series_rb.Name = "series_rb";
            this.series_rb.Size = new System.Drawing.Size(66, 22);
            this.series_rb.TabIndex = 1;
            this.series_rb.Text = "series";
            this.series_rb.UseVisualStyleBackColor = true;
            this.series_rb.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // movie_rb
            // 
            this.movie_rb.AutoSize = true;
            this.movie_rb.Checked = true;
            this.movie_rb.Font = new System.Drawing.Font("Advanced Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_rb.Location = new System.Drawing.Point(18, 16);
            this.movie_rb.Name = "movie_rb";
            this.movie_rb.Size = new System.Drawing.Size(69, 22);
            this.movie_rb.TabIndex = 0;
            this.movie_rb.TabStop = true;
            this.movie_rb.Text = "movies";
            this.movie_rb.UseVisualStyleBackColor = true;
            this.movie_rb.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // version_lbl
            // 
            this.version_lbl.AutoSize = true;
            this.version_lbl.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.version_lbl.Location = new System.Drawing.Point(262, 321);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(27, 12);
            this.version_lbl.TabIndex = 3;
            this.version_lbl.Text = "v1.0";
            // 
            // sections_gb
            // 
            this.sections_gb.BackColor = System.Drawing.Color.Transparent;
            this.sections_gb.Controls.Add(this.books_rb);
            this.sections_gb.Controls.Add(this.movie_rb);
            this.sections_gb.Controls.Add(this.series_rb);
            this.sections_gb.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sections_gb.Location = new System.Drawing.Point(12, 2);
            this.sections_gb.Name = "sections_gb";
            this.sections_gb.Size = new System.Drawing.Size(238, 45);
            this.sections_gb.TabIndex = 17;
            this.sections_gb.TabStop = false;
            this.sections_gb.Text = "Sections";
            // 
            // list_operations_gb
            // 
            this.list_operations_gb.BackColor = System.Drawing.Color.Transparent;
            this.list_operations_gb.Controls.Add(this.save_button);
            this.list_operations_gb.Controls.Add(this.movie_name_lbl);
            this.list_operations_gb.Controls.Add(this.edit_button);
            this.list_operations_gb.Controls.Add(this.serie_name_lbl);
            this.list_operations_gb.Controls.Add(this.remove_button);
            this.list_operations_gb.Controls.Add(this.genre_label);
            this.list_operations_gb.Controls.Add(this.book_name_lbl);
            this.list_operations_gb.Controls.Add(this.clear_button);
            this.list_operations_gb.Controls.Add(this.serie_listbox);
            this.list_operations_gb.Controls.Add(this.book_listbox);
            this.list_operations_gb.Controls.Add(this.add_button);
            this.list_operations_gb.Controls.Add(this.movie_listbox);
            this.list_operations_gb.Controls.Add(this.name_tb);
            this.list_operations_gb.Controls.Add(this.genre_cb);
            this.list_operations_gb.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_operations_gb.Location = new System.Drawing.Point(12, 53);
            this.list_operations_gb.Name = "list_operations_gb";
            this.list_operations_gb.Size = new System.Drawing.Size(288, 265);
            this.list_operations_gb.TabIndex = 20;
            this.list_operations_gb.TabStop = false;
            this.list_operations_gb.Text = "List Operations";
            // 
            // settings_button
            // 
            this.settings_button.Image = ((System.Drawing.Image)(resources.GetObject("settings_button.Image")));
            this.settings_button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.settings_button.Location = new System.Drawing.Point(264, 18);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(25, 24);
            this.settings_button.TabIndex = 21;
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // watch_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(313, 335);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.list_operations_gb);
            this.Controls.Add(this.sections_gb);
            this.Controls.Add(this.version_lbl);
            this.Name = "watch_list";
            this.Text = "Later List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.watch_list_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.watch_list_FormClosed);
            this.sections_gb.ResumeLayout(false);
            this.sections_gb.PerformLayout();
            this.list_operations_gb.ResumeLayout(false);
            this.list_operations_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RadioButton books_rb;
        private System.Windows.Forms.RadioButton series_rb;
        private System.Windows.Forms.RadioButton movie_rb;
        private System.Windows.Forms.Label serie_name_lbl;
        private System.Windows.Forms.Label book_name_lbl;
        private System.Windows.Forms.ListBox book_listbox;
        private System.Windows.Forms.ListBox serie_listbox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label version_lbl;
        private System.Windows.Forms.SaveFileDialog savefiledialog;
        private System.Windows.Forms.GroupBox sections_gb;
        private System.Windows.Forms.GroupBox list_operations_gb;
        private System.Windows.Forms.Button settings_button;
    }
}

