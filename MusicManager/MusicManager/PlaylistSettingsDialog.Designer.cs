namespace MusicManagerUI
{
    partial class PlaylistSettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistSettingsDialog));
            this.uxPlaylistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxIsPrivate = new System.Windows.Forms.CheckBox();
            this.uxUpdateSettings = new System.Windows.Forms.Button();
            this.uxDeletePlaylist = new System.Windows.Forms.CheckBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxPlaylistName
            // 
            this.uxPlaylistName.Location = new System.Drawing.Point(41, 27);
            this.uxPlaylistName.Name = "uxPlaylistName";
            this.uxPlaylistName.Size = new System.Drawing.Size(146, 23);
            this.uxPlaylistName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlist Name: ";
            // 
            // uxIsPrivate
            // 
            this.uxIsPrivate.AutoSize = true;
            this.uxIsPrivate.Location = new System.Drawing.Point(41, 65);
            this.uxIsPrivate.Name = "uxIsPrivate";
            this.uxIsPrivate.Size = new System.Drawing.Size(62, 19);
            this.uxIsPrivate.TabIndex = 4;
            this.uxIsPrivate.Text = "Private";
            this.uxIsPrivate.UseVisualStyleBackColor = true;
            // 
            // uxUpdateSettings
            // 
            this.uxUpdateSettings.Location = new System.Drawing.Point(12, 150);
            this.uxUpdateSettings.Name = "uxUpdateSettings";
            this.uxUpdateSettings.Size = new System.Drawing.Size(117, 39);
            this.uxUpdateSettings.TabIndex = 5;
            this.uxUpdateSettings.Text = "Update Settings";
            this.uxUpdateSettings.UseVisualStyleBackColor = true;
            this.uxUpdateSettings.Click += new System.EventHandler(this.uxUpdateSettings_Click);
            // 
            // uxDeletePlaylist
            // 
            this.uxDeletePlaylist.AutoSize = true;
            this.uxDeletePlaylist.Location = new System.Drawing.Point(41, 106);
            this.uxDeletePlaylist.Name = "uxDeletePlaylist";
            this.uxDeletePlaylist.Size = new System.Drawing.Size(104, 19);
            this.uxDeletePlaylist.TabIndex = 6;
            this.uxDeletePlaylist.Text = "DELETE Playlist";
            this.uxDeletePlaylist.UseVisualStyleBackColor = true;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(135, 150);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(72, 39);
            this.uxCancel.TabIndex = 7;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // PlaylistSettingsDialog
            // 
            this.AcceptButton = this.uxUpdateSettings;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancel;
            this.ClientSize = new System.Drawing.Size(219, 201);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxDeletePlaylist);
            this.Controls.Add(this.uxUpdateSettings);
            this.Controls.Add(this.uxIsPrivate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPlaylistName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlaylistSettingsDialog";
            this.Text = "Playlist Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox uxPlaylistName;
        private Label label1;
        private CheckBox uxIsPrivate;
        private Button uxUpdateSettings;
        private CheckBox uxDeletePlaylist;
        private Button uxCancel;
    }
}