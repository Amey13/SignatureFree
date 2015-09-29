using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient ;
namespace sigfree_demo_
{
    public partial class Login : Form
    {
        private Button b;
     
        public Login()
        {
            InitializeComponent();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            Boolean flag;
            flag = false;
           
          
            if (Global.username == "")
            {
                MessageBox.Show("Enter User Name...!");
                text_username.Focus(); 
                return;
            }
            if(Global.password =="")
            {
                MessageBox.Show ("Enter Password...!");
                text_password.Focus();
                return;
            }
            try
            {

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=.;Initial Catalog=SigFreeDB;Integrated Security=True";
                cn.Open();
                SqlCommand com = new SqlCommand();
                SqlDataReader dr;
                com.CommandText = "select * from UserInfo";
                com.Connection = cn;
                dr = com.ExecuteReader();
                
                //MessageBox.Show(Convert.ToString(dr[1]));  
                while (dr.Read())
                {
                    if (text_username.Text == Convert.ToString(dr["UserName"]) && text_password.Text == Convert.ToString(dr["Password"]))
                    {
                        SigfreeMDI m = new SigfreeMDI ();
                        m.Show();
                        Global.username = text_username.Text;
                        Global.password = text_password.Text;
                        this.Hide();
                        
                        flag = true;

                    }

                }
                if (flag == false)
                {
                    MessageBox.Show("Either User Name or Password is incorrect...!");
                    text_username.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void but_Reset_Click(object sender, EventArgs e)
        {
            text_username.Text ="";
            text_password .Text ="";
        }

        private void link_new_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            this.Hide(); 
            NewUser n = new NewUser();
            
            n.Show();
         

        }

        private void link_forget_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordRecovery p = new PasswordRecovery();
            this.Hide();
            p.Show(); 
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  
        }

     

    
    }
}
