﻿using System;
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
        public static Resource_Control_Form Current;

        public Resource_Control_Form()
        {
            Current = this;
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
            this.Hide();
            Main.Current.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result;

            try
            {
                result = MessageBox.Show("Are you sure to Quit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    this.Show();
                }

            }
            catch
            {
                Application.Exit();
            }
        }
    }
}
