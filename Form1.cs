using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangential_Velocity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, w1, v1;
            r1 = double.Parse(tb_1.Text);
            w1 = double.Parse(tb_2.Text);
            v1 = r1 * w1;
            tb_3.Text = v1.ToString();
        }
    }
}
