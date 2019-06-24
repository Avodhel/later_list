namespace later_list
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.open_movie_path_button = new System.Windows.Forms.Button();
            this.movie_path_tb = new System.Windows.Forms.TextBox();
            this.movie_path_lbl = new System.Windows.Forms.Label();
            this.save_settings_button = new System.Windows.Forms.Button();
            this.settings_gb = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dark_rb = new System.Windows.Forms.RadioButton();
            this.light_rb = new System.Windows.Forms.RadioButton();
            this.open_book_path_button = new System.Windows.Forms.Button();
            this.book_path_tb = new System.Windows.Forms.TextBox();
            this.book_path_lbl = new System.Windows.Forms.Label();
            this.open_serie_path_button = new System.Windows.Forms.Button();
            this.serie_path_tb = new System.Windows.Forms.TextBox();
            this.serie_path_lbl = new System.Windows.Forms.Label();
            this.openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.settings_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_movie_path_button
            // 
            this.open_movie_path_button.BackColor = System.Drawing.Color.Khaki;
            this.open_movie_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_movie_path_button.Image = ((System.Drawing.Image)(resources.GetObject("open_movie_path_button.Image")));
            this.open_movie_path_button.Location = new System.Drawing.Point(278, 14);
            this.open_movie_path_button.Name = "open_movie_path_button";
            this.open_movie_path_button.Size = new System.Drawing.Size(31, 26);
            this.open_movie_path_button.TabIndex = 5;
            this.open_movie_path_button.UseVisualStyleBackColor = false;
            this.open_movie_path_button.Click += new System.EventHandler(this.open_movie_path_button_Click);
            // 
            // movie_path_tb
            // 
            this.movie_path_tb.Font = new System.Drawing.Font("Advanced Pixel-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_path_tb.Location = new System.Drawing.Point(86, 14);
            this.movie_path_tb.Name = "movie_path_tb";
            this.movie_path_tb.Size = new System.Drawing.Size(186, 26);
            this.movie_path_tb.TabIndex = 4;
            // 
            // movie_path_lbl
            // 
            this.movie_path_lbl.AutoSize = true;
            this.movie_path_lbl.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_path_lbl.Location = new System.Drawing.Point(8, 19);
            this.movie_path_lbl.Name = "movie_path_lbl";
            this.movie_path_lbl.Size = new System.Drawing.Size(72, 16);
            this.movie_path_lbl.TabIndex = 3;
            this.movie_path_lbl.Text = "Movie List:";
            // 
            // save_settings_button
            // 
            this.save_settings_button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.save_settings_button.Enabled = false;
            this.save_settings_button.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_settings_button.Image = ((System.Drawing.Image)(resources.GetObject("save_settings_button.Image")));
            this.save_settings_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_settings_button.Location = new System.Drawing.Point(86, 98);
            this.save_settings_button.Name = "save_settings_button";
            this.save_settings_button.Size = new System.Drawing.Size(186, 29);
            this.save_settings_button.TabIndex = 6;
            this.save_settings_button.Text = "Save Settings";
            this.save_settings_button.UseVisualStyleBackColor = false;
            this.save_settings_button.Click += new System.EventHandler(this.save_settings_button_Click);
            // 
            // settings_gb
            // 
            this.settings_gb.BackColor = System.Drawing.Color.Transparent;
            this.settings_gb.Controls.Add(this.groupBox1);
            this.settings_gb.Controls.Add(this.save_settings_button);
            this.settings_gb.Controls.Add(this.open_book_path_button);
            this.settings_gb.Controls.Add(this.open_movie_path_button);
            this.settings_gb.Controls.Add(this.book_path_tb);
            this.settings_gb.Controls.Add(this.movie_path_tb);
            this.settings_gb.Controls.Add(this.book_path_lbl);
            this.settings_gb.Controls.Add(this.movie_path_lbl);
            this.settings_gb.Controls.Add(this.open_serie_path_button);
            this.settings_gb.Controls.Add(this.serie_path_tb);
            this.settings_gb.Controls.Add(this.serie_path_lbl);
            this.settings_gb.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_gb.Location = new System.Drawing.Point(12, 12);
            this.settings_gb.Name = "settings_gb";
            this.settings_gb.Size = new System.Drawing.Size(417, 133);
            this.settings_gb.TabIndex = 23;
            this.settings_gb.TabStop = false;
            this.settings_gb.Text = "Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dark_rb);
            this.groupBox1.Controls.Add(this.light_rb);
            this.groupBox1.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(315, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 84);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Themes";
            // 
            // dark_rb
            // 
            this.dark_rb.AutoSize = true;
            this.dark_rb.Checked = true;
            this.dark_rb.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dark_rb.Location = new System.Drawing.Point(16, 48);
            this.dark_rb.Name = "dark_rb";
            this.dark_rb.Size = new System.Drawing.Size(52, 20);
            this.dark_rb.TabIndex = 1;
            this.dark_rb.TabStop = true;
            this.dark_rb.Text = "Dark";
            this.dark_rb.UseVisualStyleBackColor = true;
            this.dark_rb.CheckedChanged += new System.EventHandler(this.theme_rb_CheckedChanged);
            // 
            // light_rb
            // 
            this.light_rb.AutoSize = true;
            this.light_rb.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.light_rb.Location = new System.Drawing.Point(16, 22);
            this.light_rb.Name = "light_rb";
            this.light_rb.Size = new System.Drawing.Size(56, 20);
            this.light_rb.TabIndex = 0;
            this.light_rb.Text = "Light";
            this.light_rb.UseVisualStyleBackColor = true;
            this.light_rb.CheckedChanged += new System.EventHandler(this.theme_rb_CheckedChanged);
            // 
            // open_book_path_button
            // 
            this.open_book_path_button.BackColor = System.Drawing.Color.Khaki;
            this.open_book_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_book_path_button.Image = ((System.Drawing.Image)(resources.GetObject("open_book_path_button.Image")));
            this.open_book_path_button.Location = new System.Drawing.Point(278, 71);
            this.open_book_path_button.Name = "open_book_path_button";
            this.open_book_path_button.Size = new System.Drawing.Size(31, 27);
            this.open_book_path_button.TabIndex = 9;
            this.open_book_path_button.UseVisualStyleBackColor = false;
            this.open_book_path_button.Click += new System.EventHandler(this.open_book_path_button_Click);
            // 
            // book_path_tb
            // 
            this.book_path_tb.Font = new System.Drawing.Font("Advanced Pixel-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_path_tb.Location = new System.Drawing.Point(86, 71);
            this.book_path_tb.Name = "book_path_tb";
            this.book_path_tb.Size = new System.Drawing.Size(186, 26);
            this.book_path_tb.TabIndex = 8;
            // 
            // book_path_lbl
            // 
            this.book_path_lbl.AutoSize = true;
            this.book_path_lbl.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_path_lbl.Location = new System.Drawing.Point(12, 75);
            this.book_path_lbl.Name = "book_path_lbl";
            this.book_path_lbl.Size = new System.Drawing.Size(68, 16);
            this.book_path_lbl.TabIndex = 7;
            this.book_path_lbl.Text = "Book List:";
            // 
            // open_serie_path_button
            // 
            this.open_serie_path_button.BackColor = System.Drawing.Color.Khaki;
            this.open_serie_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_serie_path_button.Image = ((System.Drawing.Image)(resources.GetObject("open_serie_path_button.Image")));
            this.open_serie_path_button.Location = new System.Drawing.Point(278, 43);
            this.open_serie_path_button.Name = "open_serie_path_button";
            this.open_serie_path_button.Size = new System.Drawing.Size(31, 26);
            this.open_serie_path_button.TabIndex = 6;
            this.open_serie_path_button.UseVisualStyleBackColor = false;
            this.open_serie_path_button.Click += new System.EventHandler(this.open_serie_path_button_Click);
            // 
            // serie_path_tb
            // 
            this.serie_path_tb.Font = new System.Drawing.Font("Advanced Pixel-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie_path_tb.Location = new System.Drawing.Point(86, 43);
            this.serie_path_tb.Name = "serie_path_tb";
            this.serie_path_tb.Size = new System.Drawing.Size(186, 26);
            this.serie_path_tb.TabIndex = 5;
            // 
            // serie_path_lbl
            // 
            this.serie_path_lbl.AutoSize = true;
            this.serie_path_lbl.Font = new System.Drawing.Font("Advanced Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie_path_lbl.Location = new System.Drawing.Point(8, 47);
            this.serie_path_lbl.Name = "serie_path_lbl";
            this.serie_path_lbl.Size = new System.Drawing.Size(72, 16);
            this.serie_path_lbl.TabIndex = 4;
            this.serie_path_lbl.Text = "Serie List:";
            // 
            // openfiledialog
            // 
            this.openfiledialog.FileName = "openfiledialog";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(443, 156);
            this.Controls.Add(this.settings_gb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.settings_gb.ResumeLayout(false);
            this.settings_gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_movie_path_button;
        private System.Windows.Forms.TextBox movie_path_tb;
        private System.Windows.Forms.Label movie_path_lbl;
        private System.Windows.Forms.Button save_settings_button;
        private System.Windows.Forms.GroupBox settings_gb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dark_rb;
        private System.Windows.Forms.RadioButton light_rb;
        private System.Windows.Forms.Button open_book_path_button;
        private System.Windows.Forms.TextBox book_path_tb;
        private System.Windows.Forms.Label book_path_lbl;
        private System.Windows.Forms.Button open_serie_path_button;
        private System.Windows.Forms.TextBox serie_path_tb;
        private System.Windows.Forms.Label serie_path_lbl;
        private System.Windows.Forms.OpenFileDialog openfiledialog;
    }
}