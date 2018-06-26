using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ribeshanish.forms
{
    public partial class worldcupwinner : Form
    {
        public worldcupwinner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                MessageBox.Show(radioButton1.Text);
            }
            else if(radioButton2.Checked==true)
            {
                MessageBox.Show(radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show(radioButton3.Text);
            }

            else if (radioButton4.Checked == true)
            {
                MessageBox.Show(radioButton4.Text);
            }

            else if (radioButton5.Checked == true)
            {
                MessageBox.Show(radioButton5.Text);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton4.Text + " was checked");
        }
    }
}
