using Age_Rating.Properties;
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
    public partial class Andorra : Form
    {
        public Andorra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.eu_7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.EU_12;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.eu_18;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.eu_16;
        }
    }
}
