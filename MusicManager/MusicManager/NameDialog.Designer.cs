namespace MusicManagerUI
{
    partial class NameDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameDialog));
            this.Name = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxCreate = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(40, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 15);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name: ";
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(103, 19);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(100, 23);
            this.uxName.TabIndex = 1;
            // 
            // uxCreate
            // 
            this.uxCreate.Location = new System.Drawing.Point(23, 61);
            this.uxCreate.Name = "uxCreate";
            this.uxCreate.Size = new System.Drawing.Size(75, 23);
            this.uxCreate.TabIndex = 2;
            this.uxCreate.Text = "Create";
            this.uxCreate.UseVisualStyleBackColor = true;
            this.uxCreate.Click += new System.EventHandler(this.uxCreate_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(152, 61);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 3;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // NameDialog
            // 
            this.AcceptButton = this.uxCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancel;
            this.ClientSize = new System.Drawing.Size(239, 101);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxCreate);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name.Name = "NameDialog";
            this.Text = "NameDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Name;
        private TextBox uxName;
        private Button uxCreate;
        private Button uxCancel;
    }
}