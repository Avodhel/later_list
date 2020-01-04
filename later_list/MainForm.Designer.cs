namespace later_list
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.add_button = new System.Windows.Forms.Button();
            this.movie_listbox = new System.Windows.Forms.ListBox();
            this.movie_name_lbl = new System.Windows.Forms.Label();
            this.genre_cb = new System.Windows.Forms.ComboBox();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.remove_button = new System.Windows.Forms.Button();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.serie_listbox = new System.Windows.Forms.ListBox();
            this.save_button = new System.Windows.Forms.Button();
            this.book_listbox = new System.Windows.Forms.ListBox();
            this.book_name_lbl = new System.Windows.Forms.Label();
            this.serie_name_lbl = new System.Windows.Forms.Label();
            this.version_lbl = new System.Windows.Forms.Label();
            this.savefiledialog = new System.Windows.Forms.SaveFileDialog();
            this.list_operations_gb = new System.Windows.Forms.GroupBox();
            this.discard_button = new System.Windows.Forms.Button();
            this.input_fields_panel = new System.Windows.Forms.Panel();
            this.author_lbl = new System.Windows.Forms.Label();
            this.author_tb = new System.Windows.Forms.TextBox();
            this.settings_button = new System.Windows.Forms.Button();
            this.error_provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.laterListLogo = new System.Windows.Forms.PictureBox();
            this.bookSectionBtn = new System.Windows.Forms.Button();
            this.serieSectionBtn = new System.Windows.Forms.Button();
            this.movieSectionBtn = new System.Windows.Forms.Button();
            this.list_operations_gb.SuspendLayout();
            this.input_fields_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laterListLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.PaleGreen;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_button.Image = ((System.Drawing.Image)(resources.GetObject("add_button.Image")));
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(18, 118);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(165, 30);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add to List";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // movie_listbox
            // 
            this.movie_listbox.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movie_listbox.HorizontalScrollbar = true;
            this.movie_listbox.ItemHeight = 15;
            this.movie_listbox.Location = new System.Drawing.Point(18, 201);
            this.movie_listbox.Name = "movie_listbox";
            this.movie_listbox.Size = new System.Drawing.Size(356, 124);
            this.movie_listbox.TabIndex = 8;
            this.movie_listbox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // movie_name_lbl
            // 
            this.movie_name_lbl.AutoSize = true;
            this.movie_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.movie_name_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movie_name_lbl.Location = new System.Drawing.Point(4, 8);
            this.movie_name_lbl.Name = "movie_name_lbl";
            this.movie_name_lbl.Size = new System.Drawing.Size(88, 15);
            this.movie_name_lbl.TabIndex = 4;
            this.movie_name_lbl.Text = "Movie Name:";
            // 
            // genre_cb
            // 
            this.genre_cb.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genre_cb.FormattingEnabled = true;
            this.genre_cb.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Fiction",
            "Science Fiction"});
            this.genre_cb.Location = new System.Drawing.Point(97, 41);
            this.genre_cb.Name = "genre_cb";
            this.genre_cb.Size = new System.Drawing.Size(179, 26);
            this.genre_cb.TabIndex = 6;
            this.genre_cb.Click += new System.EventHandler(this.InputFieldsClick);
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_tb.Location = new System.Drawing.Point(97, 3);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(179, 25);
            this.name_tb.TabIndex = 10;
            this.name_tb.Click += new System.EventHandler(this.InputFieldsClick);
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Salmon;
            this.remove_button.Enabled = false;
            this.remove_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_button.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.remove_button.Image = ((System.Drawing.Image)(resources.GetObject("remove_button.Image")));
            this.remove_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_button.Location = new System.Drawing.Point(209, 118);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(165, 30);
            this.remove_button.TabIndex = 11;
            this.remove_button.Text = "Remove Item";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.BackColor = System.Drawing.Color.Transparent;
            this.genre_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genre_lbl.Location = new System.Drawing.Point(43, 47);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(48, 15);
            this.genre_lbl.TabIndex = 12;
            this.genre_lbl.Text = "Genre:";
            this.genre_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Yellow;
            this.edit_button.Enabled = false;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.edit_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_button.Image")));
            this.edit_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_button.Location = new System.Drawing.Point(18, 157);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(165, 30);
            this.edit_button.TabIndex = 13;
            this.edit_button.Text = "Edit Item";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Thistle;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clear_button.Image = ((System.Drawing.Image)(resources.GetObject("clear_button.Image")));
            this.clear_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear_button.Location = new System.Drawing.Point(315, 32);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(59, 71);
            this.clear_button.TabIndex = 19;
            this.clear_button.Text = "Clear Fields";
            this.clear_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // serie_listbox
            // 
            this.serie_listbox.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serie_listbox.HorizontalScrollbar = true;
            this.serie_listbox.ItemHeight = 15;
            this.serie_listbox.Location = new System.Drawing.Point(18, 201);
            this.serie_listbox.Name = "serie_listbox";
            this.serie_listbox.Size = new System.Drawing.Size(356, 124);
            this.serie_listbox.TabIndex = 9;
            this.serie_listbox.Visible = false;
            this.serie_listbox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.save_button.Enabled = false;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_button.Image = ((System.Drawing.Image)(resources.GetObject("save_button.Image")));
            this.save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_button.Location = new System.Drawing.Point(209, 157);
            this.save_button.Name = "save_button";
            this.save_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save_button.Size = new System.Drawing.Size(165, 30);
            this.save_button.TabIndex = 18;
            this.save_button.Text = "Save List";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.EnabledChanged += new System.EventHandler(this.SaveButtonEnabledChanged);
            this.save_button.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // book_listbox
            // 
            this.book_listbox.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.book_listbox.HorizontalScrollbar = true;
            this.book_listbox.ItemHeight = 15;
            this.book_listbox.Location = new System.Drawing.Point(18, 201);
            this.book_listbox.Name = "book_listbox";
            this.book_listbox.Size = new System.Drawing.Size(356, 124);
            this.book_listbox.TabIndex = 10;
            this.book_listbox.Visible = false;
            this.book_listbox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // book_name_lbl
            // 
            this.book_name_lbl.AutoSize = true;
            this.book_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.book_name_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.book_name_lbl.Location = new System.Drawing.Point(9, 8);
            this.book_name_lbl.Name = "book_name_lbl";
            this.book_name_lbl.Size = new System.Drawing.Size(83, 15);
            this.book_name_lbl.TabIndex = 17;
            this.book_name_lbl.Text = "Book Name:";
            this.book_name_lbl.Visible = false;
            // 
            // serie_name_lbl
            // 
            this.serie_name_lbl.AutoSize = true;
            this.serie_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.serie_name_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serie_name_lbl.Location = new System.Drawing.Point(9, 8);
            this.serie_name_lbl.Name = "serie_name_lbl";
            this.serie_name_lbl.Size = new System.Drawing.Size(83, 15);
            this.serie_name_lbl.TabIndex = 4;
            this.serie_name_lbl.Text = "Serie Name:";
            this.serie_name_lbl.Visible = false;
            // 
            // version_lbl
            // 
            this.version_lbl.AutoSize = true;
            this.version_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.version_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.version_lbl.Location = new System.Drawing.Point(36, 325);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(30, 15);
            this.version_lbl.TabIndex = 3;
            this.version_lbl.Text = "v1.2";
            // 
            // list_operations_gb
            // 
            this.list_operations_gb.BackColor = System.Drawing.Color.Transparent;
            this.list_operations_gb.Controls.Add(this.discard_button);
            this.list_operations_gb.Controls.Add(this.save_button);
            this.list_operations_gb.Controls.Add(this.input_fields_panel);
            this.list_operations_gb.Controls.Add(this.edit_button);
            this.list_operations_gb.Controls.Add(this.serie_listbox);
            this.list_operations_gb.Controls.Add(this.clear_button);
            this.list_operations_gb.Controls.Add(this.remove_button);
            this.list_operations_gb.Controls.Add(this.book_listbox);
            this.list_operations_gb.Controls.Add(this.add_button);
            this.list_operations_gb.Controls.Add(this.movie_listbox);
            this.list_operations_gb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_operations_gb.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_operations_gb.Location = new System.Drawing.Point(105, 3);
            this.list_operations_gb.Name = "list_operations_gb";
            this.list_operations_gb.Size = new System.Drawing.Size(394, 340);
            this.list_operations_gb.TabIndex = 20;
            this.list_operations_gb.TabStop = false;
            this.list_operations_gb.Text = "Movies";
            // 
            // discard_button
            // 
            this.discard_button.BackColor = System.Drawing.Color.Salmon;
            this.discard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discard_button.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.discard_button.Location = new System.Drawing.Point(375, 201);
            this.discard_button.Name = "discard_button";
            this.discard_button.Size = new System.Drawing.Size(14, 124);
            this.discard_button.TabIndex = 22;
            this.discard_button.Text = "Discard";
            this.discard_button.UseVisualStyleBackColor = false;
            this.discard_button.Visible = false;
            this.discard_button.Click += new System.EventHandler(this.DiscardButtonClick);
            // 
            // input_fields_panel
            // 
            this.input_fields_panel.AutoScroll = true;
            this.input_fields_panel.Controls.Add(this.author_lbl);
            this.input_fields_panel.Controls.Add(this.movie_name_lbl);
            this.input_fields_panel.Controls.Add(this.name_tb);
            this.input_fields_panel.Controls.Add(this.author_tb);
            this.input_fields_panel.Controls.Add(this.serie_name_lbl);
            this.input_fields_panel.Controls.Add(this.genre_lbl);
            this.input_fields_panel.Controls.Add(this.book_name_lbl);
            this.input_fields_panel.Controls.Add(this.genre_cb);
            this.input_fields_panel.Location = new System.Drawing.Point(11, 32);
            this.input_fields_panel.Name = "input_fields_panel";
            this.input_fields_panel.Size = new System.Drawing.Size(299, 71);
            this.input_fields_panel.TabIndex = 22;
            // 
            // author_lbl
            // 
            this.author_lbl.AutoSize = true;
            this.author_lbl.BackColor = System.Drawing.Color.Transparent;
            this.author_lbl.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.author_lbl.Location = new System.Drawing.Point(39, 47);
            this.author_lbl.Name = "author_lbl";
            this.author_lbl.Size = new System.Drawing.Size(53, 15);
            this.author_lbl.TabIndex = 18;
            this.author_lbl.Text = "Author:";
            this.author_lbl.Visible = false;
            // 
            // author_tb
            // 
            this.author_tb.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.author_tb.Location = new System.Drawing.Point(97, 41);
            this.author_tb.Name = "author_tb";
            this.author_tb.Size = new System.Drawing.Size(179, 25);
            this.author_tb.TabIndex = 19;
            this.author_tb.Visible = false;
            // 
            // settings_button
            // 
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Image = ((System.Drawing.Image)(resources.GetObject("settings_button.Image")));
            this.settings_button.Location = new System.Drawing.Point(36, 294);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(28, 28);
            this.settings_button.TabIndex = 21;
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.SettingsButtonClick);
            // 
            // error_provider
            // 
            this.error_provider.ContainerControl = this;
            this.error_provider.Icon = ((System.Drawing.Icon)(resources.GetObject("error_provider.Icon")));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.laterListLogo);
            this.panel1.Controls.Add(this.bookSectionBtn);
            this.panel1.Controls.Add(this.settings_button);
            this.panel1.Controls.Add(this.serieSectionBtn);
            this.panel1.Controls.Add(this.movieSectionBtn);
            this.panel1.Controls.Add(this.version_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 350);
            this.panel1.TabIndex = 22;
            // 
            // laterListLogo
            // 
            this.laterListLogo.BackColor = System.Drawing.Color.Transparent;
            this.laterListLogo.Image = ((System.Drawing.Image)(resources.GetObject("laterListLogo.Image")));
            this.laterListLogo.InitialImage = null;
            this.laterListLogo.Location = new System.Drawing.Point(18, 12);
            this.laterListLogo.Name = "laterListLogo";
            this.laterListLogo.Size = new System.Drawing.Size(64, 64);
            this.laterListLogo.TabIndex = 22;
            this.laterListLogo.TabStop = false;
            // 
            // bookSectionBtn
            // 
            this.bookSectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookSectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookSectionBtn.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookSectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookSectionBtn.Image")));
            this.bookSectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookSectionBtn.Location = new System.Drawing.Point(0, 200);
            this.bookSectionBtn.Name = "bookSectionBtn";
            this.bookSectionBtn.Size = new System.Drawing.Size(99, 33);
            this.bookSectionBtn.TabIndex = 2;
            this.bookSectionBtn.Text = "Books";
            this.bookSectionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookSectionBtn.UseVisualStyleBackColor = false;
            this.bookSectionBtn.Click += new System.EventHandler(this.ChooseSection);
            // 
            // serieSectionBtn
            // 
            this.serieSectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.serieSectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serieSectionBtn.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serieSectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("serieSectionBtn.Image")));
            this.serieSectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serieSectionBtn.Location = new System.Drawing.Point(0, 160);
            this.serieSectionBtn.Name = "serieSectionBtn";
            this.serieSectionBtn.Size = new System.Drawing.Size(99, 33);
            this.serieSectionBtn.TabIndex = 1;
            this.serieSectionBtn.Text = "Series";
            this.serieSectionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serieSectionBtn.UseVisualStyleBackColor = false;
            this.serieSectionBtn.Click += new System.EventHandler(this.ChooseSection);
            // 
            // movieSectionBtn
            // 
            this.movieSectionBtn.BackColor = System.Drawing.Color.Transparent;
            this.movieSectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieSectionBtn.Font = new System.Drawing.Font("Raleway", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movieSectionBtn.Image = ((System.Drawing.Image)(resources.GetObject("movieSectionBtn.Image")));
            this.movieSectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movieSectionBtn.Location = new System.Drawing.Point(0, 120);
            this.movieSectionBtn.Name = "movieSectionBtn";
            this.movieSectionBtn.Size = new System.Drawing.Size(99, 33);
            this.movieSectionBtn.TabIndex = 0;
            this.movieSectionBtn.Text = "Movies";
            this.movieSectionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.movieSectionBtn.UseVisualStyleBackColor = false;
            this.movieSectionBtn.Click += new System.EventHandler(this.ChooseSection);
            // 
            // later_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(504, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.list_operations_gb);
            this.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "later_list";
            this.Text = "Later List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.list_operations_gb.ResumeLayout(false);
            this.input_fields_panel.ResumeLayout(false);
            this.input_fields_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_provider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laterListLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListBox movie_listbox;
        private System.Windows.Forms.Label movie_name_lbl;
        private System.Windows.Forms.ComboBox genre_cb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label serie_name_lbl;
        private System.Windows.Forms.Label book_name_lbl;
        private System.Windows.Forms.ListBox book_listbox;
        private System.Windows.Forms.ListBox serie_listbox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label version_lbl;
        private System.Windows.Forms.SaveFileDialog savefiledialog;
        private System.Windows.Forms.GroupBox list_operations_gb;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.ErrorProvider error_provider;
        private System.Windows.Forms.Panel input_fields_panel;
        private System.Windows.Forms.Label author_lbl;
        private System.Windows.Forms.TextBox author_tb;
        private System.Windows.Forms.Button discard_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bookSectionBtn;
        private System.Windows.Forms.Button serieSectionBtn;
        private System.Windows.Forms.Button movieSectionBtn;
        private System.Windows.Forms.PictureBox laterListLogo;
    }
}

