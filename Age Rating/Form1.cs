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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ES().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Andorra().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new zh().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AR().ShowDialog();
        }
    }
}
