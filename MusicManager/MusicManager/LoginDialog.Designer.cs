namespace MusicManagerUI
{
    partial class LoginDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxPasswordBox = new System.Windows.Forms.TextBox();
            this.uxEmailBox = new System.Windows.Forms.TextBox();
            this.uxLoginButton = new System.Windows.Forms.Button();
            this.uxLoginBad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // uxPasswordBox
            // 
            this.uxPasswordBox.Location = new System.Drawing.Point(89, 64);
            this.uxPasswordBox.Name = "uxPasswordBox";
            this.uxPasswordBox.Size = new System.Drawing.Size(149, 23);
            this.uxPasswordBox.TabIndex = 2;
            // 
            // uxEmailBox
            // 
            this.uxEmailBox.Location = new System.Drawing.Point(89, 26);
            this.uxEmailBox.Name = "uxEmailBox";
            this.uxEmailBox.Size = new System.Drawing.Size(149, 23);
            this.uxEmailBox.TabIndex = 3;
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.Location = new System.Drawing.Point(89, 93);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(75, 23);
            this.uxLoginButton.TabIndex = 4;
            this.uxLoginButton.Text = "Submit";
            this.uxLoginButton.UseVisualStyleBackColor = true;
            this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
            // 
            // uxLoginBad
            // 
            this.uxLoginBad.AutoSize = true;
            this.uxLoginBad.Location = new System.Drawing.Point(91, 4);
            this.uxLoginBad.Name = "uxLoginBad";
            this.uxLoginBad.Size = new System.Drawing.Size(144, 15);
            this.uxLoginBad.TabIndex = 5;
            this.uxLoginBad.Text = "Error: Login does not exist";
            this.uxLoginBad.Visible = false;
            // 
            // LoginDialog
            // 
            this.AcceptButton = this.uxLoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 126);
            this.Controls.Add(this.uxLoginBad);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxEmailBox);
            this.Controls.Add(this.uxPasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginDialog";
            this.Text = "Login Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox uxPasswordBox;
        private TextBox uxEmailBox;
        private Button uxLoginButton;
        private Label uxLoginBad;
    }
}