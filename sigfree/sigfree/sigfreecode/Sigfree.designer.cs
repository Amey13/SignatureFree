namespace sigfree_demo_
{
    partial class Sigfree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LB_A_Filt = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lab_Trace_URL = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_NA_Count = new System.Windows.Forms.Label();
            this.LB_Bytes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LB_inst = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LB_CTI = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.Btn_trace = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_count_NonAscii = new System.Windows.Forms.ListBox();
            this.lb_Each_tot = new System.Windows.Forms.ListBox();
            this.lb_each_useless = new System.Windows.Forms.ListBox();
            this.Btn_DispData = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(151, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "***";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(78, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(466, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "SigFree:A Signature-Free Buffer Overflow Attack Blocker";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(163, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(597, 69);
            this.listBox1.TabIndex = 1;
            // 
            // LB_A_Filt
            // 
            this.LB_A_Filt.FormattingEnabled = true;
            this.LB_A_Filt.HorizontalScrollbar = true;
            this.LB_A_Filt.Location = new System.Drawing.Point(163, 260);
            this.LB_A_Filt.Name = "LB_A_Filt";
            this.LB_A_Filt.Size = new System.Drawing.Size(379, 69);
            this.LB_A_Filt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = " ASCII Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Non Ascii Charactors";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lab_Trace_URL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Lab_Trace_URL
            // 
            this.Lab_Trace_URL.Name = "Lab_Trace_URL";
            this.Lab_Trace_URL.Size = new System.Drawing.Size(60, 17);
            this.Lab_Trace_URL.Text = "Trace URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "May contain Non-Printable )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Count =";
            // 
            // lb_NA_Count
            // 
            this.lb_NA_Count.AutoSize = true;
            this.lb_NA_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NA_Count.ForeColor = System.Drawing.Color.Red;
            this.lb_NA_Count.Location = new System.Drawing.Point(619, 226);
            this.lb_NA_Count.Name = "lb_NA_Count";
            this.lb_NA_Count.Size = new System.Drawing.Size(17, 17);
            this.lb_NA_Count.TabIndex = 8;
            this.lb_NA_Count.Text = "0";
            // 
            // LB_Bytes
            // 
            this.LB_Bytes.FormattingEnabled = true;
            this.LB_Bytes.HorizontalScrollbar = true;
            this.LB_Bytes.Location = new System.Drawing.Point(163, 392);
            this.LB_Bytes.Name = "LB_Bytes";
            this.LB_Bytes.Size = new System.Drawing.Size(302, 69);
            this.LB_Bytes.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Repsrsentaion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bytes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Traced URL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(160, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Distilled Instructions";
            // 
            // LB_inst
            // 
            this.LB_inst.FormattingEnabled = true;
            this.LB_inst.Location = new System.Drawing.Point(162, 506);
            this.LB_inst.Name = "LB_inst";
            this.LB_inst.Size = new System.Drawing.Size(286, 69);
            this.LB_inst.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "(These instructions are in Assembly Language)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(642, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Number Of Non ASCII ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(653, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Charactors Found";
            // 
            // LB_CTI
            // 
            this.LB_CTI.FormattingEnabled = true;
            this.LB_CTI.Location = new System.Drawing.Point(473, 505);
            this.LB_CTI.Name = "LB_CTI";
            this.LB_CTI.Size = new System.Drawing.Size(286, 69);
            this.LB_CTI.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(470, 468);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Illegal Instructions";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(470, 489);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(230, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "(Illegal CTI or Register assignment Instructions )";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(620, 372);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(106, 17);
            this.lab.TabIndex = 23;
            this.lab.Text = "Useless Inst. ";
            // 
            // Btn_trace
            // 
            this.Btn_trace.Location = new System.Drawing.Point(33, 123);
            this.Btn_trace.Name = "Btn_trace";
            this.Btn_trace.Size = new System.Drawing.Size(92, 69);
            this.Btn_trace.TabIndex = 25;
            this.Btn_trace.Text = "Trace URL";
            this.Btn_trace.UseVisualStyleBackColor = true;
            this.Btn_trace.Click += new System.EventHandler(this.Btn_trace_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(470, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Total Inst.";
            // 
            // lb_count_NonAscii
            // 
            this.lb_count_NonAscii.FormattingEnabled = true;
            this.lb_count_NonAscii.Location = new System.Drawing.Point(548, 260);
            this.lb_count_NonAscii.Name = "lb_count_NonAscii";
            this.lb_count_NonAscii.Size = new System.Drawing.Size(212, 69);
            this.lb_count_NonAscii.TabIndex = 28;
            // 
            // lb_Each_tot
            // 
            this.lb_Each_tot.FormattingEnabled = true;
            this.lb_Each_tot.Location = new System.Drawing.Point(473, 392);
            this.lb_Each_tot.Name = "lb_Each_tot";
            this.lb_Each_tot.Size = new System.Drawing.Size(137, 69);
            this.lb_Each_tot.TabIndex = 29;
            // 
            // lb_each_useless
            // 
            this.lb_each_useless.FormattingEnabled = true;
            this.lb_each_useless.Location = new System.Drawing.Point(622, 392);
            this.lb_each_useless.Name = "lb_each_useless";
            this.lb_each_useless.Size = new System.Drawing.Size(138, 69);
            this.lb_each_useless.TabIndex = 30;
            // 
            // Btn_DispData
            // 
            this.Btn_DispData.Location = new System.Drawing.Point(376, 603);
            this.Btn_DispData.Name = "Btn_DispData";
            this.Btn_DispData.Size = new System.Drawing.Size(157, 69);
            this.Btn_DispData.TabIndex = 31;
            this.Btn_DispData.Text = "Display Database";
            this.Btn_DispData.UseVisualStyleBackColor = true;
            this.Btn_DispData.Click += new System.EventHandler(this.Btn_DispData_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(160, 120);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(599, 72);
            this.progressBar1.TabIndex = 32;
            // 
            // Sigfree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 711);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Btn_DispData);
            this.Controls.Add(this.lb_each_useless);
            this.Controls.Add(this.lb_Each_tot);
            this.Controls.Add(this.lb_count_NonAscii);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Btn_trace);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LB_CTI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LB_inst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LB_Bytes);
            this.Controls.Add(this.lb_NA_Count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_A_Filt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Sigfree";
            this.Text = "SigFree";
            this.Load += new System.EventHandler(this.Sigfree_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
       
        public  System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox LB_A_Filt;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel Lab_Trace_URL;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lb_NA_Count;
        public System.Windows.Forms.ListBox LB_Bytes;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ListBox LB_inst;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.ListBox LB_CTI;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button Btn_trace;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.ListBox lb_count_NonAscii;
        public System.Windows.Forms.ListBox lb_Each_tot;
        public System.Windows.Forms.ListBox lb_each_useless;
        private System.Windows.Forms.Button Btn_DispData;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}

