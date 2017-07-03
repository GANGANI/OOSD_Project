using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Stock_Control_Form : Form
    {

        public static Stock_Control_Form Current;

        public Stock_Control_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SC_Show_InvReport s1 = new SC_Show_InvReport();
            s1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SC_Update_Inventory s1 = new SC_Update_Inventory();
            s1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SC_Calculate_Inventory s1 = new SC_Calculate_Inventory();
            s1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main.Current.ShowDialog();
        }
    }
}
