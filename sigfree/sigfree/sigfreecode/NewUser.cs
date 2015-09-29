using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient; 
namespace sigfree_demo_
{
    public partial class NewUser : Form
    {
        SqlConnection cn = new SqlConnection();
        
        public NewUser()
        {
            InitializeComponent();
        }

        private void but_create_acc_Click(object sender, EventArgs e)
        {
           

            //code to validate user name
            
            SqlDataReader dr1;
            Boolean flag = false;
            string s1 = text_user_name.Text;
            string normalized1 = Regex.Replace(s1, @"\s", "");
            if (normalized1 == "")
            {
                MessageBox.Show("User Name Should not be Blank....!");
                text_user_name.Focus();
                return;

            }


            try
            {
                //Check if user name already exist
                SqlCommand cmd = new SqlCommand();
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "select username from UserInfo";
                dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    int res;



                    string normalized2 = dr1[0].ToString();
                    bool stringEquals = String.Equals(normalized1, normalized2,
                    StringComparison.OrdinalIgnoreCase);
                    if (stringEquals)
                    {
                        lab_check_user_name.Text = "User Name already Exist..Select any Other User Name...!";
                        text_user_name.Focus();
                        dr1.Close();
                        return;
                    }


                }
                if (flag == false)
                {
                    lab_check_user_name.Text = "";
                }
                dr1.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            cn.Close();
            //code to validate E-mail

            Regex mRegxExpression;
            if (text_email_id.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!mRegxExpression.IsMatch(text_email_id.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_email_id.Focus();
                    return; 
                }
            }



















            if (text_user_name.Text == "")
            {
                MessageBox.Show("Enter User Name...!");
                text_user_name.Focus();
                return;
            }
            if (text_pwd.Text == "")
            {
                MessageBox.Show("Enter password...!");
                text_pwd.Focus();
                return;
            }
            if (text_email_id.Text == "")
            {
                MessageBox.Show("Enter E-mail id...!");
                text_email_id.Focus();
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select Security question...!");
                comboBox1.Focus();
                return;
            }
            if (text_answer.Text == "")
            {
                MessageBox.Show("Enter Answer for security question...!");
                text_answer.Show();
                return;
            }




























































































            try
            {
                
                //Generate random Password of length 8
                string pass = text_pwd.Text;
                lab_creating.Visible = true; 
                progress_creating_ac.Visible = true;  
                progress_creating_ac.Value = 0;
                progress_creating_ac.Value = progress_creating_ac.Value + 20;  
                //send this password to user mail id
                String emailto = text_email_id.Text; 
                String subject="User name and Password for login into SigfreeDB";
                String body = "Welcome to SigfreeDB..Your Account is created Successfully...Your  User Name=" + text_user_name.Text + " and password=" + pass;
                Global g = new Global();
                progress_creating_ac.Value = progress_creating_ac.Value + 20;
                g.SendMail(emailto, "SigfreeDB@gmail.com", "", subject, body);
                lbl_display_msg.Visible = true;

                progress_creating_ac.Value = progress_creating_ac.Value + 20; 
                int res;
                int id;
                cn.Open();
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText ="select max(ID) from userInfo";
                cmd.Connection =cn;
                dr=cmd.ExecuteReader();
                dr.Read();
                if(! dr.IsDBNull (0))
                {
                    id=Convert.ToInt32(dr[0]);
                    id=id + 1;
                }
                else
                {
                    id=1;
                }
                dr.Close(); 
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "insert into UserInfo values("+ id + ",'" + text_user_name.Text + "','" + text_first_name.Text + "','" + text_last_name.Text + "','" + text_email_id.Text + "','" + pass + "'," + comboBox1.SelectedIndex + ",'" + text_answer.Text + "')" ;
                res=com.ExecuteNonQuery();
                //Automations
                progress_creating_ac.Value = progress_creating_ac.Value + 20; 
                //SqlCommand cm = new SqlCommand();
                //cm.Connection = cn;
                //cm.CommandText = "insert into login values(" + id + ",'" + text_user_name.Text + "','" + pass + "')";
                //res=cm.ExecuteNonQuery();
                progress_creating_ac.Value = progress_creating_ac.Value + 20;
                cn.Close();
                MessageBox.Show ("Account Creation Successful...!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            but_create_acc.Enabled = false;
            lab_creating.Visible = false;
            progress_creating_ac.Visible = false; 
        }

        private void text_email_id_Leave(object sender, EventArgs e)
        {
           

        }
        private static string CreateRandomPassword(int passwordLength)
        {
            string allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            char[] chars = new char[passwordLength];
            Random rd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
            }

            return new string(chars);
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            if (External.efrommain == 0)
            {
                this.Dispose(); 
            }
            else
            {
                Program.t.Show();
                this.Dispose();
            }
            
        }

        private void but_reset_Click(object sender, EventArgs e)
        {
          
            text_first_name.Text = "";
            text_pwd.Text = "";
            text_last_name.Text ="";
            text_email_id.Text = "";
            comboBox1.Text="";
            text_answer.Text = ""; 
 
        }


        private void NewUser_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=.;Initial Catalog=SigFreeDB;Integrated Security=True";
            cn.Open();
            if (External.efrommain == 0)
            {
                but_create_acc.Visible = false;
                but_update.Visible = true;
                text_user_name.Text  = Global.username;
                text_user_name.Enabled = false;  
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                cmd.Connection =cn;
                cmd.CommandText = "Select * from UserInfo where UserName='" + Global.username + "'";
                dr=cmd.ExecuteReader();
                dr.Read();
                text_first_name.Text = dr["FirstName"].ToString();
                text_last_name.Text = dr["LastName"].ToString();
                text_pwd.Text = dr["Password"].ToString();
                text_email_id.Text = dr["UmailID"].ToString();
                comboBox1.SelectedIndex = Convert.ToInt16(dr["Securityq"]);
                text_answer.Text = dr["Answer"].ToString();  
 
 
            }
            else
            {
                but_create_acc.Visible = true;
                but_update.Visible = false; 
            }
            cn.Close();
        }

        private void NewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (External.efrommain == 0)
            {
                this.Dispose();

            }
            else
            {
                Program.t.Show();
                this.Dispose();
            }
        }

        private void but_update_Click(object sender, EventArgs e)
        {
            try
            {
                text_user_name.ReadOnly = true;
               cn.Open();
                SqlCommand cm1 = new SqlCommand();
                cm1.Connection = cn;

                cm1.CommandText = "update userInfo set Password='" + text_pwd.Text+"', FirstName='" + text_first_name.Text + "',LastName='" + text_last_name.Text + "',UmailID='" + text_email_id.Text + "',Securityq=" + comboBox1.SelectedIndex + ",Answer='" + text_answer.Text + "' where UserName='"+text_user_name.Text +"'";
                cm1.ExecuteNonQuery();
                //cm1.CommandText = "update Login set Password='" + text_pwd.Text+"' where UserName='"+text_user_name.Text +"'";
                //cm1.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Updated Successfully...!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"\n\n "+ex.StackTrace);
                return;
            }
        }
      
     
       



        
    }
}
