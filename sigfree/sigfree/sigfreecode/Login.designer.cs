namespace sigfree_demo_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.text_username = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.but_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.link_new_user = new System.Windows.Forms.LinkLabel();
            this.link_forget_password = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(403, 64);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(160, 20);
            this.text_username.TabIndex = 0;
            this.text_username.Text = "jitu";
            // 
            // but_login
            // 
            this.but_login.Location = new System.Drawing.Point(403, 160);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(75, 23);
            this.but_login.TabIndex = 2;
            this.but_login.Text = "Login";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // but_Reset
            // 
            this.but_Reset.Location = new System.Drawing.Point(488, 160);
            this.but_Reset.Name = "but_Reset";
            this.but_Reset.Size = new System.Drawing.Size(75, 23);
            this.but_Reset.TabIndex = 3;
            this.but_Reset.Text = "Reset";
            this.but_Reset.UseVisualStyleBackColor = true;
            this.but_Reset.Click += new System.EventHandler(this.but_Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(403, 111);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(160, 20);
            this.text_password.TabIndex = 1;
            this.text_password.Text = "123456";
            // 
            // link_new_user
            // 
            this.link_new_user.AutoSize = true;
            this.link_new_user.Location = new System.Drawing.Point(400, 252);
            this.link_new_user.Name = "link_new_user";
            this.link_new_user.Size = new System.Drawing.Size(104, 13);
            this.link_new_user.TabIndex = 8;
            this.link_new_user.TabStop = true;
            this.link_new_user.Text = "New User Click here";
            this.link_new_user.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_new_user_LinkClicked);
            // 
            // link_forget_password
            // 
            this.link_forget_password.AutoSize = true;
            this.link_forget_password.Location = new System.Drawing.Point(400, 224);
            this.link_forget_password.Name = "link_forget_password";
            this.link_forget_password.Size = new System.Drawing.Size(170, 13);
            this.link_forget_password.TabIndex = 9;
            this.link_forget_password.TabStop = true;
            this.link_forget_password.Text = "Forget your password ...!Click here";
            this.link_forget_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_forget_password_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.but_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(606, 274);
            this.Controls.Add(this.link_forget_password);
            this.Controls.Add(this.link_new_user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Reset);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.text_username);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link_new_user;
        private System.Windows.Forms.LinkLabel link_forget_password;
    }
}