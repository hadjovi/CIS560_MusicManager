namespace MusicManagerUI
{
    partial class StatsDisplayDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsDisplayDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.uxSongBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxArtistBox = new System.Windows.Forms.TextBox();
            this.uxGenreBox = new System.Windows.Forms.ListBox();
            this.uxSearchArtist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uxOriginality = new System.Windows.Forms.TextBox();
            this.uxIndBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxGenre = new System.Windows.Forms.ListBox();
            this.uxSearch = new System.Windows.Forms.Button();
            this.uxRuntime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top 10 most Popular songs in playlists:";
            // 
            // uxSongBox
            // 
            this.uxSongBox.FormattingEnabled = true;
            this.uxSongBox.ItemHeight = 15;
            this.uxSongBox.Location = new System.Drawing.Point(45, 51);
            this.uxSongBox.Name = "uxSongBox";
            this.uxSongBox.Size = new System.Drawing.Size(149, 154);
            this.uxSongBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist Collabs";
            // 
            // uxArtistBox
            // 
            this.uxArtistBox.Location = new System.Drawing.Point(329, 58);
            this.uxArtistBox.Name = "uxArtistBox";
            this.uxArtistBox.Size = new System.Drawing.Size(100, 23);
            this.uxArtistBox.TabIndex = 3;
            this.uxArtistBox.Text = "(Artist ID)";
            // 
            // uxGenreBox
            // 
            this.uxGenreBox.FormattingEnabled = true;
            this.uxGenreBox.ItemHeight = 15;
            this.uxGenreBox.Location = new System.Drawing.Point(329, 149);
            this.uxGenreBox.Name = "uxGenreBox";
            this.uxGenreBox.Size = new System.Drawing.Size(120, 94);
            this.uxGenreBox.TabIndex = 4;
            // 
            // uxSearchArtist
            // 
            this.uxSearchArtist.Location = new System.Drawing.Point(329, 101);
            this.uxSearchArtist.Name = "uxSearchArtist";
            this.uxSearchArtist.Size = new System.Drawing.Size(90, 23);
            this.uxSearchArtist.TabIndex = 6;
            this.uxSearchArtist.Text = "Search Artist";
            this.uxSearchArtist.UseVisualStyleBackColor = true;
            this.uxSearchArtist.Click += new System.EventHandler(this.uxSearchArtist_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "See runtime of a playlist:";
            // 
            // uxOriginality
            // 
            this.uxOriginality.Location = new System.Drawing.Point(495, 58);
            this.uxOriginality.Name = "uxOriginality";
            this.uxOriginality.Size = new System.Drawing.Size(100, 23);
            this.uxOriginality.TabIndex = 10;
            this.uxOriginality.Text = "(Playlist ID)";
            // 
            // uxIndBox
            // 
            this.uxIndBox.FormattingEnabled = true;
            this.uxIndBox.ItemHeight = 15;
            this.uxIndBox.Location = new System.Drawing.Point(13, 51);
            this.uxIndBox.Name = "uxIndBox";
            this.uxIndBox.Size = new System.Drawing.Size(33, 154);
            this.uxIndBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "And most popular Genres in order:";
            // 
            // uxGenre
            // 
            this.uxGenre.FormattingEnabled = true;
            this.uxGenre.ItemHeight = 15;
            this.uxGenre.Location = new System.Drawing.Point(208, 51);
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Size = new System.Drawing.Size(103, 154);
            this.uxGenre.TabIndex = 13;
            // 
            // uxSearch
            // 
            this.uxSearch.Location = new System.Drawing.Point(495, 101);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(100, 23);
            this.uxSearch.TabIndex = 14;
            this.uxSearch.Text = "Search Playlist";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxRuntime
            // 
            this.uxRuntime.Enabled = false;
            this.uxRuntime.Location = new System.Drawing.Point(495, 149);
            this.uxRuntime.Multiline = true;
            this.uxRuntime.Name = "uxRuntime";
            this.uxRuntime.Size = new System.Drawing.Size(111, 94);
            this.uxRuntime.TabIndex = 16;
            this.uxRuntime.TextChanged += new System.EventHandler(this.uxRuntime_TextChanged);
            // 
            // StatsDisplayDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 299);
            this.Controls.Add(this.uxRuntime);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.uxGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxIndBox);
            this.Controls.Add(this.uxOriginality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxSearchArtist);
            this.Controls.Add(this.uxGenreBox);
            this.Controls.Add(this.uxArtistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxSongBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatsDisplayDialog";
            this.Text = "Gee - Whiz Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox uxSongBox;
        private Label label2;
        private TextBox uxArtistBox;
        private ListBox uxGenreBox;
        private Button uxSearchArtist;
        private Label label3;
        private TextBox uxOriginality;
        private ListBox uxIndBox;
        private Label label5;
        private ListBox uxGenre;
        private Button uxSearch;
        private TextBox uxRuntime;
    }
}