using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
namespace POSS
{
    public partial class frmLogin : Form
    {
        frmRegister fr;
        Menu menu;
        RecoveryPassword recoveryPassword;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ryan\source\repos\POSS\POSS\AccountDatabase.mdf;Integrated Security=True");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            fr = new frmRegister();
            this.Hide();
            fr.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
            
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Silver;
            }

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.PasswordChar = '*';
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "" )
            {
                password.PasswordChar = '\0';
                password.Text = "Password";
                password.ForeColor = Color.Silver;
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fr = new frmRegister();
            this.Close();
            fr.ShowDialog();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    String loginAccount = $"SELECT * FROM ACCOUNTS WHERE USERNAME = @USER AND PASSWORD = @PASS ";
                    
                    
                    using(SqlCommand cmd = new SqlCommand(loginAccount, conn)) {
                        cmd.Parameters.AddWithValue("@USER", username.Text.Trim());
                        cmd.Parameters.AddWithValue("@PASS", password.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count >= 1){
                            MessageBox.Show("Login successfully!");
                            menu = new Menu();
                            menu.ShowDialog();
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("Login Failed! Wrong username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: "+ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            recoveryPassword = new RecoveryPassword();
            recoveryPassword.ShowDialog();
            this.Close();
        }
    }
}
