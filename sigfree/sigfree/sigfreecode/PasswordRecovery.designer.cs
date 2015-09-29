namespace sigfree_demo_
{
    partial class PasswordRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecovery));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_user_name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.but_recover_password = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_ans = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_reset = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select your security Question";
            // 
            // text_user_name
            // 
            this.text_user_name.Location = new System.Drawing.Point(403, 60);
            this.text_user_name.Name = "text_user_name";
            this.text_user_name.Size = new System.Drawing.Size(214, 20);
            this.text_user_name.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "What is your Favourite Color?",
            "What is your Favourite teacher Name?",
            "What is the Name of your Birth Place?",
            "What was your childhood nickname?",
            "What is the name of your hometown?"});
            this.comboBox1.Location = new System.Drawing.Point(403, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // but_recover_password
            // 
            this.but_recover_password.Location = new System.Drawing.Point(215, 195);
            this.but_recover_password.Name = "but_recover_password";
            this.but_recover_password.Size = new System.Drawing.Size(124, 23);
            this.but_recover_password.TabIndex = 6;
            this.but_recover_password.Text = "Recover Password";
            this.but_recover_password.UseVisualStyleBackColor = true;
            this.but_recover_password.Click += new System.EventHandler(this.but_recover_password_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Answer";
            // 
            // text_ans
            // 
            this.text_ans.Location = new System.Drawing.Point(403, 157);
            this.text_ans.Name = "text_ans";
            this.text_ans.Size = new System.Drawing.Size(214, 20);
            this.text_ans.TabIndex = 9;
            // 
            // pictureBox1
            // 
            //this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(461, 195);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(75, 23);
            this.but_reset.TabIndex = 11;
            this.but_reset.Text = "Reset";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(542, 195);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(75, 23);
            this.but_exit.TabIndex = 12;
            this.but_exit.Text = "Exit";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(659, 269);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_ans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_recover_password);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.text_user_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PasswordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordRecovery_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_user_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button but_recover_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_ans;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Button but_exit;
    }
}