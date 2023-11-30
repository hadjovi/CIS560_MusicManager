namespace MusicManagerUI
{
    partial class CreatePlaylistDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePlaylistDialog));
            this.uxNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxPrivate = new System.Windows.Forms.CheckBox();
            this.uxCreate = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxNameBox
            // 
            this.uxNameBox.Location = new System.Drawing.Point(100, 21);
            this.uxNameBox.Name = "uxNameBox";
            this.uxNameBox.Size = new System.Drawing.Size(100, 23);
            this.uxNameBox.TabIndex = 0;
            this.uxNameBox.TextChanged += new System.EventHandler(this.uxNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlist Name:";
            // 
            // uxPrivate
            // 
            this.uxPrivate.AutoSize = true;
            this.uxPrivate.Location = new System.Drawing.Point(66, 64);
            this.uxPrivate.Name = "uxPrivate";
            this.uxPrivate.Size = new System.Drawing.Size(62, 19);
            this.uxPrivate.TabIndex = 2;
            this.uxPrivate.Text = "Private";
            this.uxPrivate.UseVisualStyleBackColor = true;
            // 
            // uxCreate
            // 
            this.uxCreate.Location = new System.Drawing.Point(30, 106);
            this.uxCreate.Name = "uxCreate";
            this.uxCreate.Size = new System.Drawing.Size(75, 23);
            this.uxCreate.TabIndex = 3;
            this.uxCreate.Text = "Create";
            this.uxCreate.UseVisualStyleBackColor = true;
            this.uxCreate.Click += new System.EventHandler(this.uxCreate_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(135, 106);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 4;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // CreatePlaylistDialog
            // 
            this.AcceptButton = this.uxCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancel;
            this.ClientSize = new System.Drawing.Size(238, 163);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxCreate);
            this.Controls.Add(this.uxPrivate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxNameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePlaylistDialog";
            this.Text = "CreatePlaylistDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox uxNameBox;
        private Label label1;
        private CheckBox uxPrivate;
        private Button uxCreate;
        private Button uxCancel;
    }
}