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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxSignOut = new System.Windows.Forms.Button();
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
            this.uxPlaylistOwnerName = new System.Windows.Forms.Label();
            this.uxLibraryOwnerName = new System.Windows.Forms.Label();
            this.uxPlaylistSettings = new System.Windows.Forms.Button();
            this.uxStats = new System.Windows.Forms.Button();
            this.uxDeleteSong = new System.Windows.Forms.Button();
            this.uxCreatePlaylist = new System.Windows.Forms.Button();
            this.uxAddToLib = new System.Windows.Forms.Button();
            this.uxRemovePlaylist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxSongslist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlaylists)).BeginInit();
            this.SuspendLayout();
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
            // uxSignOut
            // 
            this.uxSignOut.Location = new System.Drawing.Point(697, 407);
            this.uxSignOut.Name = "uxSignOut";
            this.uxSignOut.Size = new System.Drawing.Size(86, 31);
            this.uxSignOut.TabIndex = 4;
            this.uxSignOut.Text = "Sign Out";
            this.uxSignOut.UseVisualStyleBackColor = true;
            this.uxSignOut.Click += new System.EventHandler(this.uxSignOut_Click);
            // 
            // uxSongslist
            // 
            this.uxSongslist.AllowUserToAddRows = false;
            this.uxSongslist.AllowUserToDeleteRows = false;
            this.uxSongslist.AllowUserToResizeRows = false;
            this.uxSongslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxSongslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxSongslist.Location = new System.Drawing.Point(14, 93);
            this.uxSongslist.Name = "uxSongslist";
            this.uxSongslist.RowHeadersVisible = false;
            this.uxSongslist.RowTemplate.Height = 25;
            this.uxSongslist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxSongslist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxSongslist.Size = new System.Drawing.Size(466, 263);
            this.uxSongslist.TabIndex = 6;
            // 
            // uxPlaylists
            // 
            this.uxPlaylists.AllowUserToAddRows = false;
            this.uxPlaylists.AllowUserToDeleteRows = false;
            this.uxPlaylists.AllowUserToResizeRows = false;
            this.uxPlaylists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxPlaylists.ColumnHeadersVisible = false;
            this.uxPlaylists.Location = new System.Drawing.Point(548, 93);
            this.uxPlaylists.MultiSelect = false;
            this.uxPlaylists.Name = "uxPlaylists";
            this.uxPlaylists.RowHeadersVisible = false;
            this.uxPlaylists.RowTemplate.Height = 25;
            this.uxPlaylists.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxPlaylists.Size = new System.Drawing.Size(240, 263);
            this.uxPlaylists.TabIndex = 7;
            this.uxPlaylists.SelectionChanged += new System.EventHandler(this.uxPlaylists_SelectionChanged);
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
            this.uxPlaylistName.Location = new System.Drawing.Point(43, 18);
            this.uxPlaylistName.Name = "uxPlaylistName";
            this.uxPlaylistName.Size = new System.Drawing.Size(96, 15);
            this.uxPlaylistName.TabIndex = 12;
            this.uxPlaylistName.Text = "__PlaylistName__";
            // 
            // uxNoPlaylistWarning
            // 
            this.uxNoPlaylistWarning.AutoSize = true;
            this.uxNoPlaylistWarning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxNoPlaylistWarning.Location = new System.Drawing.Point(188, 210);
            this.uxNoPlaylistWarning.Name = "uxNoPlaylistWarning";
            this.uxNoPlaylistWarning.Size = new System.Drawing.Size(206, 21);
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
            this.uxSearchUsers.Click += new System.EventHandler(this.uxSearchUsers_Click);
            // 
            // uxMyPlaylists
            // 
            this.uxMyPlaylists.Location = new System.Drawing.Point(548, 362);
            this.uxMyPlaylists.Name = "uxMyPlaylists";
            this.uxMyPlaylists.Size = new System.Drawing.Size(112, 23);
            this.uxMyPlaylists.TabIndex = 15;
            this.uxMyPlaylists.Text = "My Playlists";
            this.uxMyPlaylists.UseVisualStyleBackColor = true;
            this.uxMyPlaylists.Click += new System.EventHandler(this.uxMyPlaylists_Click);
            // 
            // uxAddSong
            // 
            this.uxAddSong.Location = new System.Drawing.Point(107, 375);
            this.uxAddSong.Name = "uxAddSong";
            this.uxAddSong.Size = new System.Drawing.Size(75, 23);
            this.uxAddSong.TabIndex = 16;
            this.uxAddSong.Text = "Add Song!";
            this.uxAddSong.UseVisualStyleBackColor = true;
            this.uxAddSong.Click += new System.EventHandler(this.uxAddSong_Click);
            // 
            // uxPlaylistOwnerName
            // 
            this.uxPlaylistOwnerName.AutoSize = true;
            this.uxPlaylistOwnerName.Location = new System.Drawing.Point(295, 18);
            this.uxPlaylistOwnerName.Name = "uxPlaylistOwnerName";
            this.uxPlaylistOwnerName.Size = new System.Drawing.Size(99, 15);
            this.uxPlaylistOwnerName.TabIndex = 17;
            this.uxPlaylistOwnerName.Text = "__PlaylistOwner__";
            // 
            // uxLibraryOwnerName
            // 
            this.uxLibraryOwnerName.AutoSize = true;
            this.uxLibraryOwnerName.Location = new System.Drawing.Point(622, 18);
            this.uxLibraryOwnerName.Name = "uxLibraryOwnerName";
            this.uxLibraryOwnerName.Size = new System.Drawing.Size(98, 15);
            this.uxLibraryOwnerName.TabIndex = 18;
            this.uxLibraryOwnerName.Text = "__LibraryOwner__";
            // 
            // uxPlaylistSettings
            // 
            this.uxPlaylistSettings.Location = new System.Drawing.Point(550, 391);
            this.uxPlaylistSettings.Name = "uxPlaylistSettings";
            this.uxPlaylistSettings.Size = new System.Drawing.Size(110, 23);
            this.uxPlaylistSettings.TabIndex = 19;
            this.uxPlaylistSettings.Text = "Playlist Settings";
            this.uxPlaylistSettings.UseVisualStyleBackColor = true;
            this.uxPlaylistSettings.Click += new System.EventHandler(this.uxPlaylistSettings_Click);
            // 
            // uxStats
            // 
            this.uxStats.Location = new System.Drawing.Point(339, 375);
            this.uxStats.Name = "uxStats";
            this.uxStats.Size = new System.Drawing.Size(119, 23);
            this.uxStats.TabIndex = 20;
            this.uxStats.Text = "Gee-Whiz Stats";
            this.uxStats.UseVisualStyleBackColor = true;
            this.uxStats.Click += new System.EventHandler(this.uxStats_Click);
            // 
            // uxDeleteSong
            // 
            this.uxDeleteSong.Location = new System.Drawing.Point(228, 375);
            this.uxDeleteSong.Name = "uxDeleteSong";
            this.uxDeleteSong.Size = new System.Drawing.Size(83, 23);
            this.uxDeleteSong.TabIndex = 21;
            this.uxDeleteSong.Text = "Delete Song";
            this.uxDeleteSong.UseVisualStyleBackColor = true;
            this.uxDeleteSong.Click += new System.EventHandler(this.uxDeleteSong_Click);
            // 
            // uxCreatePlaylist
            // 
            this.uxCreatePlaylist.Location = new System.Drawing.Point(550, 424);
            this.uxCreatePlaylist.Name = "uxCreatePlaylist";
            this.uxCreatePlaylist.Size = new System.Drawing.Size(110, 23);
            this.uxCreatePlaylist.TabIndex = 23;
            this.uxCreatePlaylist.Text = "Create Playlist";
            this.uxCreatePlaylist.UseVisualStyleBackColor = true;
            this.uxCreatePlaylist.Click += new System.EventHandler(this.uxCreatePlaylist_Click);
            // 
            // uxAddToLib
            // 
            this.uxAddToLib.Location = new System.Drawing.Point(339, 404);
            this.uxAddToLib.Name = "uxAddToLib";
            this.uxAddToLib.Size = new System.Drawing.Size(119, 43);
            this.uxAddToLib.TabIndex = 24;
            this.uxAddToLib.Text = "Add Playlist to Library";
            this.uxAddToLib.UseVisualStyleBackColor = true;
            this.uxAddToLib.Click += new System.EventHandler(this.uxAddToLib_Click);
            // 
            // uxRemovePlaylist
            // 
            this.uxRemovePlaylist.Location = new System.Drawing.Point(188, 407);
            this.uxRemovePlaylist.Name = "uxRemovePlaylist";
            this.uxRemovePlaylist.Size = new System.Drawing.Size(123, 40);
            this.uxRemovePlaylist.TabIndex = 25;
            this.uxRemovePlaylist.Text = "Remove Friend Playlist from Library";
            this.uxRemovePlaylist.UseVisualStyleBackColor = true;
            this.uxRemovePlaylist.Click += new System.EventHandler(this.uxRemovePlaylist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxRemovePlaylist);
            this.Controls.Add(this.uxAddToLib);
            this.Controls.Add(this.uxCreatePlaylist);
            this.Controls.Add(this.uxDeleteSong);
            this.Controls.Add(this.uxStats);
            this.Controls.Add(this.uxPlaylistSettings);
            this.Controls.Add(this.uxLibraryOwnerName);
            this.Controls.Add(this.uxPlaylistOwnerName);
            this.Controls.Add(this.uxAddSong);
            this.Controls.Add(this.uxMyPlaylists);
            this.Controls.Add(this.uxSearchUsers);
            this.Controls.Add(this.uxPlaylistName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxPlaylists);
            this.Controls.Add(this.uxSongslist);
            this.Controls.Add(this.uxSignOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxNoPlaylistWarning);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MusicManager";
            ((System.ComponentModel.ISupportInitialize)(this.uxSongslist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlaylists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Button uxSignOut;
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
        private Label uxPlaylistOwnerName;
        private Label uxLibraryOwnerName;
        private Button uxPlaylistSettings;
        private Button uxStats;
        private Button uxDeleteSong;
        private Button uxCreatePlaylist;
        private Button uxAddToLib;
        private Button uxRemovePlaylist;
    }
}