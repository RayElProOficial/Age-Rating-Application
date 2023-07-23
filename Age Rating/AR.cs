using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Rating
{
    public partial class AR : Form
    {
        public AR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label1.Text = "18";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;
            label1.Text = "ATP";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Orange;
            label1.Text = "13";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.OrangeRed;
            label1.Text = "16";
        }
    }
}
