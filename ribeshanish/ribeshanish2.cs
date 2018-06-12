using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ribeshanish
{
    public partial class ribeshanish2 : Form
    {
        public ribeshanish2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p;
            p = Convert.ToDouble(ptextbox.Text);

            double t;
            t = Convert.ToDouble(Ttextbox.Text);

            double r;
            r = Convert.ToDouble(rtextbox.Text);

            double interest = (p * t * r) / 100;

            MessageBox.Show("the interest is "+Convert.ToString(interest));
        }
    }
}
