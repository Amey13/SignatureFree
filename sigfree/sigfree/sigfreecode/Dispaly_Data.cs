using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sigfree_demo_
{
    public partial class Dispaly_Data : Form
    {
        public Dispaly_Data()
        {
            InitializeComponent();
        }
       
        private void Dispaly_Data_Load(object sender, EventArgs e)
        {
       connectToDB cToDB = new connectToDB();
       dataGridView1.DataSource = cToDB.ViewReq();
        dataGridView2.DataSource = cToDB.ViewInstr();
        }
    }
}
