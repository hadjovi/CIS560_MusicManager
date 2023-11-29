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
            this.uxArtistDNELabel = new System.Windows.Forms.Label();
            this.uxSearchArtist = new System.Windows.Forms.Button();
            this.uxEmailBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxOriginality = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top 10 most Popular songs in playlists:";
            // 
            // uxSongBox
            // 
            this.uxSongBox.FormattingEnabled = true;
            this.uxSongBox.ItemHeight = 15;
            this.uxSongBox.Location = new System.Drawing.Point(32, 58);
            this.uxSongBox.Name = "uxSongBox";
            this.uxSongBox.Size = new System.Drawing.Size(184, 199);
            this.uxSongBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "See what Genres an artist belongs to:";
            // 
            // uxArtistBox
            // 
            this.uxArtistBox.Location = new System.Drawing.Point(290, 54);
            this.uxArtistBox.Name = "uxArtistBox";
            this.uxArtistBox.Size = new System.Drawing.Size(100, 23);
            this.uxArtistBox.TabIndex = 3;
            // 
            // uxGenreBox
            // 
            this.uxGenreBox.FormattingEnabled = true;
            this.uxGenreBox.ItemHeight = 15;
            this.uxGenreBox.Location = new System.Drawing.Point(281, 163);
            this.uxGenreBox.Name = "uxGenreBox";
            this.uxGenreBox.Size = new System.Drawing.Size(120, 94);
            this.uxGenreBox.TabIndex = 4;
            // 
            // uxArtistDNELabel
            // 
            this.uxArtistDNELabel.AutoSize = true;
            this.uxArtistDNELabel.Location = new System.Drawing.Point(290, 80);
            this.uxArtistDNELabel.Name = "uxArtistDNELabel";
            this.uxArtistDNELabel.Size = new System.Drawing.Size(111, 15);
            this.uxArtistDNELabel.TabIndex = 5;
            this.uxArtistDNELabel.Text = "Artist does not exist";
            // 
            // uxSearchArtist
            // 
            this.uxSearchArtist.Location = new System.Drawing.Point(290, 111);
            this.uxSearchArtist.Name = "uxSearchArtist";
            this.uxSearchArtist.Size = new System.Drawing.Size(90, 23);
            this.uxSearchArtist.TabIndex = 6;
            this.uxSearchArtist.Text = "Search Artist";
            this.uxSearchArtist.UseVisualStyleBackColor = true;
            this.uxSearchArtist.Click += new System.EventHandler(this.uxSearchArtist_Click);
            // 
            // uxEmailBox
            // 
            this.uxEmailBox.FormattingEnabled = true;
            this.uxEmailBox.ItemHeight = 15;
            this.uxEmailBox.Location = new System.Drawing.Point(470, 58);
            this.uxEmailBox.Name = "uxEmailBox";
            this.uxEmailBox.Size = new System.Drawing.Size(120, 94);
            this.uxEmailBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "See how \"Original\" a user is:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "\"Originality Score\"";
            // 
            // uxOriginality
            // 
            this.uxOriginality.Location = new System.Drawing.Point(474, 205);
            this.uxOriginality.Name = "uxOriginality";
            this.uxOriginality.Size = new System.Drawing.Size(100, 23);
            this.uxOriginality.TabIndex = 10;
            // 
            // StatsDisplayDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 299);
            this.Controls.Add(this.uxOriginality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxEmailBox);
            this.Controls.Add(this.uxSearchArtist);
            this.Controls.Add(this.uxArtistDNELabel);
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
        private Label uxArtistDNELabel;
        private Button uxSearchArtist;
        private ListBox uxEmailBox;
        private Label label3;
        private Label label4;
        private TextBox uxOriginality;
    }
}