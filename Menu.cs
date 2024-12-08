using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Markup;
using LiveCharts;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POSS
{
    public partial class Menu : Form
    {
        int count;

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ryan\source\repos\POSS\POSS\Products.mdf;Integrated Security=True;Connect Timeout=30");
        public Menu()
        {
            InitializeComponent();

            string[] t = { "Now", "Week", "Month", "Year","Inventory" };

            foreach (string s in t)
            {
                mySales.Items.Add(s);
            }
            string[] grpStyle = {"Bar Chart", "Line Chart", "Pie Chart" };
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet1.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.productsDataSet1.Sales);
            

        }
        private int myCmd(string query)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

            finally
            {
                conn.Close();
            }
        }
        public void refresh()
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sales_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Show();
            dataGridView1.DataSource = salesBindingSource1;
            string SalesCount = "SELECT COUNT(*) FROM Sales";
            string revenue = "SELECT SUM(QuantitySold * SalePrice) FROM Sales";
            lbl1.Text = "Number of Sales";
            lbl2.Text = "Revenue";
            lbl3.Text = "-";

            products.Text = myCmd(SalesCount).ToString();
            lowstocks.Text = "$" + myCmd(revenue).ToString();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string sort = @"SELECT ItemID, SUM(QuantitySold) AS TotalQuantitySold,SUM(QuantitySold * SalePrice) AS TotalSales FROM Sales GROUP BY ItemID";

                    using (SqlCommand cmd = new SqlCommand(sort, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataTable.AcceptChanges();

                        chart1.Series[0].XValueMember = "TotalQuantitySold";
                        chart1.Series[0].YValueMembers = "TotalSales";


                        chart1.DataSource = dataTable;
                        chart1.DataBind();
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

        private void inventory_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView2.Hide();
            dataGridView1.DataSource = inventoryBindingSource;
            this.inventoryTableAdapter.Fill(this.productsDataSet.Inventory);
            string totalProducts = "SELECT COUNT(*) FROM Inventory";
            string lowstock = "SELECT COUNT(*) FROM Inventory WHERE quantity < 30";
            string oos = "SELECT COUNT(*) FROM Inventory WHERE quantity = 0";
            lbl1.Text = "Total Products";
            lbl2.Text = "Low Stock";
            lbl3.Text = "Out of Stock";
            products.Text = myCmd(totalProducts).ToString();
            lowstocks.Text = myCmd(lowstock).ToString();
            outofstock.Text = myCmd(oos).ToString();

            
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    string sort = @"SELECT COALESCE(Category, 'All Categories') AS Category, SUM(Quantity) AS TotalQuantity, 
                                    AVG(PricePerUnit) AS AveragePrice FROM Inventory GROUP BY CUBE(Category)";

                    using (SqlCommand cmd = new SqlCommand(sort, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataTable.AcceptChanges();

                        chart1.Series[0].XValueMember = "Category";
                        chart1.Series[0].YValueMembers = "TotalQuantity";


                        chart1.DataSource = dataTable;
                        chart1.DataBind();
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

        private void sortbtn_Click(object sender, EventArgs e)
        {

        }

        private void graphStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
          
          
            
        }

        private void mySales_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mySales.Text)
            {
                case "Inventory":
                    try
                    {
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();

                            string sort = @"SELECT COALESCE(Category, 'All Categories') AS Category, SUM(Quantity) AS TotalQuantity, 
                                    AVG(PricePerUnit) AS AveragePrice FROM Inventory GROUP BY CUBE(Category)";

                            using (SqlCommand cmd = new SqlCommand(sort, conn))
                            {
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                dataTable.AcceptChanges();

                                chart1.Series[0].XValueMember = "Category";
                                chart1.Series[0].YValueMembers = "TotalQuantity";


                                chart1.DataSource = dataTable;
                                chart1.DataBind();
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
                    break; 
            }
        }
    }
}
