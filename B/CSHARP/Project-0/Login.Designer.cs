namespace Project_0
{
    partial class Login
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
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblpwd = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(197, 39);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(50, 16);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User Id";
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.Location = new System.Drawing.Point(197, 144);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(70, 16);
            this.lblpwd.TabIndex = 1;
            this.lblpwd.Text = "Password:";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(307, 39);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(145, 22);
            this.txtUserID.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(307, 138);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(145, 22);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(340, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblUserId);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
    }
}