namespace sigfree_demo_
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_user_name = new System.Windows.Forms.TextBox();
            this.text_email_id = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_first_name = new System.Windows.Forms.TextBox();
            this.text_last_name = new System.Windows.Forms.TextBox();
            this.but_create_acc = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.but_reset = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_display_msg = new System.Windows.Forms.Label();
            this.text_answer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_check_user_name = new System.Windows.Forms.Label();
            this.progress_creating_ac = new System.Windows.Forms.ProgressBar();
            this.lab_creating = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.text_pwd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name For login into Sigfree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Securuty Question";
            // 
            // text_user_name
            // 
            this.text_user_name.Location = new System.Drawing.Point(495, 62);
            this.text_user_name.Name = "text_user_name";
            this.text_user_name.Size = new System.Drawing.Size(237, 20);
            this.text_user_name.TabIndex = 0;
            // 
            // text_email_id
            // 
            this.text_email_id.Location = new System.Drawing.Point(494, 202);
            this.text_email_id.Name = "text_email_id";
            this.text_email_id.Size = new System.Drawing.Size(237, 20);
            this.text_email_id.TabIndex = 3;
            this.text_email_id.Leave += new System.EventHandler(this.text_email_id_Leave);
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
            this.comboBox1.Location = new System.Drawing.Point(494, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last Name";
            // 
            // text_first_name
            // 
            this.text_first_name.Location = new System.Drawing.Point(494, 128);
            this.text_first_name.Name = "text_first_name";
            this.text_first_name.Size = new System.Drawing.Size(237, 20);
            this.text_first_name.TabIndex = 1;
            // 
            // text_last_name
            // 
            this.text_last_name.Location = new System.Drawing.Point(494, 165);
            this.text_last_name.Name = "text_last_name";
            this.text_last_name.Size = new System.Drawing.Size(237, 20);
            this.text_last_name.TabIndex = 2;
            // 
            // but_create_acc
            // 
            this.but_create_acc.Location = new System.Drawing.Point(286, 315);
            this.but_create_acc.Name = "but_create_acc";
            this.but_create_acc.Size = new System.Drawing.Size(103, 23);
            this.but_create_acc.TabIndex = 6;
            this.but_create_acc.Text = "Create Account";
            this.but_create_acc.UseVisualStyleBackColor = true;
            this.but_create_acc.Click += new System.EventHandler(this.but_create_acc_Click);
            // 
            // but_exit
            // 
            this.but_exit.Location = new System.Drawing.Point(656, 315);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(75, 23);
            this.but_exit.TabIndex = 9;
            this.but_exit.Text = "Exit";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // but_reset
            // 
            this.but_reset.Location = new System.Drawing.Point(575, 315);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(75, 23);
            this.but_reset.TabIndex = 8;
            this.but_reset.Text = "Reset";
            this.but_reset.UseVisualStyleBackColor = true;
            this.but_reset.Click += new System.EventHandler(this.but_reset_Click);
            // 
            // but_update
            // 
            this.but_update.Location = new System.Drawing.Point(494, 315);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(75, 23);
            this.but_update.TabIndex = 7;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(738, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(737, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(737, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "*";
            // 
            // lbl_display_msg
            // 
            this.lbl_display_msg.AutoSize = true;
            this.lbl_display_msg.Location = new System.Drawing.Point(284, 413);
            this.lbl_display_msg.Name = "lbl_display_msg";
            this.lbl_display_msg.Size = new System.Drawing.Size(367, 13);
            this.lbl_display_msg.TabIndex = 20;
            this.lbl_display_msg.Text = "Password has been sent to your account...Check your MailBox for Password";
            this.lbl_display_msg.Visible = false;
            // 
            // text_answer
            // 
            this.text_answer.Location = new System.Drawing.Point(494, 278);
            this.text_answer.Name = "text_answer";
            this.text_answer.Size = new System.Drawing.Size(237, 20);
            this.text_answer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Your Answer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(737, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "*";
            // 
            // lab_check_user_name
            // 
            this.lab_check_user_name.AutoSize = true;
            this.lab_check_user_name.Location = new System.Drawing.Point(492, 98);
            this.lab_check_user_name.Name = "lab_check_user_name";
            this.lab_check_user_name.Size = new System.Drawing.Size(0, 13);
            this.lab_check_user_name.TabIndex = 25;
            // 
            // progress_creating_ac
            // 
            this.progress_creating_ac.Location = new System.Drawing.Point(286, 373);
            this.progress_creating_ac.Name = "progress_creating_ac";
            this.progress_creating_ac.Size = new System.Drawing.Size(446, 23);
            this.progress_creating_ac.TabIndex = 26;
            this.progress_creating_ac.Visible = false;
            // 
            // lab_creating
            // 
            this.lab_creating.AutoSize = true;
            this.lab_creating.Location = new System.Drawing.Point(284, 357);
            this.lab_creating.Name = "lab_creating";
            this.lab_creating.Size = new System.Drawing.Size(183, 13);
            this.lab_creating.TabIndex = 27;
            this.lab_creating.Text = "Creating Your Account Please Wait...";
            this.lab_creating.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(737, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "*";
            // 
            // text_pwd
            // 
            this.text_pwd.Location = new System.Drawing.Point(494, 95);
            this.text_pwd.Name = "text_pwd";
            this.text_pwd.PasswordChar = '*';
            this.text_pwd.Size = new System.Drawing.Size(237, 20);
            this.text_pwd.TabIndex = 29;
            this.text_pwd.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "User Password For login into Sigfree";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(832, 454);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.text_pwd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lab_creating);
            this.Controls.Add(this.progress_creating_ac);
            this.Controls.Add(this.lab_check_user_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_answer);
            this.Controls.Add(this.lbl_display_msg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.but_reset);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_create_acc);
            this.Controls.Add(this.text_last_name);
            this.Controls.Add(this.text_first_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.text_email_id);
            this.Controls.Add(this.text_user_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUser_FormClosing);
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_user_name;
        private System.Windows.Forms.TextBox text_email_id;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_first_name;
        private System.Windows.Forms.TextBox text_last_name;
        private System.Windows.Forms.Button but_create_acc;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_display_msg;
        private System.Windows.Forms.TextBox text_answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_check_user_name;
        private System.Windows.Forms.ProgressBar progress_creating_ac;
        private System.Windows.Forms.Label lab_creating;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_pwd;
        private System.Windows.Forms.Label label12;
    }
}