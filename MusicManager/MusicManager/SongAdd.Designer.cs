namespace MusicManagerUI
{
    partial class SongAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxResultBox = new System.Windows.Forms.DataGridView();
            this.uxSongNameBox = new System.Windows.Forms.TextBox();
            this.uxAlbumTitleBox = new System.Windows.Forms.TextBox();
            this.uxTrySearch = new System.Windows.Forms.Button();
            this.uxArtistNameBox = new System.Windows.Forms.TextBox();
            this.uxCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artist Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Playtime";
            // 
            // uxAddButton
            // 
            this.uxAddButton.Location = new System.Drawing.Point(348, 387);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddButton.TabIndex = 5;
            this.uxAddButton.Text = "Add!";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.udAddButton_Click);
            // 
            // uxResultBox
            // 
            this.uxResultBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxResultBox.Location = new System.Drawing.Point(39, 105);
            this.uxResultBox.Name = "uxResultBox";
            this.uxResultBox.RowTemplate.Height = 25;
            this.uxResultBox.Size = new System.Drawing.Size(693, 265);
            this.uxResultBox.TabIndex = 6;
            // 
            // uxSongNameBox
            // 
            this.uxSongNameBox.Location = new System.Drawing.Point(60, 48);
            this.uxSongNameBox.Name = "uxSongNameBox";
            this.uxSongNameBox.Size = new System.Drawing.Size(100, 23);
            this.uxSongNameBox.TabIndex = 7;
            // 
            // uxAlbumTitleBox
            // 
            this.uxAlbumTitleBox.Location = new System.Drawing.Point(218, 48);
            this.uxAlbumTitleBox.Name = "uxAlbumTitleBox";
            this.uxAlbumTitleBox.Size = new System.Drawing.Size(100, 23);
            this.uxAlbumTitleBox.TabIndex = 8;
            // 
            // uxTrySearch
            // 
            this.uxTrySearch.Location = new System.Drawing.Point(348, 77);
            this.uxTrySearch.Name = "uxTrySearch";
            this.uxTrySearch.Size = new System.Drawing.Size(75, 23);
            this.uxTrySearch.TabIndex = 10;
            this.uxTrySearch.Text = "Try Search";
            this.uxTrySearch.UseVisualStyleBackColor = true;
            this.uxTrySearch.Click += new System.EventHandler(this.uxTrySearch_Click);
            // 
            // uxArtistNameBox
            // 
            this.uxArtistNameBox.Location = new System.Drawing.Point(378, 48);
            this.uxArtistNameBox.Name = "uxArtistNameBox";
            this.uxArtistNameBox.Size = new System.Drawing.Size(100, 23);
            this.uxArtistNameBox.TabIndex = 11;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(572, 387);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 12;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // SongAdd
            // 
            this.AcceptButton = this.uxAddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancel;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxArtistNameBox);
            this.Controls.Add(this.uxTrySearch);
            this.Controls.Add(this.uxAlbumTitleBox);
            this.Controls.Add(this.uxSongNameBox);
            this.Controls.Add(this.uxResultBox);
            this.Controls.Add(this.uxAddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SongAdd";
            this.Text = "Add Song";
            ((System.ComponentModel.ISupportInitialize)(this.uxResultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button uxAddButton;
        private DataGridView uxResultBox;
        private TextBox uxSongNameBox;
        private TextBox uxAlbumTitleBox;
        private Button uxTrySearch;
        private TextBox uxArtistNameBox;
        private Button uxCancel;
    }
}