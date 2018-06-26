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
    public partial class RadioForm : Form
    {
        public RadioForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show(radioButton1.Text);
            }

            else if (radioButton2.Checked == true) 
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
        }
       
    }
}
