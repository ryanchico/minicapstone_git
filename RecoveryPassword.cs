using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Controls.Menu;

namespace POSS
{
    public partial class RecoveryPassword : Form
    {
        frmLogin frmLogin;
        Email email = new Email();
        ChangePassword changePassword;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ryan\source\repos\POSS\POSS\AccountDatabase.mdf;Integrated Security=True");
        public RecoveryPassword()
        {
            InitializeComponent();
         
        }
        private void emailTxt_Enter(object sender, EventArgs e)
        {
            if (emailTxt.Text == "john@gmail.com")
            {
                emailTxt.Text = "";
                emailTxt.ForeColor = Color.Black;
            }
            else if (emailTxt.Text == "Enter the code")
            {
                emailTxt.Text = "";
                emailTxt.ForeColor = Color.Black;
            }
          
        }


        private void emailTxt_Leave(object sender, EventArgs e)
        {
            if (emailTxt.Text == "")
            {
                emailTxt.Text = "john@gmail.com";
                emailTxt.ForeColor = Color.Silver;
                
            }
           


        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string val = $"Select RECOVERY_PASS From Accounts where Email = '{email.getEmail()}' AND RECOVERY_PASS = '{emailTxt.Text}'";

                using (SqlCommand command = new SqlCommand(val, conn))
                {
                    SqlDataAdapter adptr = new SqlDataAdapter(command);
                    DataTable tbl = new DataTable();
                    adptr.Fill(tbl);

                    if (tbl.Rows.Count == 1)
                    {
                       MessageBox.Show("Success!");
                       changePassword = new ChangePassword(email.getEmail());
                       changePassword.ShowDialog();
                       this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong OTP");
                    }
                }
        }
        private static void SendEmail(string myEmail, string emailPassword, string receiverEmail, string emailSubject, string emailText)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(myEmail, emailPassword);

                MailMessage message = new MailMessage();
                message.To.Add(receiverEmail);
                message.From = new MailAddress(myEmail);
                message.Subject = emailSubject;
                message.Body = emailText;

                smtpClient.Send(message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static string recoveryPassword()
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 9; i++)
            {
                int index = random.Next(validChars.Length);
                password.Append(validChars[index]);
            }

            return password.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string checkEmail = $"Select * From ACCOUNTS where EMAIL = '{emailTxt.Text.Trim()}'";
                    string recPass = recoveryPassword();
                    string OTP = $"Update ACCOUNTS set RECOVERY_PASS = '{recPass}' where email = '{emailTxt.Text.Trim()}'";
                    using (SqlCommand command = new SqlCommand(OTP, conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand(checkEmail, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            SendEmail("ryanchico1223@gmail.com", "bcnd scxb rpcj fnxf", emailTxt.Text.Trim(), "Recovery Password", "This is your OneTime Recovery password gago: " + recPass);
                            MessageBox.Show("One-Time Recovery password already sent! Please check your email.");



                            label4.Text = $"An email message with 9-digit verification code was just sent to {emailTxt.Text}";
                            label4.Font = new Font("Microsoft Sans Serif", 14);
                            email.setEmail(emailTxt.Text);
                            
                            
                           
                            button1.Show();
                            button2.Hide();
                            emailTxt.Text = "";
                            //proceed to validation of otp and user input
                            

                        }

                        else
                        {
                            MessageBox.Show("This email does not exist in our system.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void RecoveryPassword_Load(object sender, EventArgs e)
        {
            button1.Hide();
            
        }
      public class Email
        {
            private string email;

            public void setEmail(string value)
            {
                email = value;
            }
            public string getEmail()
            {
                return email;
            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

