using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSS
{
    public partial class editQuantity : Form
    {
        public editQuantity()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quantity = order_quantity.Text;
            int orders = Convert.ToInt16(quantity);
            orders -= 1;
            order_quantity.Text = orders.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string quantity = order_quantity.Text;
            int orders = Convert.ToInt16(quantity);
            orders += 1;
            order_quantity.Text = orders.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string quantity = order_quantity.Text;
            int orders = Convert.ToInt16(quantity);
            orders += 2;
            order_quantity.Text = orders.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string quantity = order_quantity.Text;
            int orders = Convert.ToInt16(quantity);
            orders += 3;
            order_quantity.Text = orders.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string quantity = order_quantity.Text;
            int orders = Convert.ToInt16(quantity);
            orders += 5;
            order_quantity.Text = orders.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string quantity = order_quantity.Text;
            int orders = Convert.ToInt16(quantity);
            orders += 10;
            order_quantity.Text = orders.ToString();
        }
    }
}
