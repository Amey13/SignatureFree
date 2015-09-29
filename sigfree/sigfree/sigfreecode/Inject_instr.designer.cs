namespace sigfree_demo_
{
    partial class Inject_instr
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
            this.Btn_add = new System.Windows.Forms.Button();
            this.cb_inst = new System.Windows.Forms.ComboBox();
            this.cb_op1 = new System.Windows.Forms.ComboBox();
            this.cb_op2 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_remv = new System.Windows.Forms.Button();
            this.lab_Total = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.lab_ULess = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LB_CTI = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LB_inst = new System.Windows.Forms.ListBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_injectedURL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_add
            // 
            this.Btn_add.BackColor = System.Drawing.Color.Transparent;
            this.Btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_add.Location = new System.Drawing.Point(409, 23);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(75, 23);
            this.Btn_add.TabIndex = 1;
            this.Btn_add.Text = "Add";
            this.Btn_add.UseVisualStyleBackColor = false;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // cb_inst
            // 
            this.cb_inst.FormattingEnabled = true;
            this.cb_inst.Location = new System.Drawing.Point(68, 25);
            this.cb_inst.Name = "cb_inst";
            this.cb_inst.Size = new System.Drawing.Size(105, 21);
            this.cb_inst.TabIndex = 5;
            // 
            // cb_op1
            // 
            this.cb_op1.FormattingEnabled = true;
            this.cb_op1.Location = new System.Drawing.Point(179, 25);
            this.cb_op1.Name = "cb_op1";
            this.cb_op1.Size = new System.Drawing.Size(105, 21);
            this.cb_op1.TabIndex = 6;
            // 
            // cb_op2
            // 
            this.cb_op2.FormattingEnabled = true;
            this.cb_op2.Location = new System.Drawing.Point(290, 25);
            this.cb_op2.Name = "cb_op2";
            this.cb_op2.Size = new System.Drawing.Size(105, 21);
            this.cb_op2.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(68, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(327, 82);
            this.listBox1.TabIndex = 8;
            // 
            // btn_remv
            // 
            this.btn_remv.Location = new System.Drawing.Point(409, 128);
            this.btn_remv.Name = "btn_remv";
            this.btn_remv.Size = new System.Drawing.Size(75, 23);
            this.btn_remv.TabIndex = 9;
            this.btn_remv.Text = "Remove";
            this.btn_remv.UseVisualStyleBackColor = true;
            this.btn_remv.Click += new System.EventHandler(this.btn_remv_Click);
            // 
            // lab_Total
            // 
            this.lab_Total.AutoSize = true;
            this.lab_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Total.ForeColor = System.Drawing.Color.Red;
            this.lab_Total.Location = new System.Drawing.Point(143, 175);
            this.lab_Total.Name = "lab_Total";
            this.lab_Total.Size = new System.Drawing.Size(17, 17);
            this.lab_Total.TabIndex = 37;
            this.lab_Total.Text = "0";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(44, 175);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(95, 17);
            this.Label12.TabIndex = 36;
            this.Label12.Text = "Total Inst. =";
            // 
            // lab_ULess
            // 
            this.lab_ULess.AutoSize = true;
            this.lab_ULess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ULess.ForeColor = System.Drawing.Color.Red;
            this.lab_ULess.Location = new System.Drawing.Point(468, 175);
            this.lab_ULess.Name = "lab_ULess";
            this.lab_ULess.Size = new System.Drawing.Size(17, 17);
            this.lab_ULess.TabIndex = 35;
            this.lab_ULess.Text = "0";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(348, 175);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(115, 17);
            this.lab.TabIndex = 34;
            this.lab.Text = "Useless Inst. =";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(325, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(230, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "(Illegal CTI or Register assignment Instructions )";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(325, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Illegal Instructions";
            // 
            // LB_CTI
            // 
            this.LB_CTI.FormattingEnabled = true;
            this.LB_CTI.Location = new System.Drawing.Point(328, 103);
            this.LB_CTI.Name = "LB_CTI";
            this.LB_CTI.Size = new System.Drawing.Size(286, 69);
            this.LB_CTI.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "(These instructions are in Assembly Language)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Distilled Instructions";
            // 
            // LB_inst
            // 
            this.LB_inst.FormattingEnabled = true;
            this.LB_inst.Location = new System.Drawing.Point(17, 103);
            this.LB_inst.Name = "LB_inst";
            this.LB_inst.Size = new System.Drawing.Size(286, 69);
            this.LB_inst.TabIndex = 28;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(209, 157);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 38;
            this.btn_next.Text = "Next Step";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_injectedURL);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.LB_inst);
            this.groupBox1.Controls.Add(this.lab_Total);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lab_ULess);
            this.groupBox1.Controls.Add(this.LB_CTI);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(71, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 246);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "***";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Infected URL";
            // 
            // TB_injectedURL
            // 
            this.TB_injectedURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_injectedURL.Location = new System.Drawing.Point(70, 40);
            this.TB_injectedURL.Name = "TB_injectedURL";
            this.TB_injectedURL.Size = new System.Drawing.Size(446, 23);
            this.TB_injectedURL.TabIndex = 38;
            this.TB_injectedURL.Text = "...Infected  Url...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_op2);
            this.groupBox2.Controls.Add(this.Btn_add);
            this.groupBox2.Controls.Add(this.btn_next);
            this.groupBox2.Controls.Add(this.cb_inst);
            this.groupBox2.Controls.Add(this.btn_remv);
            this.groupBox2.Controls.Add(this.cb_op1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(73, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 213);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inject Instructions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(71, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 67);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter URL";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "http://www.google.co.in/";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sigfree_demo_.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(275, 610);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(276, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Test Sigfree";
            // 
            // Inject_instr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(810, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Inject_instr";
            this.Text = "Test Module";
            this.Load += new System.EventHandler(this.Inject_instr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.ComboBox cb_inst;
        private System.Windows.Forms.ComboBox cb_op1;
        private System.Windows.Forms.ComboBox cb_op2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_remv;
        public System.Windows.Forms.Label lab_Total;
        public System.Windows.Forms.Label Label12;
        public System.Windows.Forms.Label lab_ULess;
        public System.Windows.Forms.Label lab;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.ListBox LB_CTI;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ListBox LB_inst;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_injectedURL;
    }
}

