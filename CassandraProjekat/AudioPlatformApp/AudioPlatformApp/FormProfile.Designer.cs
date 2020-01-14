namespace AudioPlatformApp
{
    partial class FormProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblPlatformTier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgwSongs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfile = new Bunifu.Framework.UI.BunifuTileButton();
            this.tnPlay = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(22, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 43);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblName";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(162, 460);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 28);
            this.txtSearch.TabIndex = 8;
            // 
            // lblPlatformTier
            // 
            this.lblPlatformTier.BackColor = System.Drawing.Color.Transparent;
            this.lblPlatformTier.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlatformTier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlatformTier.Location = new System.Drawing.Point(195, 19);
            this.lblPlatformTier.Name = "lblPlatformTier";
            this.lblPlatformTier.Size = new System.Drawing.Size(121, 43);
            this.lblPlatformTier.TabIndex = 12;
            this.lblPlatformTier.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search by:";
            // 
            // comboSearch
            // 
            this.comboSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Location = new System.Drawing.Point(469, 460);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(195, 29);
            this.comboSearch.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(174, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Insert text:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AudioPlatformApp.Properties.Resources._3310_blue_equalizer_bars_1920x1080_abstract_wallpaper;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 634);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dgwSongs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgwSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSongs.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAuthor,
            this.ColName,
            this.ColGenre});
            this.dgwSongs.DoubleBuffered = true;
            this.dgwSongs.EnableHeadersVisualStyles = false;
            this.dgwSongs.HeaderBgColor = System.Drawing.Color.CadetBlue;
            this.dgwSongs.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dgwSongs.Location = new System.Drawing.Point(16, 132);
            this.dgwSongs.Name = "dgwSongs";
            this.dgwSongs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwSongs.RowTemplate.Height = 24;
            this.dgwSongs.Size = new System.Drawing.Size(466, 283);
            this.dgwSongs.TabIndex = 20;
            this.dgwSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSongs_CellContentClick);
            // 
            // ColAuthor
            // 
            this.ColAuthor.HeaderText = "Author";
            this.ColAuthor.Name = "ColAuthor";
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            // 
            // ColGenre
            // 
            this.ColGenre.HeaderText = "Genre";
            this.ColGenre.Name = "ColGenre";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.PowderBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.CadetBlue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Search Songs";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(343, 496);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(321, 59);
            this.bunifuFlatButton2.TabIndex = 26;
            this.bunifuFlatButton2.Text = "Search Songs";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.PowderBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.CadetBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Rate Platform";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(343, 563);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.CadetBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(321, 59);
            this.bunifuFlatButton1.TabIndex = 28;
            this.bunifuFlatButton1.Text = "Rate Platform";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.CadetBlue;
            this.btnProfile.color = System.Drawing.Color.CadetBlue;
            this.btnProfile.colorActive = System.Drawing.Color.DarkTurquoise;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImagePosition = 20;
            this.btnProfile.ImageZoom = 50;
            this.btnProfile.LabelPosition = 41;
            this.btnProfile.LabelText = "My Profile";
            this.btnProfile.Location = new System.Drawing.Point(517, 19);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(147, 128);
            this.btnProfile.TabIndex = 25;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // tnPlay
            // 
            this.tnPlay.Activecolor = System.Drawing.Color.DarkCyan;
            this.tnPlay.BackColor = System.Drawing.Color.CadetBlue;
            this.tnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tnPlay.BorderRadius = 0;
            this.tnPlay.ButtonText = "Play";
            this.tnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tnPlay.DisabledColor = System.Drawing.Color.Gray;
            this.tnPlay.Iconcolor = System.Drawing.Color.Transparent;
            this.tnPlay.Iconimage = ((System.Drawing.Image)(resources.GetObject("tnPlay.Iconimage")));
            this.tnPlay.Iconimage_right = null;
            this.tnPlay.Iconimage_right_Selected = null;
            this.tnPlay.Iconimage_Selected = null;
            this.tnPlay.IconMarginLeft = 0;
            this.tnPlay.IconMarginRight = 0;
            this.tnPlay.IconRightVisible = true;
            this.tnPlay.IconRightZoom = 0D;
            this.tnPlay.IconVisible = true;
            this.tnPlay.IconZoom = 90D;
            this.tnPlay.IsTab = false;
            this.tnPlay.Location = new System.Drawing.Point(16, 89);
            this.tnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tnPlay.Name = "tnPlay";
            this.tnPlay.Normalcolor = System.Drawing.Color.CadetBlue;
            this.tnPlay.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.tnPlay.OnHoverTextColor = System.Drawing.Color.White;
            this.tnPlay.selected = false;
            this.tnPlay.Size = new System.Drawing.Size(186, 36);
            this.tnPlay.TabIndex = 29;
            this.tnPlay.Text = "Play";
            this.tnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tnPlay.Textcolor = System.Drawing.Color.White;
            this.tnPlay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnPlay.Click += new System.EventHandler(this.tnPlay_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(690, 634);
            this.Controls.Add(this.tnPlay);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.dgwSongs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlatformTier);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblPlatformTier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgwSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGenre;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuTileButton btnProfile;
        private Bunifu.Framework.UI.BunifuFlatButton tnPlay;
    }
}