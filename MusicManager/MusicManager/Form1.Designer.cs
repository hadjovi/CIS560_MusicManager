namespace MusicManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uxSongslist = new System.Windows.Forms.DataGridView();
            this.uxPlaylists = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxPlaylistName = new System.Windows.Forms.Label();
            this.uxNoPlaylistWarning = new System.Windows.Forms.Label();
            this.uxSearchUsers = new System.Windows.Forms.Button();
            this.uxMyPlaylists = new System.Windows.Forms.Button();
            this.uxAddSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxSongslist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlaylists)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Runtime";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "#";
            // 
            // uxSongslist
            // 
            this.uxSongslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxSongslist.Location = new System.Drawing.Point(14, 93);
            this.uxSongslist.Name = "uxSongslist";
            this.uxSongslist.RowTemplate.Height = 25;
            this.uxSongslist.Size = new System.Drawing.Size(466, 263);
            this.uxSongslist.TabIndex = 6;
            // 
            // uxPlaylists
            // 
            this.uxPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxPlaylists.Location = new System.Drawing.Point(548, 93);
            this.uxPlaylists.Name = "uxPlaylists";
            this.uxPlaylists.RowTemplate.Height = 25;
            this.uxPlaylists.Size = new System.Drawing.Size(240, 263);
            this.uxPlaylists.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Song Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Artist";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Album";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Runtime";
            // 
            // uxPlaylistName
            // 
            this.uxPlaylistName.AutoSize = true;
            this.uxPlaylistName.Location = new System.Drawing.Point(173, 19);
            this.uxPlaylistName.Name = "uxPlaylistName";
            this.uxPlaylistName.Size = new System.Drawing.Size(96, 15);
            this.uxPlaylistName.TabIndex = 12;
            this.uxPlaylistName.Text = "__PlaylistName__";
            // 
            // uxNoPlaylistWarning
            // 
            this.uxNoPlaylistWarning.AutoSize = true;
            this.uxNoPlaylistWarning.Location = new System.Drawing.Point(312, 362);
            this.uxNoPlaylistWarning.Name = "uxNoPlaylistWarning";
            this.uxNoPlaylistWarning.Size = new System.Drawing.Size(156, 15);
            this.uxNoPlaylistWarning.TabIndex = 13;
            this.uxNoPlaylistWarning.Text = "No playlist currently opened";
            // 
            // uxSearchUsers
            // 
            this.uxSearchUsers.Location = new System.Drawing.Point(676, 362);
            this.uxSearchUsers.Name = "uxSearchUsers";
            this.uxSearchUsers.Size = new System.Drawing.Size(112, 23);
            this.uxSearchUsers.TabIndex = 14;
            this.uxSearchUsers.Text = "Search Users";
            this.uxSearchUsers.UseVisualStyleBackColor = true;
            // 
            // uxMyPlaylists
            // 
            this.uxMyPlaylists.Location = new System.Drawing.Point(548, 362);
            this.uxMyPlaylists.Name = "uxMyPlaylists";
            this.uxMyPlaylists.Size = new System.Drawing.Size(112, 23);
            this.uxMyPlaylists.TabIndex = 15;
            this.uxMyPlaylists.Text = "My Playlists";
            this.uxMyPlaylists.UseVisualStyleBackColor = true;
            // 
            // uxAddSong
            // 
            this.uxAddSong.Location = new System.Drawing.Point(173, 375);
            this.uxAddSong.Name = "uxAddSong";
            this.uxAddSong.Size = new System.Drawing.Size(75, 23);
            this.uxAddSong.TabIndex = 16;
            this.uxAddSong.Text = "Add Song!";
            this.uxAddSong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxAddSong);
            this.Controls.Add(this.uxMyPlaylists);
            this.Controls.Add(this.uxSearchUsers);
            this.Controls.Add(this.uxNoPlaylistWarning);
            this.Controls.Add(this.uxPlaylistName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxPlaylists);
            this.Controls.Add(this.uxSongslist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MusicManager";
            ((System.ComponentModel.ISupportInitialize)(this.uxSongslist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private DataGridView uxSongslist;
        private DataGridView uxPlaylists;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label uxPlaylistName;
        private Label uxNoPlaylistWarning;
        private Button uxSearchUsers;
        private Button uxMyPlaylists;
        private Button uxAddSong;
    }
}