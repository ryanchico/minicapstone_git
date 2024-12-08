using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
       
        editQuantity editQuantity = new editQuantity();
        private void MainMenu_Load(object sender, EventArgs e)
        {
            order_panel.Hide();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            string itemName = "Burger";
            confirmOrders(itemName);
            editQuantity.Show();
            order_panel.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            editQuantity.Show();
        }
        private void confirmOrders(string itemName)
        {
            
        }
       
        
        
    }
}
