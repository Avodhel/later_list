namespace later_list
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.open_movie_path_button = new System.Windows.Forms.Button();
            this.movie_path_tb = new System.Windows.Forms.TextBox();
            this.movie_path_lbl = new System.Windows.Forms.Label();
            this.save_settings_button = new System.Windows.Forms.Button();
            this.settings_gb = new System.Windows.Forms.GroupBox();
            this.clear_book_path_button = new System.Windows.Forms.Button();
            this.clear_serie_path_button = new System.Windows.Forms.Button();
            this.clear_movie_path_button = new System.Windows.Forms.Button();
            this.themes_gb = new System.Windows.Forms.GroupBox();
            this.dark_rb = new System.Windows.Forms.RadioButton();
            this.light_rb = new System.Windows.Forms.RadioButton();
            this.open_book_path_button = new System.Windows.Forms.Button();
            this.book_path_tb = new System.Windows.Forms.TextBox();
            this.book_path_lbl = new System.Windows.Forms.Label();
            this.open_serie_path_button = new System.Windows.Forms.Button();
            this.serie_path_tb = new System.Windows.Forms.TextBox();
            this.serie_path_lbl = new System.Windows.Forms.Label();
            this.openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.settings_error_provider = new System.Windows.Forms.ErrorProvider(this.components);
            this.settings_gb.SuspendLayout();
            this.themes_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_error_provider)).BeginInit();
            this.SuspendLayout();
            // 
            // open_movie_path_button
            // 
            this.open_movie_path_button.BackColor = System.Drawing.Color.Khaki;
            this.open_movie_path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_movie_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_movie_path_button.Image = ((System.Drawing.Image)(resources.GetObject("open_movie_path_button.Image")));
            this.open_movie_path_button.Location = new System.Drawing.Point(312, 23);
            this.open_movie_path_button.Name = "open_movie_path_button";
            this.open_movie_path_button.Size = new System.Drawing.Size(36, 26);
            this.open_movie_path_button.TabIndex = 5;
            this.open_movie_path_button.UseVisualStyleBackColor = false;
            this.open_movie_path_button.Click += new System.EventHandler(this.OpenPath);
            // 
            // movie_path_tb
            // 
            this.movie_path_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movie_path_tb.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movie_path_tb.Location = new System.Drawing.Point(80, 23);
            this.movie_path_tb.Name = "movie_path_tb";
            this.movie_path_tb.ReadOnly = true;
            this.movie_path_tb.Size = new System.Drawing.Size(226, 25);
            this.movie_path_tb.TabIndex = 4;
            this.movie_path_tb.TextChanged += new System.EventHandler(this.PathChanged);
            // 
            // movie_path_lbl
            // 
            this.movie_path_lbl.AutoSize = true;
            this.movie_path_lbl.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movie_path_lbl.Location = new System.Drawing.Point(6, 29);
            this.movie_path_lbl.Name = "movie_path_lbl";
            this.movie_path_lbl.Size = new System.Drawing.Size(68, 14);
            this.movie_path_lbl.TabIndex = 3;
            this.movie_path_lbl.Text = "Movie List:";
            // 
            // save_settings_button
            // 
            this.save_settings_button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.save_settings_button.Enabled = false;
            this.save_settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_settings_button.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settings_error_provider.SetIconPadding(this.save_settings_button, 15);
            this.save_settings_button.Image = ((System.Drawing.Image)(resources.GetObject("save_settings_button.Image")));
            this.save_settings_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_settings_button.Location = new System.Drawing.Point(80, 120);
            this.save_settings_button.Name = "save_settings_button";
            this.save_settings_button.Size = new System.Drawing.Size(226, 27);
            this.save_settings_button.TabIndex = 6;
            this.save_settings_button.Text = "Save Settings";
            this.save_settings_button.UseVisualStyleBackColor = false;
            this.save_settings_button.EnabledChanged += new System.EventHandler(this.SaveSettingsButtonEnabledChanged);
            this.save_settings_button.Click += new System.EventHandler(this.SaveSettingsButtonClick);
            // 
            // settings_gb
            // 
            this.settings_gb.BackColor = System.Drawing.Color.Transparent;
            this.settings_gb.Controls.Add(this.clear_book_path_button);
            this.settings_gb.Controls.Add(this.clear_serie_path_button);
            this.settings_gb.Controls.Add(this.clear_movie_path_button);
            this.settings_gb.Controls.Add(this.themes_gb);
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
            this.settings_gb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_gb.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settings_gb.Location = new System.Drawing.Point(9, 6);
            this.settings_gb.Name = "settings_gb";
            this.settings_gb.Size = new System.Drawing.Size(485, 154);
            this.settings_gb.TabIndex = 23;
            this.settings_gb.TabStop = false;
            // 
            // clear_book_path_button
            // 
            this.clear_book_path_button.BackColor = System.Drawing.Color.Thistle;
            this.clear_book_path_button.Enabled = false;
            this.clear_book_path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_book_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_book_path_button.Image = ((System.Drawing.Image)(resources.GetObject("clear_book_path_button.Image")));
            this.clear_book_path_button.Location = new System.Drawing.Point(354, 88);
            this.clear_book_path_button.Name = "clear_book_path_button";
            this.clear_book_path_button.Size = new System.Drawing.Size(36, 26);
            this.clear_book_path_button.TabIndex = 13;
            this.clear_book_path_button.UseVisualStyleBackColor = false;
            this.clear_book_path_button.Click += new System.EventHandler(this.ClearPath);
            // 
            // clear_serie_path_button
            // 
            this.clear_serie_path_button.BackColor = System.Drawing.Color.Thistle;
            this.clear_serie_path_button.Enabled = false;
            this.clear_serie_path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_serie_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_serie_path_button.Image = ((System.Drawing.Image)(resources.GetObject("clear_serie_path_button.Image")));
            this.clear_serie_path_button.Location = new System.Drawing.Point(354, 56);
            this.clear_serie_path_button.Name = "clear_serie_path_button";
            this.clear_serie_path_button.Size = new System.Drawing.Size(36, 26);
            this.clear_serie_path_button.TabIndex = 12;
            this.clear_serie_path_button.UseVisualStyleBackColor = false;
            this.clear_serie_path_button.Click += new System.EventHandler(this.ClearPath);
            // 
            // clear_movie_path_button
            // 
            this.clear_movie_path_button.BackColor = System.Drawing.Color.Thistle;
            this.clear_movie_path_button.Enabled = false;
            this.clear_movie_path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_movie_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_movie_path_button.Image = ((System.Drawing.Image)(resources.GetObject("clear_movie_path_button.Image")));
            this.clear_movie_path_button.Location = new System.Drawing.Point(354, 23);
            this.clear_movie_path_button.Name = "clear_movie_path_button";
            this.clear_movie_path_button.Size = new System.Drawing.Size(36, 26);
            this.clear_movie_path_button.TabIndex = 11;
            this.clear_movie_path_button.UseVisualStyleBackColor = false;
            this.clear_movie_path_button.Click += new System.EventHandler(this.ClearPath);
            // 
            // themes_gb
            // 
            this.themes_gb.Controls.Add(this.dark_rb);
            this.themes_gb.Controls.Add(this.light_rb);
            this.themes_gb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themes_gb.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themes_gb.Location = new System.Drawing.Point(396, 23);
            this.themes_gb.Name = "themes_gb";
            this.themes_gb.Size = new System.Drawing.Size(77, 91);
            this.themes_gb.TabIndex = 10;
            this.themes_gb.TabStop = false;
            this.themes_gb.Text = "Themes";
            // 
            // dark_rb
            // 
            this.dark_rb.AutoSize = true;
            this.dark_rb.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dark_rb.Location = new System.Drawing.Point(8, 55);
            this.dark_rb.Name = "dark_rb";
            this.dark_rb.Size = new System.Drawing.Size(53, 19);
            this.dark_rb.TabIndex = 1;
            this.dark_rb.Text = "Dark";
            this.dark_rb.UseVisualStyleBackColor = true;
            this.dark_rb.CheckedChanged += new System.EventHandler(this.ThemeRadioButtonCheckedChanged);
            // 
            // light_rb
            // 
            this.light_rb.AutoSize = true;
            this.light_rb.Checked = true;
            this.light_rb.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.light_rb.Location = new System.Drawing.Point(8, 22);
            this.light_rb.Name = "light_rb";
            this.light_rb.Size = new System.Drawing.Size(56, 19);
            this.light_rb.TabIndex = 0;
            this.light_rb.TabStop = true;
            this.light_rb.Text = "Light";
            this.light_rb.UseVisualStyleBackColor = true;
            this.light_rb.CheckedChanged += new System.EventHandler(this.ThemeRadioButtonCheckedChanged);
            // 
            // open_book_path_button
            // 
            this.open_book_path_button.BackColor = System.Drawing.Color.Khaki;
            this.open_book_path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_book_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_book_path_button.Image = ((System.Drawing.Image)(resources.GetObject("open_book_path_button.Image")));
            this.open_book_path_button.Location = new System.Drawing.Point(312, 88);
            this.open_book_path_button.Name = "open_book_path_button";
            this.open_book_path_button.Size = new System.Drawing.Size(36, 26);
            this.open_book_path_button.TabIndex = 9;
            this.open_book_path_button.UseVisualStyleBackColor = false;
            this.open_book_path_button.Click += new System.EventHandler(this.OpenPath);
            // 
            // book_path_tb
            // 
            this.book_path_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.book_path_tb.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.book_path_tb.Location = new System.Drawing.Point(80, 88);
            this.book_path_tb.Name = "book_path_tb";
            this.book_path_tb.ReadOnly = true;
            this.book_path_tb.Size = new System.Drawing.Size(226, 25);
            this.book_path_tb.TabIndex = 8;
            this.book_path_tb.TextChanged += new System.EventHandler(this.PathChanged);
            // 
            // book_path_lbl
            // 
            this.book_path_lbl.AutoSize = true;
            this.book_path_lbl.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.book_path_lbl.Location = new System.Drawing.Point(11, 95);
            this.book_path_lbl.Name = "book_path_lbl";
            this.book_path_lbl.Size = new System.Drawing.Size(63, 14);
            this.book_path_lbl.TabIndex = 7;
            this.book_path_lbl.Text = "Book List:";
            // 
            // open_serie_path_button
            // 
            this.open_serie_path_button.BackColor = System.Drawing.Color.Khaki;
            this.open_serie_path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_serie_path_button.Font = new System.Drawing.Font("Advanced Pixel-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_serie_path_button.Image = ((System.Drawing.Image)(resources.GetObject("open_serie_path_button.Image")));
            this.open_serie_path_button.Location = new System.Drawing.Point(312, 56);
            this.open_serie_path_button.Name = "open_serie_path_button";
            this.open_serie_path_button.Size = new System.Drawing.Size(36, 26);
            this.open_serie_path_button.TabIndex = 6;
            this.open_serie_path_button.UseVisualStyleBackColor = false;
            this.open_serie_path_button.Click += new System.EventHandler(this.OpenPath);
            // 
            // serie_path_tb
            // 
            this.serie_path_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serie_path_tb.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serie_path_tb.Location = new System.Drawing.Point(80, 56);
            this.serie_path_tb.Name = "serie_path_tb";
            this.serie_path_tb.ReadOnly = true;
            this.serie_path_tb.Size = new System.Drawing.Size(226, 25);
            this.serie_path_tb.TabIndex = 5;
            this.serie_path_tb.TextChanged += new System.EventHandler(this.PathChanged);
            // 
            // serie_path_lbl
            // 
            this.serie_path_lbl.AutoSize = true;
            this.serie_path_lbl.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serie_path_lbl.Location = new System.Drawing.Point(11, 63);
            this.serie_path_lbl.Name = "serie_path_lbl";
            this.serie_path_lbl.Size = new System.Drawing.Size(63, 14);
            this.serie_path_lbl.TabIndex = 4;
            this.serie_path_lbl.Text = "Serie List:";
            // 
            // openfiledialog
            // 
            this.openfiledialog.FileName = "openfiledialog";
            // 
            // settings_error_provider
            // 
            this.settings_error_provider.ContainerControl = this;
            this.settings_error_provider.Icon = ((System.Drawing.Icon)(resources.GetObject("settings_error_provider.Icon")));
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(504, 172);
            this.Controls.Add(this.settings_gb);
            this.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsFormClosing);
            this.Load += new System.EventHandler(this.SettingsLoad);
            this.settings_gb.ResumeLayout(false);
            this.settings_gb.PerformLayout();
            this.themes_gb.ResumeLayout(false);
            this.themes_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_error_provider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_movie_path_button;
        private System.Windows.Forms.TextBox movie_path_tb;
        private System.Windows.Forms.Label movie_path_lbl;
        private System.Windows.Forms.Button save_settings_button;
        private System.Windows.Forms.GroupBox settings_gb;
        private System.Windows.Forms.GroupBox themes_gb;
        private System.Windows.Forms.RadioButton dark_rb;
        private System.Windows.Forms.RadioButton light_rb;
        private System.Windows.Forms.Button open_book_path_button;
        private System.Windows.Forms.TextBox book_path_tb;
        private System.Windows.Forms.Label book_path_lbl;
        private System.Windows.Forms.Button open_serie_path_button;
        private System.Windows.Forms.TextBox serie_path_tb;
        private System.Windows.Forms.Label serie_path_lbl;
        private System.Windows.Forms.OpenFileDialog openfiledialog;
        private System.Windows.Forms.Button clear_movie_path_button;
        private System.Windows.Forms.Button clear_book_path_button;
        private System.Windows.Forms.Button clear_serie_path_button;
        private System.Windows.Forms.ErrorProvider settings_error_provider;
    }
}