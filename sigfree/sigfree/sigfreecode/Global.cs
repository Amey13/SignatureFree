using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Data.SqlClient;
namespace sigfree_demo_
{
    class Global
    {
       
       
       
       
        public static String username;
        public static String password;
        
        public static String gsubject = "";
        public static String gbody = "";
      
        
        public string SendMail(string toList, string from, string ccList, string subject, string body)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string msg = string.Empty;
            try
            {
                MailAddress fromAddress = new MailAddress(from);
                message.From = fromAddress;
                message.To.Add(toList);
                if (ccList != null && ccList != string.Empty)
                    message.CC.Add(ccList);
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = body;
                smtpClient.Host = "smtp.gmail.com";   // We use gmail as our smtp client         
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("sigfreeDB@gmail.com", "sigfree123456");
                smtpClient.Send(message);
                msg = "Successful<BR>";
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        } //End Send Email Function 

        //Function to select action based on particular Intrusion Level
    
        public String getemailid()
        {
            SqlDataReader dr;
            String emailid="";
            try
            {

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=.;Initial Catalog=SigFreeDB;Integrated Security=True";
                cn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = cn;
                com.CommandText = "select UmailID from UserInfo where username='" + Global.username + "'";
                dr = com.ExecuteReader();
                dr.Read(); 
                emailid = dr[0].ToString();
                return emailid;
            }
            catch (Exception ex)
            {

            }
            return emailid; 
        }
     
     
     }
}

