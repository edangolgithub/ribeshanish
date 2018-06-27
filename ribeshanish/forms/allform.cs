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
    public partial class allform : Form
    {
        public allform()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void allform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox4.Checked = true;
            }
            if (checkBox2.Checked == true)
            {
                checkBox5.Checked = true;
            }
           if (checkBox3.Checked == true)
                {
                checkBox6.Checked = true;
            }
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = true;
            }
            if (checkBox5.Checked == true)
            {
                checkBox2.Checked = true;
            }
            if (checkBox6.Checked == true)
            {
                checkBox3.Checked = true;
            }

        }
    }
}

