using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace POSS
{
    public partial class frmRegister : Form
    {
        frmLogin frmLogin;
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ryan\source\repos\POSS\POSS\AccountDatabase.mdf;Integrated Security=True");
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void frmRegister_Leave(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmLogin = new frmLogin();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void username_Click(object sender, EventArgs e)
        {
            if (username.Text == "Enter username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }

        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Enter username";
                username.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.PasswordChar = '*';
                password.ForeColor = Color.Black;
            }

        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.PasswordChar = '\0';
                password.Text = "Password";
                password.ForeColor = Color.Silver;
            }
        }

        private void confirm_pass_Enter(object sender, EventArgs e)
        {
            if (confirm_pass.Text == "Confirm password")
            {
                confirm_pass.Text = "";
                confirm_pass.PasswordChar = '*';
                confirm_pass.ForeColor = Color.Black;
            }
        }

        private void confirm_pass_Leave(object sender, EventArgs e)
        {
            if (confirm_pass.Text == "")
            {
                confirm_pass.PasswordChar = '\0';
                confirm_pass.Text = "Confirm password";
                confirm_pass.ForeColor = Color.Silver;
            }
            if (confirm_pass.Text != password.Text)
            {
                confirmation.Text = "Passwords do not match. try again.";
                confirmation.ForeColor = Color.Red;
            }
            else
            {
                confirmation.ForeColor = Color.White;
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
            {
                password.PasswordChar = '\0';
                confirm_pass.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                confirm_pass.PasswordChar = '*';
            }
        }

        private void contact_Enter_1(object sender, EventArgs e)
        {
            if (contact.Text == "Contact")
            {
                contact.Text = "";
                contact.ForeColor = Color.Black;
            }
        }

        private void contact_Leave_1(object sender, EventArgs e)
        {

            if (contact.Text == "")
            {
                contact.Text = "Contact";
                contact.ForeColor = Color.Silver;
            }


        }

        private void email_Enter(object sender, EventArgs e)
        {

            if (email.Text == "Email")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {

            if (email.Text == "")
            {
                email.Text = "Email";
                email.ForeColor = Color.Silver;
            }
        }


        private void btn_confirm_Click(object sender, EventArgs e)
        {


            if (SqlConnection.State != ConnectionState.Open)
            {
                try
                {
                    SqlConnection.Open();

                    String checkAccount = $"SELECT * FROM ACCOUNTS WHERE USERNAME = '{username.Text.Trim()}'";

                    using (SqlCommand command = new SqlCommand(checkAccount, SqlConnection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("This username already exist!");
                        }
                        else if (confirm_pass.Text != password.Text)
                        {
                            MessageBox.Show("Passwords do not match. Please try again.");
                        }
                        else if (!Regex.IsMatch(contact.Text, @"^[0-9]{10,11}$"))
                        {
                            MessageBox.Show("Invalid contact number.");
                        }
                        else
                        {

                            String insertAccount = $"INSERT INTO ACCOUNTS (USERNAME, PASSWORD, CONTACT, EMAIL, DATE_CREATED ) VALUES (@USERNAME, @PASSWORD, @CONTACT,@EMAIL, @DATE)";
                            DateTime date = DateTime.Now;
                         
                            using (SqlCommand cmd = new SqlCommand(insertAccount, SqlConnection))
                            {
                                cmd.Parameters.AddWithValue("@USERNAME", username.Text.Trim());
                                cmd.Parameters.AddWithValue("@PASSWORD", confirm_pass.Text.Trim());
                                cmd.Parameters.AddWithValue("@CONTACT", contact.Text.Trim());
                                cmd.Parameters.AddWithValue("@EMAIL", email.Text.Trim());
                                cmd.Parameters.AddWithValue("@DATE", date);


                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Account successfully created. Proceed to Login.");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting Database: " + ex.Message);
                }
                finally
                {

                    SqlConnection.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}







