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
    public partial class Resource_Control_Form : Form
    {
        public Resource_Control_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_UpdateReport s1 = new RC_UpdateReport();
            s1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_Show_InvReport s1 = new RC_Show_InvReport();
            s1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RC_Calculate_Inventory s1 = new RC_Calculate_Inventory();
            s1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
