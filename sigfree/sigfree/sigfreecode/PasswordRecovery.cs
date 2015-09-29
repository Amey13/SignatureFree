using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sigfree_demo_
{
    public partial class PasswordRecovery : Form
    {
        public PasswordRecovery()
        {
            InitializeComponent();
        }

        private void PasswordRecovery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.t.Show();
            this.Dispose(); 
           
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Program.t.Show();
            this.Dispose(); 
        }

        private void but_recover_password_Click(object sender, EventArgs e)
        {
            //validations
            if (text_user_name.Text == "")
            {
                MessageBox.Show("Enter User Name...!");
                text_user_name.Focus();
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select Security question...!");
                comboBox1.Focus();
                return;
            }
            if (text_ans.Text == "")
            {
                MessageBox.Show("Enter Answer");
                text_ans.Focus();
                return;
            }
            
            try
            {
                
               
                
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=.;Initial Catalog=SigfreeDB;Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.Connection = cn;
                cmd.CommandText = "select * from UserInfo where userName='" + text_user_name.Text + "'and Answer='" + text_ans.Text + "'";
                dr=cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("User name or Answer you have provided is not Correct...!make shure that both are Correct");
                    return;
                }
                else
                {
                    dr.Read(); 
                    text_user_name.Text =dr[1].ToString();
                    MessageBox.Show("Your password is=" + dr[5].ToString());   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void but_reset_Click(object sender, EventArgs e)
        {
            text_user_name.Text = "";
           
            text_ans.Text = "";
            comboBox1.Text = "";
 
        }

    }
}
