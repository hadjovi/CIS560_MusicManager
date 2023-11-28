namespace MusicManagerUI
{
    partial class UserSearchDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSearchDialog));
            this.uxNameSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSearch = new System.Windows.Forms.Button();
            this.uxUserListBox = new System.Windows.Forms.ListBox();
            this.uxSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxNameSearchBox
            // 
            this.uxNameSearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.uxNameSearchBox.Location = new System.Drawing.Point(81, 22);
            this.uxNameSearchBox.Name = "uxNameSearchBox";
            this.uxNameSearchBox.Size = new System.Drawing.Size(139, 23);
            this.uxNameSearchBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // uxSearch
            // 
            this.uxSearch.Location = new System.Drawing.Point(72, 51);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(75, 23);
            this.uxSearch.TabIndex = 2;
            this.uxSearch.Text = "Search!";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // uxUserListBox
            // 
            this.uxUserListBox.FormattingEnabled = true;
            this.uxUserListBox.ItemHeight = 15;
            this.uxUserListBox.Location = new System.Drawing.Point(27, 80);
            this.uxUserListBox.Name = "uxUserListBox";
            this.uxUserListBox.Size = new System.Drawing.Size(174, 274);
            this.uxUserListBox.TabIndex = 3;
            // 
            // uxSelect
            // 
            this.uxSelect.Enabled = false;
            this.uxSelect.Location = new System.Drawing.Point(72, 360);
            this.uxSelect.Name = "uxSelect";
            this.uxSelect.Size = new System.Drawing.Size(75, 23);
            this.uxSelect.TabIndex = 4;
            this.uxSelect.Text = "Select";
            this.uxSelect.UseVisualStyleBackColor = true;
            this.uxSelect.Click += new System.EventHandler(this.uxSelect_Click);
            // 
            // UserSearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 397);
            this.Controls.Add(this.uxSelect);
            this.Controls.Add(this.uxUserListBox);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxNameSearchBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSearchDialog";
            this.Text = "User Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox uxNameSearchBox;
        private Label label1;
        private Button uxSearch;
        private ListBox uxUserListBox;
        private Button uxSelect;
    }
}