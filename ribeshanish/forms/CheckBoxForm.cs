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
    public partial class CheckBoxForm : Form
    {
        public CheckBoxForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(checkBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Control c in this.Controls)

            {
                if (c is CheckBox)




                {
                    CheckBox c1 = (CheckBox)c;
                    if (c1.Checked == true)
                    {
                        listBox1.Items.Add(c1.Text);
                        listBox1.Sorted = true;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (MathcheckBox.Checked==true)
            {
                listBox1.Items.Add(MathcheckBox.Text);
            }

            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                listBox1.Items.Add(checkBox4.Text);
            }
            if (EnglishCheckbox.Checked == true)
            {
                listBox1.Items.Add(EnglishCheckbox.Text);
            }
            if (checkBox8.Checked == true)
            {
                listBox1.Items.Add(checkBox8.Text);
            }





        }
    }
}