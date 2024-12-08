using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POSS.RecoveryPassword;

namespace POSS
{
    public partial class ChangePassword : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ryan\source\repos\POSS\POSS\AccountDatabase.mdf;Integrated Security=True");
        Email email = new Email();
        private string userEmail;
        frmLogin frmLogin;
        RecoveryPassword recover = new RecoveryPassword();
        public ChangePassword(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string checkPass = $"Select * From ACCOUNTS where EMAIL = '{userEmail}' and PASSWORD = '{currentPass.Text}'";

                    using (SqlCommand command = new SqlCommand(checkPass,conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 1)
                        {
                            wrngpasslbl.Hide();
                            if (newPass.Text == conPass.Text)
                            {

                                passworddntmatchlbl.Hide(); 
                                string updatePass = $"UPDATE ACCOUNTS SET PASSWORD = '{conPass.Text.Trim()}' WHERE EMAIL = '{userEmail}' AND PASSWORD = '{currentPass.Text}'";
                                using (SqlCommand cmd = new SqlCommand(updatePass, conn))
                                {
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("You succesfully changed your password. Proceed to Login");
                                    frmLogin = new frmLogin();
                                    frmLogin.ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                            {
                                passworddntmatchlbl.Show();
                            }
                        }
                        else
                        {
                            wrngpasslbl.Show();
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

   
        

        private void currentPass_Leave(object sender, EventArgs e)
        {
            try
            {
                wrngpasslbl.Hide();
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string checkPass = $"SELECT * FROM ACCOUNTS WHERE EMAIL = '{userEmail}' AND PASSWORD = '{currentPass.Text}' ";

                    using (SqlCommand cmd = new SqlCommand(checkPass, conn))
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        sqlDataAdapter.Fill(table);

                        if (table.Rows.Count != 1)
                        {

                            wrngpasslbl.Show();
                        }
                        
                    } 
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            wrngpasslbl.Hide();
            passworddntmatchlbl.Hide();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}